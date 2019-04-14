using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    public interface IRoomManager
    {
        // Create a Room
        Task CreateRoom(Room room);

        // Update a Room
        Task UpdateRoom(Room room);

        // Delete a Room
        void DeleteRoom(Room room);

        // Get a single Room's Details
        Task<Room> GetRoom(int id);

        // Get all Room's
        Task<List<Room>> GetRooms();

        // Confirm Room Exists
        bool RoomExists(int id);
    }
}
