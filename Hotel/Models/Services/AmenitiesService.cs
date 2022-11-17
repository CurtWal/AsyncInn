using Hotel.Data;
using Microsoft.EntityFrameworkCore;
using Hotel.Models.Interfaces;
namespace Hotel.Models.Services
{
    public class AmenitiesService : IAmenities
    {
        private HotelDbContext _context;

        public AmenitiesService(HotelDbContext hotelDbContext)
        {
            _context = hotelDbContext;
        }

        public async Task<Amenities> Create(Amenities amenities)
        {
            _context.Entry(amenities).State = EntityState.Added;

            await _context.SaveChangesAsync();

            return amenities;
        }

        public async Task<List<Amenities>> GetAmenities()
        {
            var amenitie = await _context.amenities.ToListAsync();
            return amenitie;
        }

        public async Task<Amenities> GetAmenitie(int id)
        {
            Amenities amenities = await _context.amenities.FindAsync(id);
            return amenities;
        }

        public async Task<Amenities> UpdateAmenitie(int id, Amenities amenities)
        {
            _context.Entry(amenities).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return amenities;
        }

        public async Task Delete(int id)
        {
            Amenities amenities = await GetAmenitie(id);
            _context.Entry(amenities).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }
    }
}
