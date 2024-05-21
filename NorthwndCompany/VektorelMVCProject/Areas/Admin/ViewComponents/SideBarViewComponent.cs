using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NorthwndCompany.VektorelMVCProject.ApiServices;
using NorthwndCompany.Infrastructure.Extensions;
using NorthwndCompany.VektorelMVCProject.Models.Entities;

namespace NorthwndCompany.VektorelMVCProject.Areas.Admin.ViewComponents
{
    public class SideBarViewComponent:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            Employee employee = HttpContext.Session.GetObject<Employee>("LoggedInUser");

            return View(employee);
        }
    }
}
