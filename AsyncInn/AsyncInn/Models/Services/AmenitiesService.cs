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
            var amenity = await _context.Amenities.FindAsync(id);
            if (amenity == null)
            {
                return null;
            }

            return amenity;
        }

        public async Task CreateAmenity(Amenities amenity)
        {
            _context.Add(amenity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAmenity(Amenities amenity)
        {
            _context.Update(amenity);
            await _context.SaveChangesAsync();
        }

        public bool DeleteAmenity(Amenities amenity)
        {
            if (amenity != null)
            {
                _context.Amenities.Remove(amenity);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool AmenityExists(int id)
        {
            return _context.Amenities.Any(e => e.ID == id);
        }
    }
}
