using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Data
{
    public class RoomAmenities
    {
        public int RoomID { get; set; }
        public int AmenitiesID { get; set; }

        // Navigation Properties
        public ICollection<Room> Rooms { get; set; }
        public ICollection<Amenities> Amenities { get; set; }
    }
}
