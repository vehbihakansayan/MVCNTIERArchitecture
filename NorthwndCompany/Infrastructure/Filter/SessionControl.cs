using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using NorthwndCompany.Infrastructure.Extensions;

namespace NorthwndCompany.Infrastructure.Filter
{
    public class SessionControl:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            //Employee emp = context.HttpContext.Session.GetObject<Employee>("LoggedInUser");
            //if (emp == null)
            //    context.Result = new RedirectToActionResult("LogIn", "Auth", null);

            //SessionControl bu şekilde olacak ancak Infrastructure içinde entitiy'ler olmadığı için hata veriyor . O düzeltilere kullanılabilir.

        }
    }
}
