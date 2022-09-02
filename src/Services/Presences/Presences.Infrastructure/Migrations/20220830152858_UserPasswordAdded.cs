using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Presences.Infrastructure.Migrations
{
    public partial class UserPasswordAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_number",
                keyValue: 1,
                column: "password",
                value: "1234");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_number",
                keyValue: 2,
                column: "password",
                value: "1234");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_number",
                keyValue: 3,
                column: "password",
                value: "1234");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_number",
                keyValue: 4,
                column: "password",
                value: "1234");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_number",
                keyValue: 5,
                column: "password",
                value: "1234");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_number",
                keyValue: 6,
                column: "password",
                value: "1234");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_number",
                keyValue: 7,
                column: "password",
                value: "1234");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_number",
                keyValue: 8,
                column: "password",
                value: "1234");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_number",
                keyValue: 9,
                column: "password",
                value: "1234");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_number",
                keyValue: 10,
                column: "password",
                value: "1234");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_number",
                keyValue: 11,
                column: "password",
                value: "1234");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_number",
                keyValue: 12,
                column: "password",
                value: "1234");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_number",
                keyValue: 13,
                column: "password",
                value: "1234");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_number",
                keyValue: 14,
                column: "password",
                value: "1234");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_number",
                keyValue: 15,
                column: "password",
                value: "1234");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_number",
                keyValue: 16,
                column: "password",
                value: "1234");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_number",
                keyValue: 17,
                column: "password",
                value: "1234");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_number",
                keyValue: 18,
                column: "password",
                value: "1234");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_number",
                keyValue: 19,
                column: "password",
                value: "1234");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_number",
                keyValue: 20,
                column: "password",
                value: "1234");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_number",
                keyValue: 21,
                column: "password",
                value: "1234");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_number",
                keyValue: 22,
                column: "password",
                value: "1234");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_number",
                keyValue: 23,
                column: "password",
                value: "1234");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "password",
                table: "users");
        }
    }
}
