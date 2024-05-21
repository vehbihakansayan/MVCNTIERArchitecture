using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NorthwndCompany.VektorelMVCProject.Models.Abstract;

namespace NorthwndCompany.VektorelMVCProject.Models.Entities
{
    public class City:IEntityApi
    {
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public string CityName { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
