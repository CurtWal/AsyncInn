using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hotel.Data;
using Hotel.Models;
using Hotel.Models.Interfaces;

namespace Hotel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmenitiesController : ControllerBase
    {
        private readonly IAmenities _context;

        public AmenitiesController(IAmenities c)
        {
            _context = c;
        }

        // GET: api/Amenities
        [HttpGet]
        /*public async Task<ActionResult<IEnumerable<Amenities>>> Getamenities()
        {
            return await _context.amenities.ToListAsync();
        }*/
        public async Task<ActionResult<IEnumerable<Amenities>>> GetAmenities()
        {
            // You should count the list ...
            var list = await _context.GetAmenities();
            return Ok(list);
        }

        // GET: api/Amenities/5
        [HttpGet("{id}")]
        /*public async Task<ActionResult<Amenities>> GetAmenities(int id)
        {

            var amenities = await _context.amenities.FindAsync(id);

            if (amenities == null)
            {
                return NotFound();
            }

            return amenities;
        }*/
        public async Task<ActionResult<Amenities>> GetAmenitie(int id)
        {
            Amenities amenities = await _context.GetAmenitie(id);
            return amenities;
        }

        // PUT: api/Amenities/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        /*public async Task<IActionResult> PutAmenities(int id, Amenities amenities)
        {
            if (id != amenities.ID)
            {
                return BadRequest();
            }

            _context.Entry(amenities).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AmenitiesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }*/
        public async Task<IActionResult> Create(int id, Amenities amenities)
        {
            if (id != amenities.ID)
            {
                return BadRequest();
            }

            var updatedAmenitie = await _context.UpdateAmenitie(id, amenities);

            return Ok(updatedAmenitie);
        }

        // POST: api/Amenities
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        /*public async Task<ActionResult<Amenities>> PostAmenities(Amenities amenities)
        {
            _context.amenities.Add(amenities);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAmenities", new { id = amenities.ID }, amenities);
        }*/
        public async Task<ActionResult<Amenities>> UpdateAmenitie(Amenities amenities)
        {
            await _context.Create(amenities);

            // Return a 201 Header to browser
            // The body of the request will be us running GetTechnology(id);
            return CreatedAtAction("GetAmenitie", new { id = amenities.ID }, amenities);
        }

        // DELETE: api/Amenities/5
        [HttpDelete("{id}")]
        /*public async Task<IActionResult> DeleteAmenities(int id)
        {
            var amenities = await _context.amenities.FindAsync(id);
            if (amenities == null)
            {
                return NotFound();
            }

            _context.amenities.Remove(amenities);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AmenitiesExists(int id)
        {
            return _context.amenities.Any(e => e.ID == id);
        }*/
        public async Task<IActionResult> Delete(int id)
        {
            await _context.Delete(id);
            return NoContent();
        }
    }
}
