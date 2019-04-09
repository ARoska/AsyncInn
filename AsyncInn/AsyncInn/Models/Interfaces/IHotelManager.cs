using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    public interface IHotelManager
    {
        // Create a Hotel
        Task CreateHotel(Hotel hotel);

        // Update a Hotel
        void UpdateHotel(int id);

        // Delete a Hotel
        bool DeleteHotel(int id);

        // Get a single Hotel's Details
        Hotel GetHotel(int id);

        // Get all Hotel's Details
        Task<List<Hotel>> GetHotels();
    }
}
