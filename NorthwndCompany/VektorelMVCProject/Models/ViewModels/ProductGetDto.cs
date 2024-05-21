using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VektorelMVCProject.Models.ViewModels
{
    public class ProductGetDto
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
    }
}
