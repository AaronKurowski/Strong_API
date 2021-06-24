using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StrongAPI.Migrations
{
    public partial class gear : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5fbee022-6434-498d-949b-2e36bc00f746");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6cd44fb-d986-416b-879f-8c818016d717");

            migrationBuilder.CreateTable(
                name: "Gear",
                columns: table => new
                {
                    GearId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Condition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateListed = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gear", x => x.GearId);
                    table.ForeignKey(
                        name: "FK_Gear_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "beee3cc6-45c7-4589-b90b-ae0bb7e2d671", "8ff28732-dfbd-465b-b08b-f1c3e414f587", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3206dae7-32c7-450c-ac37-67507494427b", "be7e0de4-642d-4cab-bbed-63d92cef8d2c", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_Gear_UserId",
                table: "Gear",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gear");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3206dae7-32c7-450c-ac37-67507494427b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "beee3cc6-45c7-4589-b90b-ae0bb7e2d671");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f6cd44fb-d986-416b-879f-8c818016d717", "15a2ebaf-3f15-42b7-96d5-567d2f25dfb3", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5fbee022-6434-498d-949b-2e36bc00f746", "32c311cc-5e96-4ea5-928a-f7f5279d420e", "Admin", "ADMIN" });
        }
    }
}
