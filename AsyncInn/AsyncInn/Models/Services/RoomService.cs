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

        public async Task<List<Room>> GetRooms(string searchString)
        {
            var rooms = from r in _context.Rooms
                        select r;

            if (!String.IsNullOrEmpty(searchString))
            {
                rooms = rooms.Where(s => s.Name.Contains(searchString));
            }

            return await rooms.ToListAsync();
        }

        public async Task<Room> GetRoom(int id)
        {
            return await _context.Rooms
                                 .Include(a => a.RoomAmenities)
                                 .ThenInclude(a => a.Amenities)
                                 .FirstOrDefaultAsync(x => x.ID == id);
        }

        public async Task CreateRoom(Room room)
        {
            await _context.AddAsync(room);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateRoom(Room room)
        {
            _context.Update(room);
            await _context.SaveChangesAsync();
        }

        public void DeleteRoom(Room room)
        {
            _context.Rooms.Remove(room);
            _context.SaveChangesAsync();
        }

        public bool RoomExists(int id)
        {
            return _context.Rooms.Any(x => x.ID == id);
        }

    }
}
