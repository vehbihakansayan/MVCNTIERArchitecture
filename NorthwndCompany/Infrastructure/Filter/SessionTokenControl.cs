using NorthwndCompany.Infrastructure.Utilities.Jwt;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using NorthwndCompany.Infrastructure.Extensions;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;


namespace NorthwndCompany.Infrastructure.Filter
{
    public class SessionTokenControl:ActionFilterAttribute
    {
        private readonly string _allowedRoles;
        public IConfiguration Configuration { get; }

        public SessionTokenControl(string allowedRoles=null)
        {
            _allowedRoles = allowedRoles;
        }


        public override void OnActionExecuting(ActionExecutingContext context)
        {
            AccessToken token = context.HttpContext.Session.GetObject<AccessToken>("JWToken");
            TokenOption tokenOption = context.HttpContext.Session.GetObject<TokenOption>("JWTokenControl");
            // ELİMİZDE BİR JWT TOKEN VAR İSE, AŞ. GİBİ BU TOKEN I DECODE EDİP HEADER , PAYLOAD VS BİLGİLERE ERİŞEBİLİRİZ
            //JwtSecurityToken jwtHandler = new JwtSecurityTokenHandler().ReadJwtToken(accessToken.Token);
            //jwtHandler.Claims.SingleOrDefault(x=>x.Type.Contains("role"))
            //----------------------------------------------------------------------------

            if (token == null)
                context.Result = new RedirectToActionResult("LogIn", "AdminHome", null);
            else if (_allowedRoles != null)
            {

                if (IsTokenValid(token.Token,tokenOption))
                {
                    List<string> roleList = _allowedRoles.Trim().Split(',').ToList();
                    bool isApproved = false;
                    foreach (var role in roleList)
                    {
                        if (token.Claims.Contains(role))
                        {
                            isApproved = true;
                            break;
                        }
                        if (!isApproved)
                            context.Result = new RedirectToActionResult("LogIn", "AdminHome", null);
                    }
                }else
                    context.Result = new RedirectToActionResult("LogIn", "AdminHome", null);

            }

        }

        public bool IsTokenValid(string token, TokenOption tokenOption)
        {
            var mySecret = Encoding.UTF8.GetBytes(tokenOption.SecurityKey);
            var mySecurityKey = new SymmetricSecurityKey(mySecret);
            var tokenHandler = new JwtSecurityTokenHandler();
            try
            {
                tokenHandler.ValidateToken(token,
                new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidIssuer = tokenOption.Issuer,
                    ValidAudience = tokenOption.Audience,
                    IssuerSigningKey = mySecurityKey,
                    ValidateLifetime = true,
                }, out SecurityToken validatedToken);
            }
            catch
            {
                return false;
            }
            return true;
        }

    }
}
