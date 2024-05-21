using NorthwndCompany.VektorelMVCProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwndCompany.VektorelMVCProject.Areas.Admin.Models
{
    public class AddOrderDto
    {
        public List<Customer> Customers { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Order> Orders { get; set; }
    }
}
