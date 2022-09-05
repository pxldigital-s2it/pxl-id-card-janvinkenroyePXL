using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Presences.Infrastructure.Migrations
{
    public partial class DateAndLocationSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "moments",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "date", "location" },
                values: new object[] { new DateTime(2022, 8, 30, 21, 12, 13, 600, DateTimeKind.Local).AddTicks(919), "Online" });

            migrationBuilder.UpdateData(
                table: "moments",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "date", "location" },
                values: new object[] { new DateTime(2022, 8, 28, 0, 57, 13, 600, DateTimeKind.Local).AddTicks(1139), "Lokaal 5" });

            migrationBuilder.UpdateData(
                table: "moments",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "date", "location" },
                values: new object[] { new DateTime(2022, 9, 3, 14, 1, 13, 600, DateTimeKind.Local).AddTicks(1151), "Lokaal 6" });

            migrationBuilder.UpdateData(
                table: "moments",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "date", "location" },
                values: new object[] { new DateTime(2022, 9, 1, 8, 44, 13, 600, DateTimeKind.Local).AddTicks(1159), "Lokaal 6" });

            migrationBuilder.UpdateData(
                table: "moments",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "date", "location" },
                values: new object[] { new DateTime(2022, 9, 3, 2, 27, 13, 600, DateTimeKind.Local).AddTicks(1167), "Lokaal 1" });

            migrationBuilder.UpdateData(
                table: "moments",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "date", "location" },
                values: new object[] { new DateTime(2022, 9, 3, 16, 19, 13, 600, DateTimeKind.Local).AddTicks(1186), "Online" });

            migrationBuilder.UpdateData(
                table: "moments",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "date", "location" },
                values: new object[] { new DateTime(2022, 8, 23, 4, 3, 13, 600, DateTimeKind.Local).AddTicks(1207), "Lokaal 5" });

            migrationBuilder.UpdateData(
                table: "moments",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "date", "location" },
                values: new object[] { new DateTime(2022, 9, 3, 22, 11, 13, 600, DateTimeKind.Local).AddTicks(1214), "Lokaal 3" });

            migrationBuilder.UpdateData(
                table: "moments",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "date", "location" },
                values: new object[] { new DateTime(2022, 8, 31, 17, 47, 13, 600, DateTimeKind.Local).AddTicks(1222), "Online" });

            migrationBuilder.UpdateData(
                table: "moments",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "date", "location" },
                values: new object[] { new DateTime(2022, 9, 3, 14, 7, 13, 600, DateTimeKind.Local).AddTicks(1233), "Online" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "moments",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "date", "location" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "moments",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "date", "location" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "moments",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "date", "location" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "moments",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "date", "location" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "moments",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "date", "location" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "moments",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "date", "location" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "moments",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "date", "location" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "moments",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "date", "location" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "moments",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "date", "location" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "moments",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "date", "location" },
                values: new object[] { null, null });
        }
    }
}
