using Speridian.MagicVilla.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Speridian.MagicVilla.Helpers
{
    public interface IAuthorize
    {
        Token CreateTokens(string userName);
        string CreateAccessToken(string username);

        string CreateRefreshToken();

        ClaimsPrincipal GetClaimsPrincipal(string AccessToken);
    }
}
