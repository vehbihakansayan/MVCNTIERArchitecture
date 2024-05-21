using Microsoft.AspNetCore.Mvc;
using NorthwndCompany.Infrastructure.Filter;
using NorthwndCompany.VektorelMVCProject.ApiServices;
using NorthwndCompany.VektorelMVCProject.Models.Entities;
using System.Collections.Generic;

namespace NorthwndCompany.VektorelMVCProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [SessionControl]
    public class AdminCustomerController:Controller
    {
        private readonly CustomerApiService _customerApi;

        public AdminCustomerController(CustomerApiService customerApi)
        {

            _customerApi = customerApi;
        }

        [HttpGet]
        public IActionResult GetCustomers()
        {
            List<Customer> customers = _customerApi.GetAllFromApi("customers");
            return View(customers);
        }

        [SessionControl("Admin")]
        [ModelStateFilter]
        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            Customer cstmr = _customerApi.AddCustomer(customer);
            if (cstmr != null)
                return Json(new { result = true, message = $"{customer.CustomerID} numaralı müşteri başarıyla kaydedilmiştir", newcustomer = cstmr });
            return Json(new { result = false, message = "Yeni müşteri ekleme işlemi başarısız!" });
        }

        [HttpGet]
        public IActionResult GetCustomerById(string id)
        {
            Customer customer = _customerApi.GetByCustomerId(id);
            return Json(new { updatecustomer = customer});
        }

        [SessionControl("Admin")]
        [ModelStateFilter]
        [HttpPost]
        public IActionResult UpdateCustomer(Customer customer)
        {
            Customer cstmr = _customerApi.UpdateCustomer(customer);
            if (cstmr != null)
                return Json(new { result = true, message = $"{cstmr.CustomerID} numaralı müşteri başarıyla güncellenmiştir", updateCustomer = cstmr});
            return Json(new { result = false, message = "Müşteri güncelleme işlemi başarısız!" });

        }

        [SessionControl("Admin")]
        [HttpDelete]
        public IActionResult DeleteCustomer(string id)
        {
            bool value = _customerApi.DeleteCustomer(id);
            if (value)
                return Json(new { result = true, message = $"{id} numaralı sipariş başarıyla silinmiştir." });
            return Json(new { result = false, message = "Sipariş silme işlemi başarısız!" });

        }
    }
}
