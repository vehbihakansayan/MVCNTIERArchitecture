using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using NorthwndCompany.VektorelMVCProject.ApiServices;
using NorthwndCompany.Infrastructure.Extensions;
using NorthwndCompany.Infrastructure.Filter;
using NorthwndCompany.VektorelMVCProject.Models;
using NorthwndCompany.VektorelMVCProject.Models.Entities;
using NorthwndCompany.VektorelMVCProject.Models.ViewModels;
using NorthwndCompany.Infrastructure.Utilities.Jwt;

namespace NorthwndCompany.VektorelMVCProject.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {       
        private readonly CategoryApiService _categoryApi;
        private readonly ProductApiService _productApi;

        public HomeController(CategoryApiService categoryApi, ProductApiService productApi)
        {
            _categoryApi = categoryApi;
            _productApi = productApi;

        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewModelCategoryProduct model = new ViewModelCategoryProduct();
            model.Categories = _categoryApi.GetCategoriesWihtProducts();
            model.Products = _productApi.GetProductsWithCategories();
            return View(model);
        }
    }
}
