using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using NorthwndCompany.VektorelMVCProject.Models.Entities;

namespace NorthwndCompany.VektorelMVCProject.ApiServices
{
    public class CityApiService:BaseApiService<City>
    {

        HttpClient _httpClient;

        public CityApiService(HttpClient httpClient):base(httpClient)
        {
            _httpClient = httpClient;
        }


        public List<City> GetCitiesByCountry(int id)
        {
            string endPoint = _httpClient.BaseAddress.ToString() + $"cities/getcitiesbycountry/{id}";

            var responseMessage = _httpClient.GetAsync(endPoint).Result;
            string content = responseMessage.Content.ReadAsStringAsync().Result;

            List<City> cities = JsonConvert.DeserializeObject<List<City>>(content);

            return cities;
         
        } 
    }
}
