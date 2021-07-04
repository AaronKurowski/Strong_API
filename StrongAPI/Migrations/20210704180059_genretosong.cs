using Microsoft.EntityFrameworkCore.Migrations;

namespace StrongAPI.Migrations
{
    public partial class genretosong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "167389c6-71ed-4d38-bd4c-68bb2e91a8e1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1cf0670f-626a-46a1-8abf-631c1dc1b65d");

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Songs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f32dfc61-e2ed-4f77-af52-277462d607fd", "953eaa93-44dc-49f2-b7ef-e32c2a47b609", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1050f746-428b-4818-b807-4eeadf7dedb5", "8e3c6bd4-8231-449a-91eb-558749570a44", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1050f746-428b-4818-b807-4eeadf7dedb5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f32dfc61-e2ed-4f77-af52-277462d607fd");

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Songs");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "167389c6-71ed-4d38-bd4c-68bb2e91a8e1", "20c59081-5fa2-4ca0-94bd-92535dc08464", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1cf0670f-626a-46a1-8abf-631c1dc1b65d", "9901a6a4-ae9f-42d1-adda-4a62be167bde", "Admin", "ADMIN" });
        }
    }
}
