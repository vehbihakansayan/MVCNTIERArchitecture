using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Principal;
using System.Threading.Tasks;
using NorthwndCompany.VektorelMVCProject.Models.Abstract;

namespace NorthwndCompany.VektorelMVCProject.ApiServices
{
    public class BaseApiService<TEntity>
        where TEntity: class,IEntityApi,new()
    {
        private readonly HttpClient _httpClient;

        public BaseApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public List<TEntity> GetAllFromApi(string route)
        {
            string endPoint = _httpClient.BaseAddress.ToString() + $"{route}/getall";

            var responseMessage = _httpClient.GetAsync(endPoint).Result;
            string content = responseMessage.Content.ReadAsStringAsync().Result;

            List<TEntity> entities = JsonConvert.DeserializeObject<List<TEntity>>(content);

            return entities;
        }

        public TEntity GetFromApi(string route, int id)
        {
            string endPoint = _httpClient.BaseAddress.ToString() + $"{route}/get/{id}";
            
            var responseMessage = _httpClient.GetAsync(endPoint).Result;
            string content = responseMessage.Content.ReadAsStringAsync().Result;
            
            TEntity entity = JsonConvert.DeserializeObject<TEntity>(content);
            
            return entity;
        }

    }
}
