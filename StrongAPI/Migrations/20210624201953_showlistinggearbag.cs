using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StrongAPI.Migrations
{
    public partial class showlistinggearbag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "35bad529-d3a6-42f5-8d82-778b0bd7a7f1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "933456f8-3495-426e-8af9-83af73fe20a6");

            migrationBuilder.CreateTable(
                name: "GearBag",
                columns: table => new
                {
                    GearId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GearBag", x => new { x.UserId, x.GearId });
                    table.ForeignKey(
                        name: "FK_GearBag_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GearBag_Gear_GearId",
                        column: x => x.GearId,
                        principalTable: "Gear",
                        principalColumn: "GearId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShowListings",
                columns: table => new
                {
                    ShowListingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bands = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntryFee = table.Column<int>(type: "int", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShowListings", x => x.ShowListingId);
                    table.ForeignKey(
                        name: "FK_ShowListings_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3ef7453f-9a12-4809-9814-f9678f644d98", "5a5c44b4-6e71-4431-8007-e85176fdf477", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f0849b49-91bb-4759-a7eb-2f24e84503eb", "da9a4b75-988f-471d-9a70-69d9e200252e", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_GearBag_GearId",
                table: "GearBag",
                column: "GearId");

            migrationBuilder.CreateIndex(
                name: "IX_ShowListings_UserId",
                table: "ShowListings",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GearBag");

            migrationBuilder.DropTable(
                name: "ShowListings");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ef7453f-9a12-4809-9814-f9678f644d98");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0849b49-91bb-4759-a7eb-2f24e84503eb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "35bad529-d3a6-42f5-8d82-778b0bd7a7f1", "e31d6eb9-2154-48fc-9bba-c33564097790", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "933456f8-3495-426e-8af9-83af73fe20a6", "befec0c8-8cb2-40d0-a32e-e349148bb8eb", "Admin", "ADMIN" });
        }
    }
}
