using Microsoft.EntityFrameworkCore;
using System;
using Hotel.Models;
using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel.Data
{
    public class HotelDbContext : DbContext
    {
        public DbSet<Inn> Inns { get; set; }
        public DbSet<Rooms> Room { get; set; }
        public DbSet<RoomAmenites> roomAmenites { get; set; }
        public DbSet<HotelRooms> hotelRooms { get; set; }
        public DbSet<Amenities> amenities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inn>().HasData(new Inn { Id = 1, Name = "John Snow", Address = "1705 Baker Street", City = "Memphis", Country = "United States", PhoneNumber = "1(901)-555-XxxX", State = "Tennessee" });
            modelBuilder.Entity<Inn>().HasData(new Inn { Id = 2, Name = "Sara White", Address = "1635 Sam Cooper Drive", City = "Memphis", Country = "United States", PhoneNumber = "1(901)-264-XxxX", State = "Tennessee" });
            modelBuilder.Entity<Inn>().HasData(new Inn { Id = 3, Name = "Tom Fisher", Address = "1265 Union Ave", City = "Memphis", Country = "United States", PhoneNumber = "1(901)-845-XxxX", State = "Tennessee" });

            modelBuilder.Entity<Rooms>().HasData(new Rooms { ID = 1, Name = "John Snow", Layout = 0});
            modelBuilder.Entity<Rooms>().HasData(new Rooms { ID = 2, Name = "Sara White", Layout = 1 });
            modelBuilder.Entity<Rooms>().HasData(new Rooms { ID = 3, Name = "Tom Fisher", Layout = 2 });

            modelBuilder.Entity<Amenities>().HasData(new Amenities { ID = 1, Name = "Ocean View" });
            modelBuilder.Entity<Amenities>().HasData(new Amenities { ID = 2, Name = "Mini Bar" });
            modelBuilder.Entity<Amenities>().HasData(new Amenities { ID = 3, Name = "Free WiFi internet" });
        }
        public HotelDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
