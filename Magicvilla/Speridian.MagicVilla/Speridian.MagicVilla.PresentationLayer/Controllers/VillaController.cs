using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Speridian.MagicVilla.BL;
using Speridian.MagicVilla.Entities;
using Speridian.MagicVilla.Entities.DTO;

namespace Speridian.MagicVilla.PresentationLayer.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class VillaController : ControllerBase
    {
        VillaBL _villaBL;

        public VillaController(VillaBL villaBL)
        {
            _villaBL = villaBL;
        }
        [HttpGet("GetAllVilla")]
        public async Task<IActionResult> GetVillaAsync()
        {
            return Ok(await _villaBL.GetVillaAsync());
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetVillaAsync(int id)
        {
            return Ok(await _villaBL.GetVillaAsync(id));
        }
        [HttpPost]
        public async Task PostVillaAsync([FromBody] VillaDTO villa)
        {



            // Call your BL method to add a new Villa
            await _villaBL.PostVillaAsync(villa);



        }
        [HttpPut("{id:int}")]
        public async Task PutVillaAsync(int id, [FromBody] VillaDTO villa)
        {
            if (id == villa.Id)
            {
                await _villaBL.PutVillaAsync(id, villa);
            }
        }

        [HttpDelete("{id:int}")]
        public async Task DeleteVillaAsync(int id)
        {
            await _villaBL.DeleteVillaAsync(id);
        }

    }
}
