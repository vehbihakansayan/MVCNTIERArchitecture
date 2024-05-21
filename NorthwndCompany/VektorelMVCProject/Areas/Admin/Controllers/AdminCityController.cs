using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NorthwndCompany.VektorelMVCProject.ApiServices;
using NorthwndCompany.Infrastructure.Filter;
using NorthwndCompany.VektorelMVCProject.Models.Entities;

namespace NorthwndCompany.VektorelMVCProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminCityController : Controller
    {

        CityApiService _cityApi;

        public AdminCityController(CityApiService cityApi)
        {
            _cityApi = cityApi;
        }
        
        [HttpPost]
        public IActionResult GetCitiesByCountry(int countryId)
        {
            List<City> allcities =  _cityApi.GetCitiesByCountry(countryId);

            if (allcities != null)
                return Json(new { result = true, cities = allcities });

            return Json(new { result = false, message = "Şehirleri listelerken bir hata oluştu!" });
            
        }
    }
}
