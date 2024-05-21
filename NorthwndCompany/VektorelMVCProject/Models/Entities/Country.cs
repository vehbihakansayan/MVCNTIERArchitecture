using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NorthwndCompany.VektorelMVCProject.Models.Abstract;

namespace NorthwndCompany.VektorelMVCProject.Models.Entities
{
    public class Country:IEntityApi
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public List<Employee> Employees { get; set; } 
    }
}
