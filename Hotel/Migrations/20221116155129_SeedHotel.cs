using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Migrations
{
    /// <inheritdoc />
    public partial class SeedHotel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Inns",
                columns: new[] { "Id", "Address", "City", "Country", "Name", "PhoneNumber", "State" },
                values: new object[] { 1, "1705 Baker Street", "Memphis", "United States", "John Snow", "1(901)-555-XxxX", "Tennessee" });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "Layout", "Name" },
                values: new object[] { 1, 0, "John Snow" });

            migrationBuilder.InsertData(
                table: "amenities",
                columns: new[] { "ID", "Name" },
                values: new object[] { 1, "Ocean View" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Inns",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "amenities",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
