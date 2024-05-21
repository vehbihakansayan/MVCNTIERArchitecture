using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NorthwndCompany.VektorelMVCProject.ApiServices;
using NorthwndCompany.Infrastructure.Filter;
using NorthwndCompany.VektorelMVCProject.Models.Entities;
using VektorelMVCProject.Models.ViewModels;

namespace NorthwndCompany.VektorelMVCProject.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        CategoryApiService _categoryApi;

        public CategoryController(CategoryApiService categoryApi)
        {
            _categoryApi = categoryApi;
        }

        [HttpGet]
        public IActionResult GetAllCategories()
        {
            List<Category> categories = _categoryApi.GetCategoriesWihtProducts();
            return View(categories);
        }

        
        [HttpPost]
        public IActionResult AddCategory(AddCategoryDto category)
        {
            Category ctg=_categoryApi.AddCategory(category);
            //List<Category> categories = _categoryApi.GetCategoriesWihtProducts();
            //ViewBag.Message = $"<div class='alert alert-success' role='alert'>{result.CategoryID} numaralı kategori kaydedilmiştir.</div>";
            return Json(new {Result = true, Message = $"{ctg.CategoryID} nolu {ctg.CategoryName} kategorisi başarıyla eklenmiştir", data=ctg});
        }

        [HttpDelete]
        public IActionResult RemoveCategory(int id)
        {
            _categoryApi.RemoveCategory(id);
            Category ctg = _categoryApi.GetFromApi("categories", id);
            return Json(ctg);
        }


        [HttpPut]
        public IActionResult UpdateCategory(AddCategoryDto category)
        {
            _categoryApi.UpdateCategory(category);
            return Json(category);
        }

    }
}
