using Microsoft.EntityFrameworkCore;
using Speridian.MagicVilla.Entities;
using Speridian.MagicVilla.Entities.DTO;
using Speridian.MagicVilla.PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speridian.MagicVilla.DAL
{
    public class VillaDAL : IVillaDAL
    {
        MagicVillaContext _db;

        public VillaDAL (MagicVillaContext db)
        {
            _db = db;
        }

        public async Task< List<Villa>> GetVillaAsync()
        {
            return await _db.Villas.FromSqlRaw($"EXEC USP_GetVillas {0}").ToListAsync();
        }

        public async Task<Villa> GetVillaAsync(int id)
        {
            var villas = await _db.Villas.FromSqlRaw($"EXEC USP_GetVillas {id}").ToListAsync();
            return villas.AsEnumerable().FirstOrDefault();
        }

        public async Task PostVillaAsync(Villa villa)
        {
            await _db.Database.ExecuteSqlInterpolatedAsync($"exec USP_Villas_InsertUpdate {villa.Id}, {villa.Name}, {villa.Details}, {villa.Rate},{villa.Sqft},{villa.Occupancy},{villa.Amenity},{villa.ImageUrl}");
            
            //Villa addedOrUpdatedVilla = await GetVillaAsync(villa.Id);

            //return addedOrUpdatedVilla;
        }

        public async Task PutVillaAsync(Villa villa)
        {
            //var val = _db.Villas.FirstOrDefault(x => x.Id == villa.Id);
            //if (val != null)
            //{
                await _db.Database.ExecuteSqlInterpolatedAsync($"exec USP_Villas_InsertUpdate {villa.Id}, {villa.Name}, {villa.Details}, {villa.Rate},{villa.Sqft},{villa.Occupancy},{villa.Amenity},{villa.ImageUrl}");
            //}
        }
        public async Task DeleteVillaAsync(int id)
        {
            await _db.Database.ExecuteSqlInterpolatedAsync($"EXEC USP_Villas_DeleteVillas {id}");
        }
    }
}
