using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NorthwndCompany.VektorelMVCProject.ApiServices;
using NorthwndCompany.VektorelMVCProject.Areas.Admin.Models;
using NorthwndCompany.Infrastructure.Filter;
using NorthwndCompany.VektorelMVCProject.Models.Entities;
using VektorelMVCProject.Models.ViewModels;

namespace NorthwndCompany.VektorelMVCProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminProductController : Controller
    {

        ProductApiService _productApi;
        CategoryApiService _categoryApi;

        public AdminProductController(ProductApiService productApi, CategoryApiService categoryApi)
        {
            _productApi = productApi;
            _categoryApi = categoryApi;
        }

        //public IActionResult GetProducts()
        //{
        //    ProductWithCategories pc = new ProductWithCategories();
        //    pc.Categories = _categoryApi.GetAllFromApi("categories");
        //    pc.Products = _productApi.GetAllFromApi("products");
        //    return View(pc);
        //}

        public IActionResult GetProducts()
        {
            ProductWithCategories pwc = new ProductWithCategories();
            pwc.Products = _productApi.GetProductsWithCategories();
            pwc.Categories = _categoryApi.GetAllFromApi("categories");
            return View(pwc);
        }

        public IActionResult GetProductById(int id)
        {
            Product product = _productApi.GetFromApi("products",id);
            if(product != null)
                return Json(new {result=true, updateproduct = product });
            return Json(new { result = false,message="Ürün bilgileri çekilirken hata oluştu!" });
        }

        [HttpGet]
        public ActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Product());
            else
            {
                Product product = _productApi.GetFromApi("products", id);
                return View(product);
            }
        }

        [HttpPost]
        public ActionResult AddOrEdit(Product product)
        {
            if (product.ProductID == 0)
            {
                Product prd = _productApi.AddProduct(product);
                if (prd != null)
                    return Json(new { result = true, message = "İşlem Başarılı", newproduct = prd });                  
                return Json(new { result = false, message = "Ürün kaydı başarısız!" });
            }
            else
            {
                Product prd = _productApi.EditProduct(product);
                if(prd!=null)
                    return Json(new { result = true, message = $"{product.ProductID} nolu ürün başarıyla güncellenmiştir.", updateproduct=prd });
                return Json(new { result = false, message = "Güncelleme İşlemi Başarısız!"});
            }

        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            bool value = _productApi.DeleteProduct(id);
            if(value)
                return Json(new { result = true, message = $"{id} nolu ürün başarıyla silinmiştir." });
            return Json(new { result = false, message = "Ürün silme işlemi başarısız!" });

        }
    }
}
