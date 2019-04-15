using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    public interface IAmenitiesManager
    {
        // Get a single Amenity's Details
        Task<Amenities> GetAmenity(int id);

        // Get all Amenities Details
        Task<List<Amenities>> GetAmenities(string searchString);

        // Create a Amenity
        Task CreateAmenity(Amenities amenity);

        // Update a Amenity
        Task UpdateAmenity(Amenities amenity);

        // Delete a Amenity
        void DeleteAmenity(Amenities amenity);

        // Confirm Amenity Exists
        bool AmenityExists(int id);
    }
}
