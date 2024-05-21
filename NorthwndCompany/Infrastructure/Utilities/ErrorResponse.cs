using System.Collections.Generic;

namespace NorthwndCompany.VektorelMVCProject.Utilities
{
    public class ErrorResponse
    {
        public List<ErrorModel> Errors { get; set; } = new List<ErrorModel>();
    }
}
