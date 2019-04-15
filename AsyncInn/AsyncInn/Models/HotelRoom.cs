using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class HotelRoom
    {
        [Required]
        public int HotelID { get; set; }
        [Required(ErrorMessage = "Room Number is required")]
        [Display(Name = "Room Number")]
        public int RoomNumber { get; set; }
        [Required]
        public int RoomID { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal Rate { get; set; }
        [Display(Name = "Pet Friendly?")]
        public bool PetFriendly { get; set; }

        // Navigation Properties
        public Hotel Hotels { get; set; }
        public Room Rooms { get; set; }
    }
}
