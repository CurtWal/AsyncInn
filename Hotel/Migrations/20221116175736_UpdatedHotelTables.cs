using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedHotelTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_roomAmenites",
                table: "roomAmenites");

            migrationBuilder.DropIndex(
                name: "IX_roomAmenites_AmenitiesID",
                table: "roomAmenites");

            migrationBuilder.DropPrimaryKey(
                name: "PK_hotelRooms",
                table: "hotelRooms");

            migrationBuilder.DropIndex(
                name: "IX_hotelRooms_HotelID",
                table: "hotelRooms");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "roomAmenites");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "hotelRooms");

            migrationBuilder.AddPrimaryKey(
                name: "PK_roomAmenites",
                table: "roomAmenites",
                column: "AmenitiesID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_hotelRooms",
                table: "hotelRooms",
                column: "HotelID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_roomAmenites",
                table: "roomAmenites");

            migrationBuilder.DropPrimaryKey(
                name: "PK_hotelRooms",
                table: "hotelRooms");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "roomAmenites",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "hotelRooms",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_roomAmenites",
                table: "roomAmenites",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_hotelRooms",
                table: "hotelRooms",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_roomAmenites_AmenitiesID",
                table: "roomAmenites",
                column: "AmenitiesID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_hotelRooms_HotelID",
                table: "hotelRooms",
                column: "HotelID",
                unique: true);
        }
    }
}
