using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessService;
using DataStorage.Entityes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UserBookedApartments.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentsController : ControllerBase
    {
        private readonly DataManager dataManager;

        public ApartmentsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        // GET: api/Apartments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Apartments>>> GetApartments()
        {
            return await dataManager.Apartments.GetAllApartmentsAsync();
        }

        // GET: api/Apartments/5
        [HttpGet("{apsId}")]
        public async Task<ActionResult<Apartments>> GetApartment(int apsId)
        {
            var apartment = await dataManager.Apartments.GetApartmentAsync(apsId);
            if (apartment.Value == null)
            {
                NotFound();
            }
            return apartment;
        }

        // POST: api/Apartments
        [HttpPost]
        public async Task<ActionResult<Apartments>> PostAddApartment(Apartments aps)
        {
            await dataManager.Apartments.AddApartmentAsync(aps);
            return CreatedAtAction(nameof(GetApartment), aps);
        }

        // DELETE api/Apartments/5
        [HttpDelete("{apsId}")]
        public async Task<IActionResult> DeleteUser(int apsId)
        {
            await dataManager.Apartments.DeleleteApartmentAsync(apsId);
            return NoContent();
        }
    }
}