using Speridian.MagicVilla.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speridian.MagicVilla.DAL
{
    public interface ILoginDAL
    {
        Task PostRegisterAsync(User user);
        Task<User> PostLoginAsync(User user);

        Task<bool> AddRefreshAsync(String Username, Token token);

    }
}
