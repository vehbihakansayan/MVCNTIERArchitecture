using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using NorthwndCompany.VektorelMVCProject.Models.Abstract;

namespace NorthwndCompany.VektorelMVCProject.Models.Entities
{
    public class Category: IEntityApi
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public byte[] Picture { get; set; }

        public List<Product> Products { get; set; }
        public string Base64Photo
        {
            get
            {
                if (CategoryID > 1 && CategoryID < 9)
                    return Convert.ToBase64String(Picture, 78, Picture.Length - 78);

                return null;
            }

        }

        public string categoryPhoto { get; set; }
        public IFormFile categoryFilePhoto { get; set; }
    }
}
