using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    public interface IHotelManager
    {
        // Get a single Hotel's Details
        Task<Hotel> GetHotel(int id);

        // Get all Hotel's Details
        Task<List<Hotel>> GetHotels(string searchString);

        // Create a Hotel
        Task CreateHotel(Hotel hotel);

        // Update a Hotel
        Task UpdateHotel(Hotel hotel);

        // Delete a Hotel
        void DeleteHotel(Hotel hotel);

        // Confirm Hotel Exists
        bool HotelExists(int id);


    }
}
