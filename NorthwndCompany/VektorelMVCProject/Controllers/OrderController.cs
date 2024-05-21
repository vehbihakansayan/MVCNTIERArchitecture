using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NorthwndCompany.VektorelMVCProject.ApiServices;

namespace NorthwndCompany.VektorelMVCProject.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        OrderApiService _orderApi;

        public OrderController(OrderApiService orderApi)
        {
            _orderApi = orderApi;
        }

        public IActionResult GetAllOrders()
        {
            return View(_orderApi.GetAllFromApi("orders"));
        }
    }
}
