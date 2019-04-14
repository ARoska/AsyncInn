using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class Room
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Layouts Layout { get; set; }

        // Navigation Properties
        public ICollection<HotelRoom> HotelRooms { get; set; }
        public ICollection<RoomAmenities> RoomAmenities { get; set; }
    }

    public enum Layouts
    {
        Studio,
        TwoBedroom,
        ThreeBedroom
    }
}
