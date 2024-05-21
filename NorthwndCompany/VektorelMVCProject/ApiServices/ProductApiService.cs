using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using NorthwndCompany.VektorelMVCProject.Models.Entities;

namespace NorthwndCompany.VektorelMVCProject.ApiServices
{
    public class ProductApiService:BaseApiService<Product>
    {
        private readonly HttpClient _httpClient;

        public ProductApiService(HttpClient httpClient) : base(httpClient)
        {
            _httpClient = httpClient;
        }

        public List<Product> GetProductsWithCategories()
        {
            // _httpClient'ın BaseAdresini startup dosyasında x.BaseAddress diyerek tanımladığımız için direk olarak bu şekilde kullanabiliyoruz.
            string endPoint = _httpClient.BaseAddress.ToString() + "products/getproductswithcategories";

            var responseMessage = _httpClient.GetAsync(endPoint).Result; //Adrese başvurduk ve cevap geldi
            string content = responseMessage.Content.ReadAsStringAsync().Result; // gelen cevabın içeriğini okuduk

            List<Product> products = JsonConvert.DeserializeObject<List<Product>>(content); //Json olarak gelen cevabı listeye dönüştürdük

            return products;
            
        }

        public List<Product> GetByCategoryId(int CategoryId)
        {
            string endPoint = _httpClient.BaseAddress.ToString() + $"Products/getbycategoryid/{CategoryId}";
            var responseMessage = _httpClient.GetAsync(endPoint).Result;
            var result = responseMessage.Content.ReadAsStringAsync().Result;

            List<Product> products = JsonConvert.DeserializeObject<List<Product>>(result);
            return products;
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            string endPoint = _httpClient.BaseAddress.ToString() + $"products/getbyunitprice/{min}/{max}";
            var responseMessage = _httpClient.GetAsync(endPoint).Result;
            var result = responseMessage.Content.ReadAsStringAsync().Result;

            List<Product> products = JsonConvert.DeserializeObject<List<Product>>(result);
            return products;

        }

        public List<Product> GetByUnitsInStock(int max, int min)
        {
            string endPoint = _httpClient.BaseAddress.ToString() + $"products/getbystock/{min}/{max}";
            var responseMessage = _httpClient.GetAsync(endPoint).Result;
            var result = responseMessage.Content.ReadAsStringAsync().Result;

            List<Product> products = JsonConvert.DeserializeObject<List<Product>>(result);
            return products;
        }

        public Product EditProduct(Product product)
        {
            string endPoint = _httpClient.BaseAddress.ToString() + "products/editproduct";

            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var responseMessage = _httpClient.PutAsync(endPoint, new StringContent(JsonConvert.SerializeObject(product), Encoding.UTF8, "application/json")).Result;

            if (responseMessage.StatusCode.ToString() == "OK")
            {
                string content = responseMessage.Content.ReadAsStringAsync().Result;

                Product prd = JsonConvert.DeserializeObject<Product>(content);

                return prd;
            }
            else
                return null;

           
        }

        public Product AddProduct(Product product)
        {
            string endPoint = _httpClient.BaseAddress.ToString() + "products/addproduct";

            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var responseMessage = _httpClient.PostAsync(endPoint, new StringContent(JsonConvert.SerializeObject(product), Encoding.UTF8, "application/json")).Result;

            if (responseMessage.StatusCode.ToString() == "Created")
            {
                string content = responseMessage.Content.ReadAsStringAsync().Result;

                Product prd = JsonConvert.DeserializeObject<Product>(content);

                return prd;
            }
            else
                return null;           
        }

        public bool DeleteProduct(int id)
        {
            string endPoint = _httpClient.BaseAddress.ToString() + $"products/deleteproduct/{id}";
            var responseMessage = _httpClient.DeleteAsync(endPoint).Result;
            string content = responseMessage.StatusCode.ToString();
            if (content == "OK")
                return true;
            return false;

        }

    }
}
