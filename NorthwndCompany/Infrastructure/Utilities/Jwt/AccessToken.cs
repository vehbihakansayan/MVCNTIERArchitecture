using System;
using System.Collections.Generic;

namespace NorthwndCompany.Infrastructure.Utilities.Jwt
{
    public class AccessToken
    {
        public List<string> Claims { get; set; }
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
        
    }
}
