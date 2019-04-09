using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Data
{
    public class AsyncInnDbContext : DbContext
    {
        public AsyncInnDbContext(DbContextOptions<AsyncInnDbContext> options) : base(options)
        {

        }

        // Composite Key Creator
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HotelRoom>().HasKey(ce => new { ce.HotelID, ce.RoomNumber });
            modelBuilder.Entity<RoomAmenities>().HasKey(ce => new { ce.RoomID, ce.AmenitiesID });

            // Seed DB
            modelBuilder.Entity<Hotel>().HasData(
            new Hotel
            {
                ID = 1,
                Name = "Best Western",
                StreetAddress = "123 Fake St.",
                City = "Seattle",
                State = "WA",
                PhoneNumber = "555-555-5555"
            },
            new Hotel
            {
                ID = 2,
                Name = "Hilton Inn",
                StreetAddress = "123 Fake St.",
                City = "Portland",
                State = "OR",
                PhoneNumber = "555-555-5555"
            },
            new Hotel
            {
                ID = 3,
                Name = "Red Lion",
                StreetAddress = "123 Fake St.",
                City = "Vancouver",
                State = "WA",
                PhoneNumber = "555-555-5555"
            },
            new Hotel
            {
                ID = 4,
                Name = "Motel 6",
                StreetAddress = "123 Fake St.",
                City = "Monroe",
                State = "WA",
                PhoneNumber = "555-555-5555"
            },
            new Hotel
            {
                ID = 5,
                Name = "Sheraton",
                StreetAddress = "123 Fake St.",
                City = "Los Angeles",
                State = "CA",
                PhoneNumber = "555-555-5555"
            }
            );
            modelBuilder.Entity<Room>().HasData(
            new Room
            {
                ID = 1,
                Name = "Disney Dorm",
                Layout = Layouts.Studio
            },
            new Room
            {
                ID = 2,
                Name = "Ocean Shores Bungalo",
                Layout = Layouts.Studio
            },
            new Room
            {
                ID = 3,
                Name = "Reinier View",
                Layout = Layouts.TwoBedroom
            },
            new Room
            {
                ID = 4,
                Name = "Scenic Skyloft",
                Layout = Layouts.TwoBedroom
            },
            new Room
            {
                ID = 5,
                Name = "Hawk Hights",
                Layout = Layouts.ThreeBedroom
            },
            new Room
            {
                ID = 6,
                Name = "Seahawk Snooze",
                Layout = Layouts.ThreeBedroom
            }
            );
            modelBuilder.Entity<Amenities>().HasData(
            new Amenities
            {
                ID = 1,
                Name = "A/C"
            },
            new Amenities
            {
                ID = 2,
                Name = "Mini Fridge"
            },
            new Amenities
            {
                ID = 3,
                Name = "Spa"
            },
            new Amenities
            {
                ID = 4,
                Name = "Hot Tub"
            },
            new Amenities
            {
                ID = 5,
                Name = "Flatscreen TV"
            },
            new Amenities
            {
                ID = 6,
                Name = "Balcony"
            }
            );
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<HotelRoom> HotelRooms { get; set; }
        public DbSet<Amenities> Amenities { get; set; }
        public DbSet<RoomAmenities> RoomAmenities { get; set; }
    }
}
