using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Speridian.MagicVilla.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace Speridian.MagicVilla.Helpers
{
    public class Authorize : IAuthorize
    {
        private readonly IConfiguration _config;

        public Authorize(IConfiguration config)
        {
            _config = config;
        }
        public string CreateAccessToken(string userName)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var securityKey = Encoding.UTF8.GetBytes(_config["Jwt:Key"]);

            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Issuer = "Issuer",
                Audience = "Audience",
                Expires = DateTime.Now.AddMinutes(1),
                Subject = new ClaimsIdentity(new Claim[]
                {

                    new Claim(ClaimTypes.Name, userName)
                }),

                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(securityKey), SecurityAlgorithms.HmacSha256),
                
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            //var refreshToken=Generate
             return tokenHandler.WriteToken(token);
           
        }

        public string CreateRefreshToken()
        {
            var randomNumber = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }

        public Token CreateTokens(string userName)
        {
            Token token = new Token()
            {
                AccessToken = CreateAccessToken(userName),
                RefreshToken = CreateRefreshToken(),
            };
            return token;

        }

        public ClaimsPrincipal GetClaimsPrincipal(string AccessToken)
        {
            var key = Encoding.UTF8.GetBytes(_config["JWT:Key"]);
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenValidationParameters = new TokenValidationParameters()
            {
                ValidateAudience = true,
                ValidateIssuer = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateLifetime = false,
                ClockSkew = TimeSpan.Zero,
                ValidAudience = "Audience",
                ValidIssuer = "Issuer",
                ValidateIssuerSigningKey = true
            };
            var principal = tokenHandler.ValidateToken(AccessToken, tokenValidationParameters, out SecurityToken claimPrincipalData);
            JwtSecurityToken jwtSecurityToken = claimPrincipalData as JwtSecurityToken;
            if (jwtSecurityToken == null || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
            {
                throw new Exception("Invalid Token");
            }
            else
            {
                return principal;
            }
        }
    }
}
