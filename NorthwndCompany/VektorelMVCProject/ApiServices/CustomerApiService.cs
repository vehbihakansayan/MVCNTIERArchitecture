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
    public class CustomerApiService:BaseApiService<Customer>
    {

        HttpClient _httpClient;

        public CustomerApiService(HttpClient httpClient):base(httpClient) // base alınan sınıfın default contructor'ı olmadığı için o sınıfın hangi constructor'ını kullanacağına dair yönlendirme yapıyorum...
        {
            _httpClient = httpClient;
        }

        public List<Customer> GetCustomersWithOrders()
        {
            string endPoint = _httpClient.BaseAddress.ToString() + "customers/getcustomerswithorders";

            var responseMessage = _httpClient.GetAsync(endPoint).Result;
            string content = responseMessage.Content.ReadAsStringAsync().Result;

            List<Customer> customers = JsonConvert.DeserializeObject<List<Customer>>(content);

            return customers;

        }

        public Customer GetByCustomerId(string id)
        {
            string endPoint = _httpClient.BaseAddress.ToString() + $"customers/get/{id}";

            var responseMessage = _httpClient.GetAsync(endPoint).Result;
            string content = responseMessage.Content.ReadAsStringAsync().Result;

            Customer customers = JsonConvert.DeserializeObject<Customer>(content);
            return customers;
        }

        public Customer AddCustomer(Customer customer)
        {
            string endPoint = _httpClient.BaseAddress.ToString() + "customers/addcustomer";

            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var responseMessage = _httpClient.PostAsync(endPoint, new StringContent(JsonConvert.SerializeObject(customer), Encoding.UTF8, "application/json")).Result;

            string content = responseMessage.Content.ReadAsStringAsync().Result;

            Customer cstmr = JsonConvert.DeserializeObject<Customer>(content);

            return cstmr;
        }

        public Customer UpdateCustomer(Customer customer)
        {
            string endPoint = _httpClient.BaseAddress + "customers/updatecustomer";
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var responseMessage = _httpClient.PostAsync(endPoint, new StringContent(JsonConvert.SerializeObject(customer), Encoding.UTF8, "application/json")).Result;
            string content = responseMessage.Content.ReadAsStringAsync().Result;
            Customer cstmr = JsonConvert.DeserializeObject<Customer>(content);
            return cstmr;
        }

        public bool DeleteCustomer(string id)
        {
            string endPoint = _httpClient.BaseAddress.ToString() + $"customers/deletecustomer/{id}";
            var responseMessage = _httpClient.DeleteAsync(endPoint).Result;
            string content = responseMessage.StatusCode.ToString();
            if (content == "OK")
                return true;
            return false;

        }
    }
}
