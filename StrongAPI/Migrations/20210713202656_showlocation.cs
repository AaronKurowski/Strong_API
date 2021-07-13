using Microsoft.EntityFrameworkCore.Migrations;

namespace StrongAPI.Migrations
{
    public partial class showlocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80ff0223-edbf-4d24-b7f4-6bd15b7f74ea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad08c641-4dad-420b-b1cd-0475f89a6d96");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "ShowListings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2dedc358-8e83-4be6-8c2e-617f36088553", "4f59d371-ec37-4448-acc8-28f3330fc05c", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f03554f4-6c56-47d7-b632-5477fa167949", "3f8796d0-e79a-4190-bb41-520c585aad9b", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2dedc358-8e83-4be6-8c2e-617f36088553");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f03554f4-6c56-47d7-b632-5477fa167949");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "ShowListings");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ad08c641-4dad-420b-b1cd-0475f89a6d96", "5a8b6a2c-caef-4add-8a9c-814dc8d4a1b0", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "80ff0223-edbf-4d24-b7f4-6bd15b7f74ea", "627dd9e8-c1ba-4a69-bd51-dc0aed0406df", "Admin", "ADMIN" });
        }
    }
}
