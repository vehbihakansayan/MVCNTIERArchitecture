using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NorthwndCompany.VektorelMVCProject.Models.Entities;

namespace NorthwndCompany.VektorelMVCProject.Models
{
    public class CountriesForEmployee
    {
        public List<Country> Countries { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
