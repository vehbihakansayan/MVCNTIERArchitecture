using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NorthwndCompany.VektorelMVCProject.ApiServices;
using NorthwndCompany.Infrastructure.Filter;
using NorthwndCompany.VektorelMVCProject.Models.Entities;
using NorthwndCompany.VektorelMVCProject.Models.ViewModels;
using NorthwndCompany.VektorelMVCProject.Models;
using VektorelMVCProject.Models.ViewModels;

namespace NorthwndCompany.VektorelMVCProject.Controllers
{
    [Authorize(Roles ="Admin")]
    public class EmployeeController : Controller
    {
        EmployeeApiService _employeeApi;
        OrderApiService _orderApi;
        CountryApiService _countryApi;
        CityApiService _cityyApi;

        public EmployeeController(EmployeeApiService employeeApi,OrderApiService orderApi, CountryApiService countryApi, CityApiService cityyApi)
        {
            _employeeApi = employeeApi;
            _orderApi = orderApi;
            _countryApi = countryApi;
            _cityyApi = cityyApi;
        }
        
        public IActionResult GetAllEmployees()
        {
            List<Employee> employees = _employeeApi.GetAllFromApi("employees");
            return View(employees);
        }

        public IActionResult OrganizationalChart()
        {
            List<Employee> employees = _employeeApi.GetAllFromApi("employees");
            return View(employees);
        }

        [HttpGet]
        public IActionResult GetByEmployeeId(int id)
        {
            ViewModelEmployeeOrders model = new ViewModelEmployeeOrders();
            model.Employee = _employeeApi.GetByEmployeeId(id);
            model.Orders = _orderApi.GetByEmployeeId(id);
            return View(model);
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            CountriesForEmployee cfe = new CountriesForEmployee();
            cfe.Countries = _countryApi.GetAllFromApi("countries");
            cfe.Employees = _employeeApi.GetAllFromApi("employees");
            return View(cfe);
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            Employee emp =_employeeApi.AddEmployee(employee);

            // View'e TempData gönderme
            //TempData["Message"] = $"<div class='alert alert-success' role='alert'>{emp.EmployeeID} numaralı personel kaydedilmiştir.</div>";
            //return RedirectToAction("GetAllEmployees","Employee");

            if (emp != null)
                return Json(new { result = true, message = $"{emp.EmployeeID} numaralı personel başarıyla eklenmiştir." });
            else
                return Json(new { result = false, message = "Personel ekleme işlemi başarısız!"});

        }

        [HttpGet]
        public IActionResult EditEmployee(int id)
        {
            Employee employee = _employeeApi.GetFromApi("employees", id);
            return View(employee);
        }

        [HttpPost]
        public IActionResult EditEmployee(EmployeeUpdateDto emp)
        {
            _employeeApi.EditEmployee(emp);
            ViewModelEmployeeOrders model = new ViewModelEmployeeOrders();
            model.Employee = _employeeApi.GetByEmployeeId(emp.EmployeeID);
            model.Orders = _orderApi.GetByEmployeeId(emp.EmployeeID);
            ViewBag.Employee = $"<div class='alert alert-success role='alert'>{emp.EmployeeID} nolu personel bilgileri başrarıyla güncellenmiştir</div>";
            return View("GetByEmployeeId", model);
        }

        [HttpGet]
        public IActionResult GetCitiesByCountry(int countryId)
        {
            List<City> allcities = _cityyApi.GetCitiesByCountry(countryId);

            if (allcities != null)
                return Json(new { result = true, cities = allcities });

            return Json(new { result = false, message = "Şehirleri listelerken bir hata oluştu!" });

        }

    }
}
