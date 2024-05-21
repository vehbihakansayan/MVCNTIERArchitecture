using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using NorthwndCompany.Infrastructure.Extensions;
using NorthwndCompany.VektorelMVCProject.Models.Entities;
using NorthwndCompany.VektorelMVCProject.Utilities;
using System.Collections.Generic;
using System.Linq;

namespace NorthwndCompany.VektorelMVCProject
{
    public class SessionControl:ActionFilterAttribute
    {
        private readonly string[] _allowedRoles;

        public SessionControl(params string[] roles)
        {
            _allowedRoles = roles;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Employee emp = context.HttpContext.Session.GetObject<Employee>("LoggedInUser");
            if (emp == null)
                context.Result = new RedirectToActionResult("LogIn", "AdminAuth", null);

            bool isApproved = false;
            if (_allowedRoles.Length != 0)
            {
                if (emp.EmployeeRoles.Count != 0)
                {
                    foreach (var employeeRole in emp.EmployeeRoles)
                    {
                        if (_allowedRoles.Contains(employeeRole.Role.RoleName))
                        {
                            isApproved = true;
                            break;
                        }

                        if (!isApproved)
                        {
                            ErrorResponse errorReponse = new ErrorResponse();
                            ErrorModel errorModel = new ErrorModel();
                            errorModel.FieldName = "Yetkisiz İşlem";
                            errorModel.Message = "Bu işlemi yapmak için gerekli yetkiniz yoktur!";
                            errorReponse.Errors.Add(errorModel);                            
                            context.Result = new JsonResult(new { result = false, message = errorReponse });
                            //context.Result = new RedirectToActionResult("LogIn", "AdminAuth", null);
                        }

                    }
                }
                else
                {
                    ErrorResponse errorReponse = new ErrorResponse();
                    ErrorModel errorModel = new ErrorModel();
                    errorModel.FieldName = "Yetkisiz İşlem";
                    errorModel.Message = "Bu işlemi yapmak için gerekli yetkiniz yoktur!";
                    errorReponse.Errors.Add(errorModel);
                    context.Result = new JsonResult(new { result = false, message = errorReponse });
                }

                
            }            
        }
    }
}
