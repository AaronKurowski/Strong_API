using Microsoft.EntityFrameworkCore.Migrations;

namespace StrongAPI.Migrations
{
    public partial class gearbuyer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1050f746-428b-4818-b807-4eeadf7dedb5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f32dfc61-e2ed-4f77-af52-277462d607fd");

            migrationBuilder.AddColumn<string>(
                name: "BuyerId",
                table: "Gear",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8c28d685-78b1-45af-b430-53c09a0dec8f", "bad40afd-e6c1-4b1c-b9e0-6214e902c290", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4bf952db-b9ad-4b75-8724-da958c6aa2eb", "86765a90-46f1-4e3b-a0d8-2f97620b9f46", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4bf952db-b9ad-4b75-8724-da958c6aa2eb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c28d685-78b1-45af-b430-53c09a0dec8f");

            migrationBuilder.DropColumn(
                name: "BuyerId",
                table: "Gear");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f32dfc61-e2ed-4f77-af52-277462d607fd", "953eaa93-44dc-49f2-b7ef-e32c2a47b609", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1050f746-428b-4818-b807-4eeadf7dedb5", "8e3c6bd4-8231-449a-91eb-558749570a44", "Admin", "ADMIN" });
        }
    }
}
