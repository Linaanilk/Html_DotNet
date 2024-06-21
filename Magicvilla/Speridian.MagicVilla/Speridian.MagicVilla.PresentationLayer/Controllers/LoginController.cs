using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Speridian.MagicVilla.BL;
using Speridian.MagicVilla.Entities;
using Speridian.MagicVilla.Entities.DTO;
using Speridian.MagicVilla.Helpers;

namespace Speridian.MagicVilla.PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        LoginBL _loginBL;
        IAuthorize _auth;

        public LoginController(LoginBL loginBL, IAuthorize auth)
        {
            _loginBL = loginBL;
            _auth = auth;
        }
        [HttpPost("Register")]
        public async Task PostRegisterAsync([FromBody] UserDTO user)
        {
            await _loginBL.PostRegisterAsync(user);
        }
        [HttpPost("login")]
        public async Task<IActionResult> PostLoginAsync([FromBody] UserDTO user)
        {
            //var rel=await _loginBL.PostLoginAsync(user);
            //return rel;

            var result = await _loginBL.PostLoginAsync(user);
            if (result != null)
            {
                // return Ok(result);
                var token = _auth.CreateTokens(user.Username);

                /// return Ok(token);
                bool status = await _loginBL.AddRefreshAsync(user.Username, token);
                if (status)
                {
                    return Ok(token);
                }
                else
                {
                    return BadRequest();
                }


            }
            else
            {
                return BadRequest();
            }



        }


        [HttpPost("Refresh")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Refresh([FromBody] Token token)
        {
            if (!ModelState.IsValid)
            {
                throw new BadHttpRequestException("Invalid Tokens");
            }
            else
            {
                var principal = _auth.GetClaimsPrincipal(token.AccessToken);
                string userName = principal.Identity?.Name;
                Token newToken = _auth.CreateTokens(userName);
                bool refreshTokenStatus = await _loginBL.AddRefreshAsync(userName, newToken);
                if (refreshTokenStatus)
                {
                    return Ok(newToken);
                }
                else
                {
                    throw new Exception("Not Authorized");
                }
            }

        }
    }
}
