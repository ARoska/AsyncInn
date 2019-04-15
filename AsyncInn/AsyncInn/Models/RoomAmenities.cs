using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class RoomAmenities
    {
        [Required]
        public int RoomID { get; set; }
        [Required]
        public int AmenitiesID { get; set; }

        // Navigation Properties
        public Room Rooms { get; set; }
        public Amenities Amenities { get; set; }
    }
}
