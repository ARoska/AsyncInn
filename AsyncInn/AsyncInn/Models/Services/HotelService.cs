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
        private AsyncInnDbContext _context;

        public HotelService(AsyncInnDbContext context)
        {
            _context = context;
        }

        public async Task CreateHotel(Hotel hotel)
        {
            _context.Add(hotel);
            await _context.SaveChangesAsync();
        }

        public bool DeleteHotel(int id)
        {
            throw new NotImplementedException();
        }

        public Hotel GetHotel(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Hotel>> GetHotels()
        {
            return await _context.Hotels.ToListAsync();
        }

        public void UpdateHotel(int id)
        {
            throw new NotImplementedException();
        }
    }
}
