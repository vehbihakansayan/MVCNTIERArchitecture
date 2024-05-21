using System;
using System.Collections.Generic;
using System.Text;
using NorthwndCompany.VektorelMVCProject.Models.Abstract;

namespace NorthwndCompany.VektorelMVCProject.Models.Entities
{
    public class Order: IEntityApi
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipCity { get; set; }
        public string ShipCountry { get; set; }

        public Customer Customer { get; set; }
        public Employee Employee { get; set; }

    }
}
