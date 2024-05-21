using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NorthwndCompany.VektorelMVCProject.ApiServices;
using NorthwndCompany.VektorelMVCProject.Areas.Admin.Models;
using NorthwndCompany.VektorelMVCProject.Models.Entities;
using NorthwndCompany.Infrastructure.Extensions;
using NorthwndCompany.Infrastructure.Filter;

namespace NorthwndCompany.VektorelMVCProject.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class AdminAuthController : Controller
    {

        EmployeeApiService _employeeApi;

        public AdminAuthController(EmployeeApiService employeeApi)
        {
            _employeeApi = employeeApi;
        }

        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }

        [ModelStateFilter]
        [HttpPost]
        public IActionResult LogIn(UserInformation user)
        {
            Employee emp = _employeeApi.LogInEmployee(user);

            if (emp != null)
            {
                HttpContext.Session.SetObject("LoggedInUser", emp);
                return Json(new { Result = true });
            }
            else
                return Json(new { Result = false, Message = "Kullanıcı bulunamadı!" });            
        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return View("LogIn");
        }
    }
}
