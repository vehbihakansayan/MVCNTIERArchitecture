using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using NorthwndCompany.VektorelMVCProject.Areas.Admin.Models;
using NorthwndCompany.VektorelMVCProject.Models.Entities;
using NorthwndCompany.VektorelMVCProject.Models.ViewModels;
using VektorelMVCProject.Models.ViewModels;

namespace NorthwndCompany.VektorelMVCProject.ApiServices
{
    public class EmployeeApiService:BaseApiService<Employee>
    {
        HttpClient _httpClient;
        public EmployeeApiService(HttpClient httpClient):base(httpClient)
        {
            _httpClient = httpClient;
        }

        public Employee AddEmployee(Employee employee)
        {
            string endPoint = _httpClient.BaseAddress.ToString() + "employees/addemployee";

            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var responseMessage = _httpClient.PostAsync(endPoint, new StringContent(JsonConvert.SerializeObject(employee), Encoding.UTF8, "application/json")).Result;

            string content = responseMessage.Content.ReadAsStringAsync().Result;

            Employee emp = JsonConvert.DeserializeObject<Employee>(content);

            return emp;
        }

        public Employee GetByEmployeeId(int id)
        {
            string endPoint = _httpClient.BaseAddress.ToString() + $"employees/getemployeewithorders/{id}";

            var responseMessage = _httpClient.GetAsync(endPoint).Result;
            string content = responseMessage.Content.ReadAsStringAsync().Result;

            Employee emp = JsonConvert.DeserializeObject<Employee>(content);
            return emp;
        }

        public Employee EditEmployee(EmployeeUpdateDto employee)
        {
            string endPoint = _httpClient.BaseAddress.ToString() + "employees/editemployee";

            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var responseMessage = _httpClient.PostAsync(endPoint, new StringContent(JsonConvert.SerializeObject(employee), Encoding.UTF8, "application/json")).Result;

            string content = responseMessage.Content.ReadAsStringAsync().Result;

            Employee emp = JsonConvert.DeserializeObject<Employee>(content);

            return emp;
        }

        public bool DeleteEmployee(int id)
        {
            string endPoint = _httpClient.BaseAddress.ToString() + $"employees/deleteEmployee/{id}";
            var responseMessage = _httpClient.DeleteAsync(endPoint).Result;
            string content = responseMessage.StatusCode.ToString();
            if (content == "OK")
                return true;
            return false;

        }

        public Employee LogInEmployee(UserInformation user)
        {
            string endPoint = _httpClient.BaseAddress.ToString() + "employees/loginemployee";

            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var responseMessage = _httpClient.PostAsync(endPoint, new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json")).Result;

            string content = responseMessage.Content.ReadAsStringAsync().Result;

            Employee emp = JsonConvert.DeserializeObject<Employee>(content);

            return emp;
        }

        public Employee TokenEmployee(LogInEmployee login)
        {
            string endPoint = _httpClient.BaseAddress.ToString() + "employees/tokenemployee";

            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var responseMessage = _httpClient.PostAsync(endPoint, new StringContent(JsonConvert.SerializeObject(login), Encoding.UTF8, "application/json")).Result;

            string content = responseMessage.Content.ReadAsStringAsync().Result;

            Employee emp = JsonConvert.DeserializeObject<Employee>(content);

            return emp;

        } 

        public List<Employee> EmployeeWithCountryAndCity()
        {
            string endPoint = _httpClient.BaseAddress.ToString() + "employees/withcityandcountry";

            var responseMessage = _httpClient.GetAsync(endPoint).Result;

            string content = responseMessage.Content.ReadAsStringAsync().Result;

            List<Employee> employees = JsonConvert.DeserializeObject<List<Employee>>(content);

            return employees;
        }

        public Employee GetEmployeeForUpdate(int id)
        {
            string endPoint = _httpClient.BaseAddress.ToString() + $"employees/getemployeeforupdate/{id}";
            var responseMessage = _httpClient.GetAsync(endPoint).Result;
            string content = responseMessage.Content.ReadAsStringAsync().Result;
            string status = responseMessage.StatusCode.ToString();
            if (status == "OK")
            {
                Employee employee = JsonConvert.DeserializeObject<Employee>(content);
                return employee;
            }
            return null;
            
        }

    }
}
