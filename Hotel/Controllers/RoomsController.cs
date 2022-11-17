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
    public class RoomsController : ControllerBase
    {
        private readonly IRoom _context;

        /* public RoomsController(HotelDbContext context)
         {
             _context = context;
         }*/
        public RoomsController(IRoom c)
        {
            _context = c;
        }

        // GET: api/Rooms
        [HttpGet]
        /*public async Task<ActionResult<IEnumerable<Rooms>>> GetRoom()
        {
            return await _context.Room.ToListAsync();
        }*/
        public async Task<ActionResult<IEnumerable<Rooms>>> GetRooms()
        {
            // You should count the list ...
            var list = await _context.GetRooms();
            return Ok(list);
        }

        // GET: api/Rooms/5
        [HttpGet("{id}")]
        /*public async Task<ActionResult<Rooms>> GetRooms(int id)
        {
            var rooms = await _context.Room.FindAsync(id);

            if (rooms == null)
            {
                return NotFound();
            }

            return rooms;
        }*/
        public async Task<ActionResult<Rooms>> GetRoom(int id)
        {
            Rooms room = await _context.GetRoom(id);
            return room;
        }

        // PUT: api/Rooms/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        /*public async Task<IActionResult> PutRooms(int id, Rooms rooms)
        {
            if (id != rooms.ID)
            {
                return BadRequest();
            }

            _context.Entry(rooms).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoomsExists(id))
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

        public async Task<IActionResult> Create(int id, Rooms room)
        {
            if (id != room.ID)
            {
                return BadRequest();
            }

            var updatedRoom = await _context.UpdateRoom(id, room);

            return Ok(updatedRoom);
        }

        // POST: api/Rooms
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        /*public async Task<ActionResult<Rooms>> PostRooms(Rooms rooms)
        {
            _context.Room.Add(rooms);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRooms", new { id = rooms.ID }, rooms);
        }*/
        public async Task<ActionResult<Rooms>> UpdateRoom(Rooms room)
        {
            await _context.Create(room);

            // Return a 201 Header to browser
            // The body of the request will be us running GetTechnology(id);
            return CreatedAtAction("GetRoom", new { id = room.ID }, room);
        }

        // DELETE: api/Rooms/5
        [HttpDelete("{id}")]
        /* public async Task<IActionResult> DeleteRooms(int id)
         {
             var rooms = await _context.Room.FindAsync(id);
             if (rooms == null)
             {
                 return NotFound();
             }

             _context.Room.Remove(rooms);
             await _context.SaveChangesAsync();

             return NoContent();
         }

         private bool RoomsExists(int id)
         {
             return _context.Room.Any(e => e.ID == id);
         }*/
        public async Task<IActionResult> Delete(int id)
        {
            await _context.Delete(id);
            return NoContent();
        }
    }
}
