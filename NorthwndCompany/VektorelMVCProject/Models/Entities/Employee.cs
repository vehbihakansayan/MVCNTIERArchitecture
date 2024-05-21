using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using NorthwndCompany.VektorelMVCProject.Areas.Admin.Models;
using NorthwndCompany.VektorelMVCProject.Models.Abstract;

namespace NorthwndCompany.VektorelMVCProject.Models.Entities
{
    public class Employee : IEntityApi
    {
        public Employee()
        {
            EmployeeRoles = new HashSet<EmployeeRole>();
        }

        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string Address { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public City City { get; set; }
        public Country Country { get; set; }
        public string PhotoPath { get; set; }
        public int? ReportsTo { get; set; } 
        public IFormFile EmployeeImage { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public List<Order> Orders { get; set; }
        public string Base64Photo { get; set; }

        public virtual List<EmployeeManagerFullName> ReportingEmployee { get; set; }
        public virtual EmployeeManagerFullName ReportedManager { get; set; }

        public string ManagerFullName
        {
            get
            {
                if (ReportedManager != null)
                    return ReportedManager.FirstName + " " + ReportedManager.LastName;
                return "BAĞLI OLDUĞU YÖNETİCİ YOK";
            }
        }

        public virtual ICollection<EmployeeRole> EmployeeRoles { get; set; }
    }
}
