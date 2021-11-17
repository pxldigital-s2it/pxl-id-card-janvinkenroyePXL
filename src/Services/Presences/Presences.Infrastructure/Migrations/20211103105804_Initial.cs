using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Presences.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Moments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    MomentType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MomentStudent",
                columns: table => new
                {
                    MomentId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MomentStudent", x => new { x.MomentId, x.StudentId });
                    table.ForeignKey(
                        name: "FK_MomentStudent_Moments_MomentId",
                        column: x => x.MomentId,
                        principalTable: "Moments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MomentStudent_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Moments",
                columns: new[] { "Id", "MomentType", "Name" },
                values: new object[,]
                {
                    { 1, 0, "PE .NET Expert" },
                    { 2, 1, "Examen .NET Expert" },
                    { 3, 0, "PE Mobile Development" },
                    { 4, 1, "Examen Mobile Development" },
                    { 5, 1, "Examen Web Expert" },
                    { 6, 1, "Examen Java Expert" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 46559947, 0, "ded9e60e-6c35-4eb3-8382-0eea8cad135a", null, false, "Nadine", "Vaesen", false, null, null, null, null, null, false, null, false, "nadinevaesen" },
                    { 15559621, 0, "8073f747-e987-4d52-881f-277167503e9c", null, false, "Robby", "Quintiens", false, null, null, null, null, null, false, null, false, "robbyquintiens" },
                    { 52449732, 0, "803c2b48-8c5d-4588-8b8f-ce7ea6341971", null, false, "Wouter", "Paps", false, null, null, null, null, null, false, null, false, "wouterpaps" },
                    { 30441858, 0, "04a644b4-80ec-4b29-9e62-fa7f77690918", null, false, "Sigrid", "Meesters", false, null, null, null, null, null, false, null, false, "sigridmeesters" },
                    { 63117126, 0, "e5c23f1c-85aa-489e-a323-090b279b7b74", null, false, "Rob", "Jorissen", false, null, null, null, null, null, false, null, false, "robjorissen" },
                    { 84082214, 0, "dc6f6a1e-5bea-43cd-acd8-686db15e0170", null, false, "Chris", "Goyens", false, null, null, null, null, null, false, null, false, "chrisgoyens" },
                    { 49014562, 0, "9ca8995b-4fbf-467e-bcaf-07b8ac803dc0", null, false, "Steven", "Jacquemin", false, null, null, null, null, null, false, null, false, "stevenjacquemin" },
                    { 11903691, 0, "62a7bd92-ba2f-4944-9a2c-31eeba5ed247", null, false, "Jan", "Vinkenroye", false, null, null, null, null, null, false, null, false, "janvinkenroye" },
                    { 50531122, 0, "d493073c-4aa2-4abf-94e7-f0e52f0a1ef9", null, false, "Pieter", "Geerts", false, null, null, null, null, null, false, null, false, "pietergeerts" },
                    { 50317565, 0, "9456110a-b70e-40a0-9bc3-8c448894dd2f", null, false, "Jochem", "Beckers", false, null, null, null, null, null, false, null, false, "jochembeckers" },
                    { 91813987, 0, "cc361c79-1c13-4a90-848e-e761dc08d0c3", null, false, "Geoffrey", "Jorissen", false, null, null, null, null, null, false, null, false, "geoffreyjorissen" },
                    { 97305845, 0, "b8966e83-d9eb-43d1-906a-71d9ad271a67", null, false, "Jeff", "Willen", false, null, null, null, null, null, false, null, false, "jeffwillen" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MomentStudent_StudentId",
                table: "MomentStudent",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MomentStudent");

            migrationBuilder.DropTable(
                name: "Moments");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
