using Hotel.Data;
using Hotel.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Models.Services
{
    public class InnService : IInn
    {
        private HotelDbContext _context;

        public InnService(HotelDbContext hotelDbContext)
        {
            _context = hotelDbContext;
        }

        public async Task<Inn> Create(Inn inn)
        {
            _context.Entry(inn).State = EntityState.Added;

            await _context.SaveChangesAsync();

            return inn;
        }

        public async Task<List<Inn>> GetInns()
        {
            var inns = await _context.Inns.ToListAsync();
            return inns;
        }

        public async Task<Inn> GetInn(int id)
        {
            Inn inn = await _context.Inns.FindAsync(id);
            return inn;
        }

        public async Task<Inn> UpdateInn(int id, Inn inn)
        {
            _context.Entry(inn).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return inn;
        }

        public async Task Delete(int id)
        {
            Inn inn = await GetInn(id);
            _context.Entry(inn).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }
    }
}
