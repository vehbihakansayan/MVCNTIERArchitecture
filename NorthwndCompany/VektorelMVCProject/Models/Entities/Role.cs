using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NorthwndCompany.VektorelMVCProject.Models.Abstract;

namespace NorthwndCompany.VektorelMVCProject.Models.Entities
{
    public class Role:IEntityApi
    {
        public Role()
        {
            EmployeeRoles = new HashSet<EmployeeRole>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public ICollection<EmployeeRole> EmployeeRoles { get; set; }
    }
}
