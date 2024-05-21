using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using NorthwndCompany.VektorelMVCProject.Models.Entities;
using System.Net.Http.Headers;
using System.Text;

namespace NorthwndCompany.VektorelMVCProject.ApiServices
{
    public class OrderApiService:BaseApiService<Order>
    {

        HttpClient _httpClient;
        
        public OrderApiService(HttpClient httpClient) : base(httpClient)
        {
            _httpClient = httpClient;
        }

        public List<Order> GetByEmployeeId(int id)
        {
            string endPoint = _httpClient.BaseAddress.ToString() + $"orders/getbyemployeeid/{id}";

            var responseMessage = _httpClient.GetAsync(endPoint).Result;
            string content = responseMessage.Content.ReadAsStringAsync().Result;

            List<Order> orders = JsonConvert.DeserializeObject<List<Order>>(content);
            return orders;
        }

        public Order AddOrder(Order order)
        {
            string endPoint = _httpClient.BaseAddress.ToString() + "orders/addorder";

            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var responseMessage = _httpClient.PostAsync(endPoint, new StringContent(JsonConvert.SerializeObject(order), Encoding.UTF8, "application/json")).Result;

            string content = responseMessage.Content.ReadAsStringAsync().Result;

            Order ord = JsonConvert.DeserializeObject<Order>(content);

            return ord;
        }

        public Order UpdateOrder(Order order)
        {
            string endPoint = _httpClient.BaseAddress + "orders/updateorder";
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var responseMessage = _httpClient.PostAsync(endPoint, new StringContent(JsonConvert.SerializeObject(order), Encoding.UTF8, "application/json")).Result;
            string content = responseMessage.Content.ReadAsStringAsync().Result;
            Order ord = JsonConvert.DeserializeObject<Order>(content);
            return ord;
        }

        public bool DeleteOrder(int id)
        {
            string endPoint = _httpClient.BaseAddress.ToString() + $"orders/deleteOrder/{id}";
            var responseMessage = _httpClient.DeleteAsync(endPoint).Result;
            string content = responseMessage.StatusCode.ToString();
            if (content == "OK")
                return true;
            return false;

        }

    }
}
