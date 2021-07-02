using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StrongAPI.Migrations
{
    public partial class gearDateUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0cfea69d-506e-4e78-b28e-d5c76d3bb320");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ca48dc7-e7e1-4391-841f-ffec64722df3");

            migrationBuilder.AlterColumn<string>(
                name: "DateListed",
                table: "Gear",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "167389c6-71ed-4d38-bd4c-68bb2e91a8e1", "20c59081-5fa2-4ca0-94bd-92535dc08464", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1cf0670f-626a-46a1-8abf-631c1dc1b65d", "9901a6a4-ae9f-42d1-adda-4a62be167bde", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "167389c6-71ed-4d38-bd4c-68bb2e91a8e1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1cf0670f-626a-46a1-8abf-631c1dc1b65d");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateListed",
                table: "Gear",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6ca48dc7-e7e1-4391-841f-ffec64722df3", "62d09ed2-1019-41ca-854a-a9c6e74aed9f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0cfea69d-506e-4e78-b28e-d5c76d3bb320", "9866c97a-0269-40a9-88a3-152a7c12d287", "Admin", "ADMIN" });
        }
    }
}
