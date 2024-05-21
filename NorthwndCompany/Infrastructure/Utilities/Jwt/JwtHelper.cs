using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace NorthwndCompany.Infrastructure.Utilities.Jwt
{
    public class JwtHelper 
    {
        private readonly TokenOption _tokenOptions;
        private DateTime _accessTokenExpiration;
        public IConfiguration Configuration { get; }

        public JwtHelper(IConfiguration configuration)
        {
            Configuration = configuration;
            _tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOption>();
        }

        public AccessToken CreateToken(int id,string fullName,List<string> roles)
        {
            _accessTokenExpiration = DateTime.Now.AddHours(_tokenOptions.AccessTokenExpiration);
            
            var securityKey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey);
            var signingCredentials = SigningCredentialsHelper.CreateSigningCredentials(securityKey);
            var jwt = CreateJwtSecurityToken(_tokenOptions, signingCredentials, id, fullName, roles);
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var token = jwtSecurityTokenHandler.WriteToken(jwt);

            return new AccessToken()
            {
                Token = token,
                Expiration = _accessTokenExpiration
            };
        }

        private JwtSecurityToken CreateJwtSecurityToken(TokenOption tokenOptions, SigningCredentials signingCredentials, int id, string fullName, List<string> roles)
        {
            var jwt = new JwtSecurityToken(
                tokenOptions.Issuer,
                tokenOptions.Audience,
                expires: _accessTokenExpiration,
                notBefore: DateTime.Now,
                claims: SetClaims(id, fullName, roles),
                signingCredentials: signingCredentials);
            return jwt;
        }

        private IEnumerable<Claim> SetClaims(int id, string fullName, List<string> roles)
        {
            List<Claim> claims = new List<Claim>();

            claims.Add(new Claim(ClaimTypes.NameIdentifier, id.ToString())); // kullanıcı id si tutan claim
            claims.Add(new Claim(ClaimTypes.Name, fullName)); // kullanıcı fullname si tutan claim

            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role)); // kullanıncın rollerini tutan claim
            }

            return claims;
        }


    }
}
