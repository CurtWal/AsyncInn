﻿// <auto-generated />
using Hotel.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hotel.Migrations
{
    [DbContext(typeof(HotelDbContext))]
    [Migration("20221116175736_UpdatedHotelTables")]
    partial class UpdatedHotelTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Hotel.Models.Amenities", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("amenities");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Ocean View"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Mini Bar"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Free WiFi internet"
                        });
                });

            modelBuilder.Entity("Hotel.Models.HotelRooms", b =>
                {
                    b.Property<int>("HotelID")
                        .HasColumnType("int");

                    b.Property<bool>("PetFriendly")
                        .HasColumnType("bit");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RoomID")
                        .HasColumnType("int");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("int");

                    b.HasKey("HotelID");

                    b.HasIndex("RoomID");

                    b.ToTable("hotelRooms");
                });

            modelBuilder.Entity("Hotel.Models.Inn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Inns");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "1705 Baker Street",
                            City = "Memphis",
                            Country = "United States",
                            Name = "John Snow",
                            PhoneNumber = "1(901)-555-XxxX",
                            State = "Tennessee"
                        },
                        new
                        {
                            Id = 2,
                            Address = "1635 Sam Cooper Drive",
                            City = "Memphis",
                            Country = "United States",
                            Name = "Sara White",
                            PhoneNumber = "1(901)-264-XxxX",
                            State = "Tennessee"
                        },
                        new
                        {
                            Id = 3,
                            Address = "1265 Union Ave",
                            City = "Memphis",
                            Country = "United States",
                            Name = "Tom Fisher",
                            PhoneNumber = "1(901)-845-XxxX",
                            State = "Tennessee"
                        });
                });

            modelBuilder.Entity("Hotel.Models.RoomAmenites", b =>
                {
                    b.Property<int>("AmenitiesID")
                        .HasColumnType("int");

                    b.Property<int>("RoomID")
                        .HasColumnType("int");

                    b.HasKey("AmenitiesID");

                    b.HasIndex("RoomID")
                        .IsUnique();

                    b.ToTable("roomAmenites");
                });

            modelBuilder.Entity("Hotel.Models.Rooms", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Layout")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Room");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Layout = 0,
                            Name = "John Snow"
                        },
                        new
                        {
                            ID = 2,
                            Layout = 1,
                            Name = "Sara White"
                        },
                        new
                        {
                            ID = 3,
                            Layout = 2,
                            Name = "Tom Fisher"
                        });
                });

            modelBuilder.Entity("Hotel.Models.HotelRooms", b =>
                {
                    b.HasOne("Hotel.Models.Inn", "Hotel")
                        .WithOne("HotelRoom")
                        .HasForeignKey("Hotel.Models.HotelRooms", "HotelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hotel.Models.Rooms", "Room")
                        .WithMany()
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Hotel.Models.RoomAmenites", b =>
                {
                    b.HasOne("Hotel.Models.Amenities", null)
                        .WithOne("RoomAmenites")
                        .HasForeignKey("Hotel.Models.RoomAmenites", "AmenitiesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hotel.Models.Rooms", "Room")
                        .WithOne("Amenite")
                        .HasForeignKey("Hotel.Models.RoomAmenites", "RoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Hotel.Models.Amenities", b =>
                {
                    b.Navigation("RoomAmenites")
                        .IsRequired();
                });

            modelBuilder.Entity("Hotel.Models.Inn", b =>
                {
                    b.Navigation("HotelRoom")
                        .IsRequired();
                });

            modelBuilder.Entity("Hotel.Models.Rooms", b =>
                {
                    b.Navigation("Amenite")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
