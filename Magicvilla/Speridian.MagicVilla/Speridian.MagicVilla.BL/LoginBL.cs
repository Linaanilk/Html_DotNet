using Speridian.MagicVilla.Entities.DTO;
using Speridian.MagicVilla.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Speridian.MagicVilla.DAL;

namespace Speridian.MagicVilla.BL
{
    public class LoginBL
    {
        ILoginDAL _loginDAL;
        public LoginBL(ILoginDAL loginDAL)
        {
            _loginDAL = loginDAL;
        }
        public async Task PostRegisterAsync(UserDTO user)
        {
            
            User userDTO = new User()
            {
                Username = user.Username,
                Password = user.Password
              
            };
           
            await _loginDAL.PostRegisterAsync(userDTO);
           
        }
        public async Task<UserDTO> PostLoginAsync( UserDTO user)
        {

            User userDTO = new User()
            {
                Username = user.Username,
                Password = user.Password

            };

           User val= await _loginDAL.PostLoginAsync(userDTO);
            //return val;
            if (val != null)
            {
                UserDTO resultDTO = new UserDTO()
                {
                    // Map properties as needed
                    Id = val.Id,
                    Username = val.Username,
                    Password= val.Password
                    // other properties...
                };

                return resultDTO;
            }
            else
            {
                // Handle unsuccessful login (e.g., throw an exception or return null)
                return null;
            }

        }
        public async Task<bool> AddRefreshAsync(String UserName, Token token)
        {
            return await _loginDAL.AddRefreshAsync(UserName, token);
        }
    }
}
