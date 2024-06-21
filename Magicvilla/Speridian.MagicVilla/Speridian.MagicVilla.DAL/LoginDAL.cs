using Microsoft.EntityFrameworkCore;
using Speridian.MagicVilla.Entities;
using Speridian.MagicVilla.PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speridian.MagicVilla.DAL
{
    public class LoginDAL : ILoginDAL
    {
        MagicVillaContext _db;

        public LoginDAL(MagicVillaContext db)
        {
            _db = db;
        }

        public async Task PostRegisterAsync(User user)
        {
            await _db.Database.ExecuteSqlInterpolatedAsync($"exec USP_Villas_InsertLogin {user.Username},{user.Password}");
        }

        public async Task<User> PostLoginAsync(User user)
        {
            // Check the username and password
            User authenticatedUser = await _db.Users.FirstOrDefaultAsync(x => x.Username == user.Username && x.Password == user.Password);

            // If the user is not found or the password is incorrect, return null
            //if (authenticatedUser == null)
            //{
            //    return null;
            //}

            // If the user is found and the password is correct, return the authenticated user
            return authenticatedUser;
        }

        public async Task<bool> AddRefreshAsync(String UserName,Token token)
        {
           List<UserRefreshToken> refreshTokens = await _db.UserRefreshTokens.FromSqlRaw($"EXEC USP_Villas_SelectRefresh {UserName}").ToListAsync();
            if (refreshTokens.Count > 0 && refreshTokens[0].UserName == UserName)
            {

                int row = await _db.Database.ExecuteSqlInterpolatedAsync($"EXEC USP_Villas_RefreshInsertUpdate {UserName},{token.RefreshToken},{0}");
                if (row > 0) 
                {
                    return true;
                }
                else 
                { 
                    return false;
                }
             }
            else
            {
               int row= await _db.Database.ExecuteSqlInterpolatedAsync($"EXEC USP_Villas_RefreshInsertUpdate {UserName},{token.RefreshToken},{1}");
                if (row > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
    }
}
