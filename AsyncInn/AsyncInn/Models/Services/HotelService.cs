using AsyncInn.Data;
using AsyncInn.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Services
{
    public class HotelService : IHotelManager
    {
        private readonly AsyncInnDbContext _context;

        public HotelService(AsyncInnDbContext context)
        {
            _context = context;
        }

        public async Task<List<Hotel>> GetHotels()
        {
            return await _context.Hotels.ToListAsync();
        }

        public async Task<Hotel> GetHotel(int id)
        {
            return await _context.Hotels
                                 .Include(r => r.HotelRooms)
                                 .ThenInclude(r => r.Rooms)
                                 .FirstOrDefaultAsync(x => x.ID == id);
        }

        public async Task CreateHotel(Hotel hotel)
        {
            await _context.AddAsync(hotel);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateHotel(Hotel hotel)
        {
            _context.Update(hotel);
            await _context.SaveChangesAsync();
        }

        public async void DeleteHotel(Hotel hotel)
        {
            _context.Hotels.Remove(hotel);
            await _context.SaveChangesAsync();
        }

        public bool HotelExists(int id)
        {
            return _context.Hotels.Any(e => e.ID == id);
        }
    }
}
