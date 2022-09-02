using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Presences.Infrastructure.Migrations
{
    public partial class SeedMomentData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_moments_lectors_LectorId",
                table: "moments");

            migrationBuilder.RenameColumn(
                name: "LectorId",
                table: "moments",
                newName: "LectorId");

            migrationBuilder.RenameIndex(
                name: "IX_moments_LectorId",
                table: "moments",
                newName: "IX_moments_LectorId");

            migrationBuilder.InsertData(
                table: "moments",
                columns: new[] { "id", "date", "LectorId", "location", "type", "name" },
                values: new object[,]
                {
                    { 1, null, 3, null, 1, "PE Web Expert" },
                    { 2, null, 1, null, 0, "Examen IT Essentials" },
                    { 3, null, 1, null, 0, "Examen Java Essentials" },
                    { 4, null, 1, null, 0, "Examen Java Advanced 1" },
                    { 5, null, 1, null, 0, "Examen Java Advanced 2" },
                    { 6, null, 4, null, 1, "PE Security Essentials" },
                    { 7, null, 4, null, 0, "Examen Security Essentials" },
                    { 8, null, 4, null, 0, "Examen Web Expert" },
                    { 9, null, 5, null, 0, "Examen Linux Dekstop" },
                    { 10, null, 5, null, 1, "PE Mobile Development" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_moments_lectors_LectorId",
                table: "moments",
                column: "LectorId",
                principalTable: "lectors",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_moments_lectors_LectorId",
                table: "moments");

            migrationBuilder.DeleteData(
                table: "moments",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "moments",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "moments",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "moments",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "moments",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "moments",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "moments",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "moments",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "moments",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "moments",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.RenameColumn(
                name: "LectorId",
                table: "moments",
                newName: "LectorId");

            migrationBuilder.RenameIndex(
                name: "IX_moments_LectorId",
                table: "moments",
                newName: "IX_moments_LectorId");

            migrationBuilder.AddForeignKey(
                name: "FK_moments_lectors_LectorId",
                table: "moments",
                column: "LectorId",
                principalTable: "lectors",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
