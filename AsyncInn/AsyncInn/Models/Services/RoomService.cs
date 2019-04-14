using AsyncInn.Data;
using AsyncInn.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Services
{
    public class RoomService : IRoomManager
    {
        private readonly AsyncInnDbContext _context;

        public RoomService(AsyncInnDbContext context)
        {
            _context = context;
        }

        public async Task<List<Room>> GetRooms()
        {
            return await _context.Rooms.ToListAsync();
        }

        public async Task<Room> GetRoom(int id)
        {
            var room = await _context.Rooms
                                     .Include(a => a.RoomAmenities)
                                     .ThenInclude(a => a.Amenities)
                                     .FirstOrDefaultAsync(x => x.ID == id);
            return room;
        }

        public async Task CreateRoom(Room room)
        {
            _context.Add(room);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateRoom(Room room)
        {
            _context.Update(room);
            await _context.SaveChangesAsync();
        }

        public async void DeleteRoom(Room room)
        {
            _context.Rooms.Remove(room);
            await _context.SaveChangesAsync();
        }

        public bool RoomExists(int id)
        {
            return _context.Rooms.Any(e => e.ID == id);
        }

    }
}
