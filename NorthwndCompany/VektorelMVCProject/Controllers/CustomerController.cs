using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NorthwndCompany.VektorelMVCProject.ApiServices;
using NorthwndCompany.VektorelMVCProject.Models.Entities;

namespace NorthwndCompany.VektorelMVCProject.Controllers
{
    [Authorize]
    public class CustomerController : Controller
    {
        CustomerApiService _customerApi;

        public CustomerController(CustomerApiService customerApi)
        {
            _customerApi = customerApi;
        }

        [HttpGet]
        public IActionResult GetCustomersWithOrders()
        {
            List<Customer> customers = _customerApi.GetCustomersWithOrders();
            return View(customers);
        }

    }
}
