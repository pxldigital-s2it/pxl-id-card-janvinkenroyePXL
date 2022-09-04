using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Presences.Infrastructure.Migrations
{
    public partial class ExtraSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "moments",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "date", "name" },
                values: new object[] { new DateTime(2022, 9, 3, 12, 28, 0, 750, DateTimeKind.Local).AddTicks(9448), "PE .NET Expert" });

            migrationBuilder.UpdateData(
                table: "moments",
                keyColumn: "id",
                keyValue: 2,
                column: "date",
                value: new DateTime(2022, 8, 30, 9, 52, 0, 750, DateTimeKind.Local).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "moments",
                keyColumn: "id",
                keyValue: 3,
                column: "date",
                value: new DateTime(2022, 8, 28, 23, 54, 0, 750, DateTimeKind.Local).AddTicks(9552));

            migrationBuilder.UpdateData(
                table: "moments",
                keyColumn: "id",
                keyValue: 4,
                column: "date",
                value: new DateTime(2022, 8, 30, 18, 24, 0, 750, DateTimeKind.Local).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "moments",
                keyColumn: "id",
                keyValue: 5,
                column: "date",
                value: new DateTime(2022, 8, 24, 18, 4, 0, 750, DateTimeKind.Local).AddTicks(9574));

            migrationBuilder.UpdateData(
                table: "moments",
                keyColumn: "id",
                keyValue: 6,
                column: "date",
                value: new DateTime(2022, 8, 22, 19, 4, 0, 750, DateTimeKind.Local).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "moments",
                keyColumn: "id",
                keyValue: 7,
                column: "date",
                value: new DateTime(2022, 9, 1, 19, 14, 0, 750, DateTimeKind.Local).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "moments",
                keyColumn: "id",
                keyValue: 8,
                column: "date",
                value: new DateTime(2022, 9, 4, 0, 45, 0, 750, DateTimeKind.Local).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "moments",
                keyColumn: "id",
                keyValue: 9,
                column: "date",
                value: new DateTime(2022, 9, 1, 4, 13, 0, 750, DateTimeKind.Local).AddTicks(9594));

            migrationBuilder.UpdateData(
                table: "moments",
                keyColumn: "id",
                keyValue: 10,
                column: "date",
                value: new DateTime(2022, 9, 4, 13, 17, 0, 750, DateTimeKind.Local).AddTicks(9599));

            migrationBuilder.InsertData(
                table: "moments",
                columns: new[] { "id", "date", "LectorId", "location", "type", "name" },
                values: new object[,]
                {
                    { 11, new DateTime(2022, 8, 30, 13, 26, 0, 750, DateTimeKind.Local).AddTicks(9602), 3, "Online", 0, "Examen .NET Expert" },
                    { 12, new DateTime(2022, 8, 25, 12, 46, 0, 750, DateTimeKind.Local).AddTicks(9607), 3, "Lokaal 7", 0, "Inhaalexamen .NET Expert" }
                });

            migrationBuilder.InsertData(
                table: "presences",
                columns: new[] { "id", "IsBlanco", "MomentId", "StudentId" },
                values: new object[,]
                {
                    { 1, true, 1, 1 },
                    { 2, false, 1, 3 },
                    { 3, true, 1, 4 },
                    { 4, false, 1, 6 },
                    { 5, false, 1, 8 },
                    { 6, true, 1, 10 },
                    { 7, false, 1, 11 },
                    { 8, false, 1, 14 },
                    { 9, false, 1, 15 },
                    { 10, false, 1, 16 },
                    { 11, true, 2, 15 },
                    { 12, true, 4, 15 },
                    { 13, false, 5, 15 },
                    { 14, false, 6, 15 },
                    { 15, false, 7, 15 },
                    { 16, false, 9, 15 },
                    { 17, false, 10, 15 }
                });

            migrationBuilder.InsertData(
                table: "presences",
                columns: new[] { "id", "IsBlanco", "MomentId", "StudentId" },
                values: new object[] { 18, true, 11, 15 });

            migrationBuilder.InsertData(
                table: "presences",
                columns: new[] { "id", "IsBlanco", "MomentId", "StudentId" },
                values: new object[] { 19, false, 11, 16 });

            migrationBuilder.InsertData(
                table: "presences",
                columns: new[] { "id", "IsBlanco", "MomentId", "StudentId" },
                values: new object[] { 20, false, 11, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "moments",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "presences",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "presences",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "presences",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "presences",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "presences",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "presences",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "presences",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "presences",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "presences",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "presences",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "presences",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "presences",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "presences",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "presences",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "presences",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "presences",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "presences",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "presences",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "presences",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "presences",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "moments",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "moments",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "date", "name" },
                values: new object[] { new DateTime(2022, 8, 30, 21, 12, 13, 600, DateTimeKind.Local).AddTicks(919), "PE Web Expert" });

            migrationBuilder.UpdateData(
                table: "moments",
                keyColumn: "id",
                keyValue: 2,
                column: "date",
                value: new DateTime(2022, 8, 28, 0, 57, 13, 600, DateTimeKind.Local).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "moments",
                keyColumn: "id",
                keyValue: 3,
                column: "date",
                value: new DateTime(2022, 9, 3, 14, 1, 13, 600, DateTimeKind.Local).AddTicks(1151));

            migrationBuilder.UpdateData(
                table: "moments",
                keyColumn: "id",
                keyValue: 4,
                column: "date",
                value: new DateTime(2022, 9, 1, 8, 44, 13, 600, DateTimeKind.Local).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "moments",
                keyColumn: "id",
                keyValue: 5,
                column: "date",
                value: new DateTime(2022, 9, 3, 2, 27, 13, 600, DateTimeKind.Local).AddTicks(1167));

            migrationBuilder.UpdateData(
                table: "moments",
                keyColumn: "id",
                keyValue: 6,
                column: "date",
                value: new DateTime(2022, 9, 3, 16, 19, 13, 600, DateTimeKind.Local).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "moments",
                keyColumn: "id",
                keyValue: 7,
                column: "date",
                value: new DateTime(2022, 8, 23, 4, 3, 13, 600, DateTimeKind.Local).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "moments",
                keyColumn: "id",
                keyValue: 8,
                column: "date",
                value: new DateTime(2022, 9, 3, 22, 11, 13, 600, DateTimeKind.Local).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "moments",
                keyColumn: "id",
                keyValue: 9,
                column: "date",
                value: new DateTime(2022, 8, 31, 17, 47, 13, 600, DateTimeKind.Local).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "moments",
                keyColumn: "id",
                keyValue: 10,
                column: "date",
                value: new DateTime(2022, 9, 3, 14, 7, 13, 600, DateTimeKind.Local).AddTicks(1233));
        }
    }
}
