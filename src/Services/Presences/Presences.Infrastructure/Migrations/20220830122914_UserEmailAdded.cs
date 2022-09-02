using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Presences.Infrastructure.Migrations
{
    public partial class UserEmailAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "users",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "email",
                table: "users");
        }
    }
}
