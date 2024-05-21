using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NorthwndCompany.VektorelMVCProject.Models.Abstract;

namespace NorthwndCompany.VektorelMVCProject.Models.Entities
{
    public class EmployeeRole:IEntityApi
    {
        public int EmployeeRoleId { get; set; }
        public int RoleId { get; set; }
        public int EmployeeID { get; set; }

        public Employee Employee { get; set; }
        public Role Role { get; set; }
    }
}
