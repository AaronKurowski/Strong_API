using Microsoft.EntityFrameworkCore.Migrations;

namespace StrongAPI.Migrations
{
    public partial class gearUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb3abc8b-8316-4031-9f04-5da3535d426a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebfe5975-4e20-482e-87d2-a130e8ebef07");

            migrationBuilder.AddColumn<string>(
                name: "Contact",
                table: "Gear",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Gear",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6ca48dc7-e7e1-4391-841f-ffec64722df3", "62d09ed2-1019-41ca-854a-a9c6e74aed9f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0cfea69d-506e-4e78-b28e-d5c76d3bb320", "9866c97a-0269-40a9-88a3-152a7c12d287", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0cfea69d-506e-4e78-b28e-d5c76d3bb320");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ca48dc7-e7e1-4391-841f-ffec64722df3");

            migrationBuilder.DropColumn(
                name: "Contact",
                table: "Gear");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Gear");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ebfe5975-4e20-482e-87d2-a130e8ebef07", "90ff70df-4f27-4261-be98-adc6e96d49a5", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cb3abc8b-8316-4031-9f04-5da3535d426a", "62058e85-e78a-4c9b-bea3-3ee44c349c54", "Admin", "ADMIN" });
        }
    }
}
