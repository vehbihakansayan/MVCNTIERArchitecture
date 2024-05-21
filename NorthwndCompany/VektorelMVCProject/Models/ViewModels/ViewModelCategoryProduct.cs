using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NorthwndCompany.VektorelMVCProject.Models.Entities;

namespace NorthwndCompany.VektorelMVCProject.Models.ViewModels
{
    public class ViewModelCategoryProduct
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
    }
}
