using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using NorthwndCompany.VektorelMVCProject.ApiServices;
using NorthwndCompany.Infrastructure.Filter;
using NorthwndCompany.VektorelMVCProject.Models.Entities;
using NorthwndCompany.Infrastructure.Utilities;
using FluentValidation.Results;
using NorthwndCompany.VektorelMVCProject.Utilities;
using VektorelMVCProject.Models.ViewModels;

namespace NorthwndCompany.VektorelMVCProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminCategoryController : Controller
    {

        CategoryApiService _categoryApi;

        public AdminCategoryController(CategoryApiService categoryApi)
        {
            _categoryApi = categoryApi;
        }

        [HttpGet]
        public IActionResult CategoryList()
        {
            List<Category> categories = _categoryApi.GetAllFromApi("categories");
            return View(categories);
        }

        [HttpDelete]
        public IActionResult RemoveCategory(int id)
        {
            _categoryApi.RemoveCategory(id);
            return Json(new { result = true });
        }

        [HttpPost]
        [ModelStateFilter]
        public IActionResult AddCategory(AddCategoryDto category)
        {
            if (category.categoryFilePhoto != null)
            {
                if (!category.categoryFilePhoto.ContentType.StartsWith("image"))
                {
                    ErrorResponse errorReponse = new ErrorResponse();
                    ErrorModel errorModel = new ErrorModel();
                    errorModel.FieldName = "Dosya Uzantısı";
                    errorModel.Message = "Lütfen bir resim doyası seçiniz!";
                    errorReponse.Errors.Add(errorModel);
                    return Json(new { result = false, message = errorReponse });
                }
                else if (category.categoryFilePhoto.Length > 1000 * 1024)
                {
                    ErrorResponse errorReponse = new ErrorResponse();
                    ErrorModel errorModel = new ErrorModel();
                    errorModel.FieldName = "Dosya Boyutu";
                    errorModel.Message = "Lütfen 100 KB'dan daha küçük bir fotoğraf seçiniz!";
                    errorReponse.Errors.Add(errorModel);
                    return Json(new { result = false, message = errorReponse });
                }

                string fileName = RandomValueGenerator.GenerateFileName(category.categoryFilePhoto.FileName);

                // Directory.GetCurrentDirectory() projemizin uzantısına ulaşmak için bu metodu kullanıyoruz

                using (FileStream fs = new FileStream(Directory.GetCurrentDirectory() + $"/wwwroot/image/categoryPhoto/{fileName}", FileMode.Create))
                {
                    category.categoryFilePhoto.CopyTo(fs);
                    category.categoryPhoto = fileName;
                }

                Category ctg = _categoryApi.AddCategory(category);

                if (ctg != null)
                {
                    return Json(new { result = true, message = ctg.CategoryID + " nolu " + ctg.CategoryName + " kategorisi başarıyla kaydedilmiştir!", newCategory = ctg });
                }
                else
                {
                    ErrorResponse errorReponse = new ErrorResponse();
                    ErrorModel errorModel = new ErrorModel();
                    errorModel.FieldName = "Kayıt";
                    errorModel.Message = "Kategori kayıt işlemi başarısız";
                    errorReponse.Errors.Add(errorModel);
                    return Json(new { result = false, message = errorReponse });
                }
            }
            else
            {
                ErrorResponse errorReponse = new ErrorResponse();
                ErrorModel errorModel = new ErrorModel();
                errorModel.FieldName = "Fotoğraf";
                errorModel.Message = "Lütfen bir resim dosyası seçiniz";
                errorReponse.Errors.Add(errorModel);
                return Json(new { result = false, message =  errorReponse});
            }
        }

        [ModelStateFilter]
        [HttpPost]
        public IActionResult UpdateCategory(AddCategoryDto category)
        {

            if (category.categoryPhoto != null)
            {      

                    string fileName = RandomValueGenerator.GenerateFileName(category.categoryFilePhoto.FileName);

                    // Directory.GetCurrentDirectory() projemizin uzantısına ulaşmak için bu metodu kullanıyoruz

                    using (FileStream fs = new FileStream(Directory.GetCurrentDirectory() + $"/wwwroot/image/categoryPhoto/{fileName}", FileMode.Create))
                    {
                        category.categoryFilePhoto.CopyTo(fs);
                        category.categoryPhoto = fileName;
                    }

                    Category ctg = _categoryApi.UpdateCategory(category);

                    if (ctg != null)
                        return Json(new { result = true, message = $"{ctg.CategoryID} nolu {ctg.CategoryName} kategorisi başarıyla güncellenmiştir!", updateCtg = ctg });

                    return Json(new { result = false, message = "Güncelleme işlemi başarısız!" });

            }
            else
            {                          
                    Category ctg = _categoryApi.UpdateCategory(category);

                    if (ctg != null)
                        return Json(new { result = true, message = $"{ctg.CategoryID} nolu {ctg.CategoryName} kategorisi başarıyla güncellenmiştir!", updateCtg = ctg });

                    return Json(new { result = false, message = "Kayıt Başarısız" });
            }
          
        }
    }
}
