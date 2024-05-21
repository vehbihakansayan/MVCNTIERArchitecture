using Infrastructure.Extensions;
using Microsoft.AspNetCore.Mvc;
using NorthwndCompany.Infrastructure.Filter;
using NorthwndCompany.VektorelMVCProject;
using NorthwndCompany.VektorelMVCProject.ApiServices;
using NorthwndCompany.VektorelMVCProject.Areas.Admin.Models;
using NorthwndCompany.VektorelMVCProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace NorthwndCompany.VektorelMVCProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [SessionControl]
    public class AdminOrderController : Controller
    {
        private readonly OrderApiService _orderApi;
        private readonly EmployeeApiService _employeeApi;
        private readonly CustomerApiService _customerApi;

        public AdminOrderController(OrderApiService orderApi, EmployeeApiService employeeApi, CustomerApiService customerApi)
        {
            _orderApi = orderApi;
            _employeeApi = employeeApi;
            _customerApi = customerApi;
        }

        [HttpGet]
        public IActionResult GetOrders()
        {
            AddOrderDto addOrder = new AddOrderDto();
            addOrder.Orders = _orderApi.GetAllFromApi("orders");
            addOrder.Employees = _employeeApi.GetAllFromApi("employees");
            addOrder.Customers = _customerApi.GetAllFromApi("customers");
            return View(addOrder);
        }

        [SessionControl("Admin")]
        [ModelStateFilter]
        [HttpPost]
        public IActionResult AddOrder(Order order)
        {
            Order ord =_orderApi.AddOrder(order);
            if(ord!=null)
                return Json(new { result = true, message = $"{ord.OrderID} numaralı sipariş başarıyla kaydedilmiştir",neworder=ord });
            return Json(new { result = false, message = "Yeni sipariş ekleme işlemi başarısız!" });
        }

        [HttpGet]
        public IActionResult GetOrderById(int id)
        {
            Order order = _orderApi.GetFromApi("orders",id);
            string odt = ConvertDateTime.CovertDateTime(order.OrderDate);
            return Json(new {updateorder = order, orderdate=odt });
        }

        [SessionControl("Admin")]
        [ModelStateFilter]
        [HttpPost]
        public IActionResult UpdateOrder(Order order)
        {
            Order ord = _orderApi.UpdateOrder(order);
            string odt = ConvertDateTime.CovertDateTime(ord.OrderDate);
            if (ord != null)
                return Json(new { result = true, message = $"{ord.OrderID} numaralı kategori başarıyla güncellenmiştir", updateOrder = ord,odt=odt });
            return Json(new { result = false, message = "Kategori güncelleme işlemi başarısız!" });

        }

        [SessionControl("Admin")]
        [HttpDelete]
        public IActionResult DeleteOrder(int id)
        {
            bool value = _orderApi.DeleteOrder(id);
            if (value)
                return Json(new { result = true, message = $"{id} numaralı sipariş başarıyla silinmiştir." });
            return Json(new { result = false, message = "Sipariş silme işlemi başarısız!" });

        }

    }
}
