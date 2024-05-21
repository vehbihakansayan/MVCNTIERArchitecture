using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using NorthwndCompany.VektorelMVCProject.Models.Entities;
using VektorelMVCProject.Models.ViewModels;

namespace NorthwndCompany.VektorelMVCProject.ApiServices
{
    public class CategoryApiService:BaseApiService<Category>
    {
        HttpClient _httpClient = new HttpClient();

        public CategoryApiService(HttpClient httpClient) :base(httpClient)
        {
            _httpClient = httpClient;
        }

        public List<Category> GetCategoriesWihtProducts()
        {
            // _httpClient'ın BaseAdresini startup dosyasında x.BaseAddress diyerek tanımladığımız için direk olarak bu şekilde kullanabiliyoruz.
            string endPoint = _httpClient.BaseAddress.ToString() + "categories/getcategorieswithproducts";

            HttpResponseMessage responseMessage = _httpClient.GetAsync(endPoint).Result;
            string content = responseMessage.Content.ReadAsStringAsync().Result;

            List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(content);

            return categories;
        }

        public Category AddCategory(AddCategoryDto category)
        {
            string endPoint = _httpClient.BaseAddress.ToString() + "categories/addcategory";

            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var responseMessage = _httpClient.PostAsync(endPoint, new StringContent(JsonConvert.SerializeObject(category), Encoding.UTF8, "application/json")).Result;
            string content = responseMessage.Content.ReadAsStringAsync().Result;

            Category cat = JsonConvert.DeserializeObject<Category>(content);
            return cat;
            
        }

        public bool RemoveCategory(int id)
        {
            string endPoint = _httpClient.BaseAddress.ToString() + $"categories/remove/{id}";

            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var responseMessage = _httpClient.DeleteAsync(endPoint).Result;

            if (responseMessage.StatusCode == HttpStatusCode.NoContent)
                return true;

            return false;
        }


        public Category UpdateCategory(AddCategoryDto category)
        {
            string endPoint = _httpClient.BaseAddress.ToString() + "categories/updatecategory";

            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var responseMessage = _httpClient.PutAsync(endPoint,new StringContent(JsonConvert.SerializeObject(category),Encoding.UTF8,"application/json")).Result;
            
            string content = responseMessage.Content.ReadAsStringAsync().Result;

            Category ctg = JsonConvert.DeserializeObject<Category>(content);
            return ctg;

        }
    }
}
