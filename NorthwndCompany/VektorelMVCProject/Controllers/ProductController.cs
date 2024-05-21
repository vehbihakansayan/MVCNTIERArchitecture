using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NorthwndCompany.VektorelMVCProject.ApiServices;
using NorthwndCompany.Infrastructure.Filter;
using NorthwndCompany.VektorelMVCProject.Models.Entities;
using NorthwndCompany.VektorelMVCProject.Models.ViewModels;

namespace NorthwndCompany.VektorelMVCProject.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        ProductApiService _productApi;
        CategoryApiService _categoryApi;

        public ProductController(ProductApiService productApi,CategoryApiService categoryApi)
        {
            _productApi = productApi;
            _categoryApi = categoryApi;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            List<Product> products = _productApi.GetAllFromApi("products");
            return View(products);
        }

        [HttpGet]
        public IActionResult GetProductsWithCategory()
        {
            List<Product> products = _productApi.GetProductsWithCategories();
            return View(products);
        }

        [HttpGet]
        public IActionResult GetProduct(int id)
        {
            return View(_productApi.GetFromApi("products",id));
        }

        [HttpGet]
        public IActionResult GetByCategoryId(int id)
        {
            return View(_productApi.GetByCategoryId(id));
        }

        [HttpGet]
        public IActionResult GetByUnitPrice()
        {
            return View(_productApi.GetByUnitPrice(15, 80));
        }

        [HttpGet]
        public IActionResult GetByUnitsInStock()
        {
            return View(_productApi.GetByUnitsInStock(10, 100));
        }

        [HttpGet]
        public IActionResult EditProduct(int id)
        {

            ProductViewModel model = new ProductViewModel();
            model.Product = _productApi.GetFromApi("products", id);
            model.Categories = _categoryApi.GetAllFromApi("categories").Select(ctg => new SelectListItem()
            {
                Text = ctg.CategoryName,
                Value = ctg.CategoryID.ToString(),
                Selected = ctg.CategoryID == model.Product.CategoryID
            }).ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult EditProduct(Product product)
        {
            _productApi.EditProduct(product);
            List<Product> products = _productApi.GetProductsWithCategories();
            ViewBag.EditProduct = $"<div class='alert alert-success' class='alert'>{product.ProductID} numaralı ürün başarıyla güncellemiştir</div>";
            return View("GetProductsWithCategory",products);
        }

    }
}
