using Speridian.MagicVilla.DAL;
using Speridian.MagicVilla.Entities;
using Speridian.MagicVilla.Entities.DTO;

namespace Speridian.MagicVilla.BL
{
    public class VillaBL
    {
        IVillaDAL _villaDal;
        public VillaBL(IVillaDAL villadal)
        {
            _villaDal=villadal;
        }
        public async Task<List<VillaDTO>> GetVillaAsync()
        {
            List<VillaDTO> villaDTOs = new List<VillaDTO>();
            
            var villa = await _villaDal.GetVillaAsync();

            foreach(var villaDTO in villa)
            {
                VillaDTO villaDTO2 =new VillaDTO()
                {
                    Id = villaDTO.Id,
                    Amenity = villaDTO.Amenity,
                    Details = villaDTO.Details,
                    ImageUrl = villaDTO.ImageUrl,
                    Name = villaDTO.Name,
                    Occupancy = villaDTO.Occupancy,
                    Rate = villaDTO.Rate,
                    Sqft = villaDTO.Sqft
            };
            villaDTOs.Add(villaDTO2);
                
            }
            return villaDTOs;
        }
        public async Task<VillaDTO> GetVillaAsync(int id)
        {
            var villa = await _villaDal.GetVillaAsync(id);

            if (villa == null)
            {
                return null; // or some appropriate response indicating that the Villa with the given ID was not found
            }

            VillaDTO villaDTO = new VillaDTO()
            {
                Amenity = villa.Amenity,
                Details = villa.Details,
                Id = villa.Id,
                ImageUrl = villa.ImageUrl,
                Name = villa.Name,
                Occupancy = villa.Occupancy,
                Rate = villa.Rate,
                Sqft = villa.Sqft,
            };

            return villaDTO;
        }

        public async Task PostVillaAsync(VillaDTO villa)
        {
           // await _villaDal.PostVillaAsync(villa);
            Villa villaDTO = new Villa()
            {
                Amenity = villa.Amenity,
                Details = villa.Details,
                Id = villa.Id,
                ImageUrl = villa.ImageUrl,
                Name = villa.Name,
                Occupancy = villa.Occupancy,
                Rate = villa.Rate,
                Sqft = villa.Sqft,
            };
           // await _villaDal.Add(VillaDTO);
            await _villaDal.PostVillaAsync(villaDTO);
            // return villaDTO;
        }
        public async Task PutVillaAsync(int id, VillaDTO villa)
        {
            Villa villaDTO = new Villa()
            {
                Amenity = villa.Amenity,
                Details = villa.Details,
                Id = id,
                ImageUrl = villa.ImageUrl,
                Name = villa.Name,
                Occupancy = villa.Occupancy,
                Rate = villa.Rate,
                Sqft = villa.Sqft,
            };
            await _villaDal.PutVillaAsync(villaDTO);
        }
        public async Task DeleteVillaAsync(int id)
        {
            await _villaDal.DeleteVillaAsync(id);
        }

    }
}
