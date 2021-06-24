using Microsoft.EntityFrameworkCore.Migrations;

namespace StrongAPI.Migrations
{
    public partial class usergearupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3206dae7-32c7-450c-ac37-67507494427b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "beee3cc6-45c7-4589-b90b-ae0bb7e2d671");

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Gear",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Gear",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Band",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "35bad529-d3a6-42f5-8d82-778b0bd7a7f1", "e31d6eb9-2154-48fc-9bba-c33564097790", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "933456f8-3495-426e-8af9-83af73fe20a6", "befec0c8-8cb2-40d0-a32e-e349148bb8eb", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "35bad529-d3a6-42f5-8d82-778b0bd7a7f1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "933456f8-3495-426e-8af9-83af73fe20a6");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Gear");

            migrationBuilder.DropColumn(
                name: "Band",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Price",
                table: "Gear",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "beee3cc6-45c7-4589-b90b-ae0bb7e2d671", "8ff28732-dfbd-465b-b08b-f1c3e414f587", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3206dae7-32c7-450c-ac37-67507494427b", "be7e0de4-642d-4cab-bbed-63d92cef8d2c", "Admin", "ADMIN" });
        }
    }
}
