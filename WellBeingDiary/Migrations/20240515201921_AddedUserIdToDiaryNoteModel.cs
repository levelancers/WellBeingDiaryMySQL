using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WellBeingDiary.Migrations
{
    /// <inheritdoc />
    public partial class AddedUserIdToDiaryNoteModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "735184c3-9fa5-45ed-b15c-f67d40029c4e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7824855-0a62-40e6-9118-89f77afb3a2b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2148c315-3ff7-4b9c-89c4-1a8996f47ec2", null, "Admin", "ADMIN" },
                    { "62e65692-1755-4886-b631-b2358232edbc", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2148c315-3ff7-4b9c-89c4-1a8996f47ec2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62e65692-1755-4886-b631-b2358232edbc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "735184c3-9fa5-45ed-b15c-f67d40029c4e", null, "Admin", "ADMIN" },
                    { "b7824855-0a62-40e6-9118-89f77afb3a2b", null, "User", "USER" }
                });
        }
    }
}
