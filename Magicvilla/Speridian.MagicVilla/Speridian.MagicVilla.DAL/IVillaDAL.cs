using Speridian.MagicVilla.Entities;
using Speridian.MagicVilla.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speridian.MagicVilla.DAL
{
    public interface IVillaDAL
    {
        Task<List<Villa>> GetVillaAsync();
        Task<Villa> GetVillaAsync(int id);

        Task PostVillaAsync(Villa villa);

        Task PutVillaAsync(Villa villa);

        Task DeleteVillaAsync(int id);
    }
}
