using Hotel.Data;
using Hotel.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Hotel.Models.Services
{
    public class RoomService : IRoom
    {
        private HotelDbContext _context;

        public RoomService(HotelDbContext hotelDbContext)
        {
            _context = hotelDbContext;
        }

        public async Task<Rooms> Create(Rooms room)
        {
            _context.Entry(room).State = EntityState.Added;

            await _context.SaveChangesAsync();

            return room;
        }

        public async Task<List<Rooms>> GetRooms()
        {
            var room = await _context.Room.ToListAsync();
            return room;
        }

        public async Task<Rooms> GetRoom(int id)
        {
            Rooms room = await _context.Room.FindAsync(id);
            return room;
        }

        public async Task<Rooms> UpdateRoom(int id, Rooms room)
        {
            _context.Entry(room).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return room;
        }

        public async Task Delete(int id)
        {
            Rooms room = await GetRoom(id);
            _context.Entry(room).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }
    }
}
