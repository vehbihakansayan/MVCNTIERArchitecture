using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NorthwndCompany.VektorelMVCProject.Models.Entities;
using NorthwndCompany.VektorelMVCProject.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwndCompany.VektorelMVCProject.ViewComponents
{
    public class TopBarViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            string jwt = HttpContext.Session.GetString("LoggedInUserToken");
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var emp = jwtSecurityTokenHandler.ReadJwtToken(jwt).Claims;
            LogInEmployee logInEmployee = new LogInEmployee();
            foreach (var item in emp)
            {
                if (item.Type.EndsWith("/claims/name"))
                {
                    logInEmployee.UserName = item.Value;
                    break;
                }              
            }
            return View(logInEmployee);
        }
    }
}
