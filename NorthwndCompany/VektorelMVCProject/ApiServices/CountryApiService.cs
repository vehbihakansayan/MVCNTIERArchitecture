using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using NorthwndCompany.VektorelMVCProject.Models.Entities;

namespace NorthwndCompany.VektorelMVCProject.ApiServices
{
    public class CountryApiService:BaseApiService<Country>
    {
        public CountryApiService(HttpClient httpClient):base(httpClient)
        {

        }
    }
}
