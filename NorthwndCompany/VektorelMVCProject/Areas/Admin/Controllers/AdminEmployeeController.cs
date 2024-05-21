using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using NorthwndCompany.VektorelMVCProject.ApiServices;
using NorthwndCompany.VektorelMVCProject.Areas.Admin.Models;
using NorthwndCompany.Infrastructure.Filter;
using NorthwndCompany.VektorelMVCProject.Models.Entities;
using NorthwndCompany.Infrastructure.Utilities;
using Infrastructure.Extensions;
using NorthwndCompany.VektorelMVCProject;
using VektorelMVCProject.Models.ViewModels;

namespace NorthwndCompany.VektorelMVCProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [SessionControl]
    public class AdminEmployeeController : Controller
    {

        EmployeeApiService _employeeApi;
        CountryApiService _countryApi;
        IConfiguration _configuration;

        public AdminEmployeeController(EmployeeApiService employeeApi, CountryApiService countryApi, IConfiguration configuration)
        {
            _employeeApi = employeeApi;
            _countryApi = countryApi;
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult GetEmployees()
        {
            CountriesForEmployee cce = new CountriesForEmployee();
            cce.Employees = _employeeApi.GetAllFromApi("employees");
            cce.Countries = _countryApi.GetAllFromApi("countries");
            return View(cce);
        }

        [SessionControl("Admin")]
        [ModelStateFilter]
        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {

            string fileName=RandomValueGenerator.GenerateFileName(employee.EmployeeImage.FileName);
            
            using (FileStream fs = new FileStream(Directory.GetCurrentDirectory() + $"/wwwroot/image/employeePhoto/{fileName}", FileMode.Create))
            {
                employee.EmployeeImage.CopyTo(fs);
                employee.PhotoPath = fileName;
            }

            Employee emp = _employeeApi.AddEmployee(employee);
            
            if (emp != null)
            {
                InfoMail infoMail = _configuration.GetSection("InfoMail").Get<InfoMail>();                
                MailSender.Send(infoMail.From, "vehbihakan@deneme.com",infoMail.Content);
                return Json(new { result = true, message = $"{emp.EmployeeID} nolu personel başarıyla eklenmiştir.", newemployee = emp });
            }
                
            return Json(new { result = false, message = "Personel ekleme işlemi başarısız!" });
        }

        [SessionControl("Admin")]
        [HttpDelete]
        public IActionResult DeleteEmployee(int id)
        {
            bool value = _employeeApi.DeleteEmployee(id);
            if (value)
                return Json(new { result = true, message = $"{id} numaralı personel başarıyla silinmiştir." });
            return Json(new { result = false, message = "Personel silme işlemi başarısız!" });
            
        }

 
        [HttpGet]
        public IActionResult GetEmployeeForUpdate(int id)
        {
            Employee emp = _employeeApi.GetEmployeeForUpdate(id);
            string birthdate = ConvertDateTime.CovertDateTime(emp.BirthDate);
            string hiredate = ConvertDateTime.CovertDateTime(emp.HireDate);
            if (emp != null)
                return Json(new { result = true, newemp = emp, bdt= birthdate,hdt= hiredate });
            return Json(new { result = false, message = "Personel bilgilerini çekerken bir hata oluştu!" });
        }

        [SessionControl("Admin")]
        [ModelStateFilter]
        [HttpPost]
        public IActionResult UpdateEmployee(EmployeeUpdateDto dto)
        {
            Employee emp = _employeeApi.EditEmployee(dto);
            if (emp != null)
                return Json(new { result = true, message = $"{emp.EmployeeID} numaralı personel başarıyla güncellenmiştir!", editemployee=emp });
            return Json(new { result = false, message = "Personel bilgileri güncellenirken bir hata oluştu!" });
        }
    }
}
