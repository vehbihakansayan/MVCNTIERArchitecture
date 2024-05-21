using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwndCompany.VektorelMVCProject.Areas.Admin.Models
{
    public class InfoMail
    {
        public string From { get; set; }
        public string Password { get; set; }
        public string HostValue { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public int PortNumber { get; set; }

    }
}
