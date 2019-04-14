using AsyncInn.Data;
using AsyncInn.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Services
{
    public class AmenitiesService : IAmenitiesManager
    {
        private readonly AsyncInnDbContext _context;

        public AmenitiesService(AsyncInnDbContext context)
        {
            _context = context;
        }

        public async Task<List<Amenities>> GetAmenities()
        {
            return await _context.Amenities.ToListAsync();
        }

        public async Task<Amenities> GetAmenity(int id)
        {
            return await _context.Amenities.FindAsync(id);
        }

        public async Task CreateAmenity(Amenities amenity)
        {
            await _context.AddAsync(amenity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAmenity(Amenities amenity)
        {
            _context.Update(amenity);
            await _context.SaveChangesAsync();
        }

        public async void DeleteAmenity(Amenities amenity)
        {
            _context.Amenities.Remove(amenity);
            await _context.SaveChangesAsync();
        }

        public bool AmenityExists(int id)
        {
            return _context.Amenities.Any(x => x.ID == id);
        }
    }
}
