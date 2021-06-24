using Microsoft.EntityFrameworkCore.Migrations;

namespace StrongAPI.Migrations
{
    public partial class final1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GearBag_AspNetUsers_UserId",
                table: "GearBag");

            migrationBuilder.DropForeignKey(
                name: "FK_GearBag_Gear_GearId",
                table: "GearBag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GearBag",
                table: "GearBag");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ef7453f-9a12-4809-9814-f9678f644d98");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0849b49-91bb-4759-a7eb-2f24e84503eb");

            migrationBuilder.RenameTable(
                name: "GearBag",
                newName: "GearBags");

            migrationBuilder.RenameIndex(
                name: "IX_GearBag_GearId",
                table: "GearBags",
                newName: "IX_GearBags_GearId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GearBags",
                table: "GearBags",
                columns: new[] { "UserId", "GearId" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c376530d-f6db-4823-8410-fc8a68377afd", "7761dca7-496e-493d-a2f7-0be840fba385", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a395cf26-52b8-4ed0-a232-5adcda971fc6", "8e88da33-7ff5-4ac6-b2cb-ab49a5a0323d", "Admin", "ADMIN" });

            migrationBuilder.AddForeignKey(
                name: "FK_GearBags_AspNetUsers_UserId",
                table: "GearBags",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GearBags_Gear_GearId",
                table: "GearBags",
                column: "GearId",
                principalTable: "Gear",
                principalColumn: "GearId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GearBags_AspNetUsers_UserId",
                table: "GearBags");

            migrationBuilder.DropForeignKey(
                name: "FK_GearBags_Gear_GearId",
                table: "GearBags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GearBags",
                table: "GearBags");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a395cf26-52b8-4ed0-a232-5adcda971fc6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c376530d-f6db-4823-8410-fc8a68377afd");

            migrationBuilder.RenameTable(
                name: "GearBags",
                newName: "GearBag");

            migrationBuilder.RenameIndex(
                name: "IX_GearBags_GearId",
                table: "GearBag",
                newName: "IX_GearBag_GearId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GearBag",
                table: "GearBag",
                columns: new[] { "UserId", "GearId" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3ef7453f-9a12-4809-9814-f9678f644d98", "5a5c44b4-6e71-4431-8007-e85176fdf477", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f0849b49-91bb-4759-a7eb-2f24e84503eb", "da9a4b75-988f-471d-9a70-69d9e200252e", "Admin", "ADMIN" });

            migrationBuilder.AddForeignKey(
                name: "FK_GearBag_AspNetUsers_UserId",
                table: "GearBag",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GearBag_Gear_GearId",
                table: "GearBag",
                column: "GearId",
                principalTable: "Gear",
                principalColumn: "GearId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
