using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NorthwndCompany.VektorelMVCProject.Models.Entities;

namespace NorthwndCompany.VektorelMVCProject.Models.ViewModels
{
    public class ViewModelEmployeeOrders
    {
        public Employee Employee { get; set; }
        public List<Order> Orders { get; set; }
    }
}
