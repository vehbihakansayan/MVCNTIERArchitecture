using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NorthwndCompany.VektorelMVCProject.Models.Entities;

namespace NorthwndCompany.VektorelMVCProject.Areas.Admin.Models
{
    public class ProductWithCategories
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
    }
}
