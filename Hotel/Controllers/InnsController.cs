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
using Hotel.Models.Services;

namespace Hotel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InnsController : ControllerBase
    {
        private readonly IInn _context;
        /*public InnsController(HotelDbContext context)
        {
            _context = context;
        }*/
        public InnsController(IInn c) {
            _context = c;
        }

        // GET: api/Inns
        [HttpGet]
        /*public async Task<ActionResult<IEnumerable<Inn>>> GetInns()
        {
            return await _context.Inns.ToListAsync();
        }*/
        public async Task<ActionResult<IEnumerable<Inn>>> GetInns()
        {
            // You should count the list ...
            var list = await _context.GetInns();
            return Ok(list);
        }

        // GET: api/Inns/5
        [HttpGet("{id}")]
        /* public async Task<ActionResult<Inn>> GetInn(int id)
         {
             var inn = await _context.Inns.FindAsync(id);

             if (inn == null)
             {
                 return NotFound();
             }

             return inn;
         }*/
        public async Task<ActionResult<Inn>> GetInn(int id)
        {
            Inn inn = await _context.GetInn(id);
            return inn;
        }


        // PUT: api/Inns/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        /*public async Task<IActionResult> PutInn(int id, Inn inn)
        {
            if (id != inn.Id)
            {
                return BadRequest();
            }

            _context.Entry(inn).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InnExists(id))
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

        public async Task<IActionResult> Create(int id, Inn inn)
        {
            if (id != inn.Id)
            {
                return BadRequest();
            }

            var updatedInn = await _context.UpdateInn(id, inn);

            return Ok(updatedInn);
        }

        // POST: api/Inns
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        /*public async Task<ActionResult<Inn>> PostInn(Inn inn)
        {
            _context.Inns.Add(inn);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInn", new { id = inn.Id }, inn);
        }*/
        public async Task<ActionResult<Inn>> UpdateInn(Inn inn)
        {
            await _context.Create(inn);

            // Return a 201 Header to browser
            // The body of the request will be us running GetTechnology(id);
            return CreatedAtAction("GetInn", new { id = inn.Id }, inn);
        }


        // DELETE: api/Inns/5
        [HttpDelete("{id}")]
        /*public async Task<IActionResult> DeleteInn(int id)
        {
            var inn = await _context.Inns.FindAsync(id);
            if (inn == null)
            {
                return NotFound();
            }

            _context.Inns.Remove(inn);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InnExists(int id)
        {
            return _context.Inns.Any(e => e.Id == id);
        }*/

        public async Task<IActionResult> Delete(int id)
        {
            await _context.Delete(id);
            return NoContent();
        }
    }
}
