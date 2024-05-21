using Microsoft.AspNetCore.Http;
using NorthwndCompany.VektorelMVCProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VektorelMVCProject.Models.ViewModels
{
    public class AddCategoryDto
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }

        public List<Product> Products { get; set; }

        public string categoryPhoto { get; set; }
        public IFormFile categoryFilePhoto { get; set; }
    }
}
