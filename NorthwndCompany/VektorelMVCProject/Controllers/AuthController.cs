using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NorthwndCompany.VektorelMVCProject.ApiServices;
using NorthwndCompany.VektorelMVCProject.Models.Entities;
using NorthwndCompany.VektorelMVCProject.Models.ViewModels;
using NorthwndCompany.Infrastructure.Utilities.Jwt;

namespace NorthwndCompany.VektorelMVCProject.Controllers
{
    public class AuthController : Controller
    {
        EmployeeApiService _employeeApi;
        IConfiguration _configuration;

        public AuthController(EmployeeApiService employeeApi, IConfiguration configuration)
        {
            _employeeApi = employeeApi;
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LogIn(LogInEmployee login)
        {
            Employee employee = _employeeApi.TokenEmployee(login);

            if (employee != null)
            {
                List<string> roleNames = employee.EmployeeRoles.Select(e => e.Role.RoleName).ToList();

                AccessToken accessToken = new JwtHelper(_configuration).CreateToken(employee.EmployeeID, employee.FirstName + " " + employee.LastName, roleNames);

                HttpContext.Session.SetString("LoggedInUserToken", accessToken.Token);

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
