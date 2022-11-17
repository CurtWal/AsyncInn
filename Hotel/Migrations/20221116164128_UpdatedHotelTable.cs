using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hotel.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedHotelTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Inns",
                columns: new[] { "Id", "Address", "City", "Country", "Name", "PhoneNumber", "State" },
                values: new object[,]
                {
                    { 2, "1635 Sam Cooper Drive", "Memphis", "United States", "Sara White", "1(901)-264-XxxX", "Tennessee" },
                    { 3, "1265 Union Ave", "Memphis", "United States", "Tom Fisher", "1(901)-845-XxxX", "Tennessee" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "Layout", "Name" },
                values: new object[,]
                {
                    { 2, 1, "Sara White" },
                    { 3, 2, "Tom Fisher" }
                });

            migrationBuilder.InsertData(
                table: "amenities",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 2, "Mini Bar" },
                    { 3, "Free WiFi internet" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Inns",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Inns",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "amenities",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "amenities",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
