using AsyncInn.Data;
using AsyncInn.Models.Interfaces;
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

        public Task CreateAmenity(Amenities amenity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteAmenity(Amenities amenity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Amenities>> GetAmenities()
        {
            throw new NotImplementedException();
        }

        public Task<Amenities> GetAmenity(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAmenity(Amenities amenity)
        {
            throw new NotImplementedException();
        }

        public bool AmenityExists(int id)
        {
            return _context.Amenities.Any(e => e.ID == id);
        }
    }
}
