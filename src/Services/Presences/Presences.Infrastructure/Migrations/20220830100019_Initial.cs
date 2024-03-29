﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Presences.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    user_number = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    first_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    last_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.user_number);
                });

            migrationBuilder.CreateTable(
                name: "admins",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    UserNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admins", x => x.id);
                    table.ForeignKey(
                        name: "FK_admins_users_id",
                        column: x => x.id,
                        principalTable: "users",
                        principalColumn: "user_number");
                });

            migrationBuilder.CreateTable(
                name: "lectors",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    UserNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lectors", x => x.id);
                    table.ForeignKey(
                        name: "FK_lectors_users_id",
                        column: x => x.id,
                        principalTable: "users",
                        principalColumn: "user_number");
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    UserNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.id);
                    table.ForeignKey(
                        name: "FK_students_users_id",
                        column: x => x.id,
                        principalTable: "users",
                        principalColumn: "user_number");
                });

            migrationBuilder.CreateTable(
                name: "moments",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    type = table.Column<int>(type: "int", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LectorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_moments", x => x.id);
                    table.ForeignKey(
                        name: "FK_moments_lectors_LectorId",
                        column: x => x.LectorId,
                        principalTable: "lectors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "presences",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MomentId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    IsBlanco = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_presences", x => x.id);
                    table.ForeignKey(
                        name: "FK_presences_moments_MomentId",
                        column: x => x.MomentId,
                        principalTable: "moments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_presences_students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "students",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "user_number", "first_name", "last_name", "role", "username" },
                values: new object[,]
                {
                    { 1, "Jochem", "Beckers", 2, "jochembeckers" },
                    { 2, "Pieter", "Geerts", 2, "pietergeerts" },
                    { 3, "Chris", "Goyens", 2, "chrisgoyens" },
                    { 4, "Steven", "Jacquemin", 2, "stevenjacquemin" },
                    { 5, "Daisy", "Jansen", 2, "daisyjansen" },
                    { 6, "Geoffrey", "Jorissen", 2, "geoffreyjorissen" },
                    { 7, "Rob", "Jorissen", 2, "robjorissen" },
                    { 8, "Ward", "Lenaerts", 2, "wardlenaerts" },
                    { 9, "Stijn", "Lenaerts", 2, "stijnlenaerts" },
                    { 10, "Sigrid", "Meesters", 2, "sigridmeesters" },
                    { 11, "Enkhjargal", "Mijid", 2, "enkhjargalmijid" },
                    { 12, "Wouter", "Paps", 2, "wouterpaps" },
                    { 13, "Robby", "Quintiens", 2, "robbyquintiens" },
                    { 14, "Nadine", "Vaesen", 2, "nadinevaesen" },
                    { 15, "Jan", "Vinkenroye", 2, "janvinkenroye" },
                    { 16, "Jeff", "Willen", 2, "jeffwillen" },
                    { 17, "Nele", "Custers", 1, "nelecusters" },
                    { 18, "Luc", "Doumen", 1, "lucdoumen" },
                    { 19, "Kris", "Hermans", 1, "krishermans" },
                    { 20, "Dries", "Swinnen", 1, "driesswinnen" },
                    { 21, "Niek", "Vandael", 1, "niekvandael" },
                    { 22, "Jan", "Willekens", 1, "janwillekens" },
                    { 23, "Nathalie", "Fuchs", 0, "nathaliefuchs" }
                });

            migrationBuilder.InsertData(
                table: "admins",
                columns: new[] { "id", "UserNumber" },
                values: new object[] { 1, 23 });

            migrationBuilder.InsertData(
                table: "lectors",
                columns: new[] { "id", "UserNumber" },
                values: new object[,]
                {
                    { 1, 17 },
                    { 2, 18 },
                    { 3, 19 },
                    { 4, 20 },
                    { 5, 21 },
                    { 6, 22 }
                });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "UserNumber" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 7 },
                    { 8, 8 },
                    { 9, 9 },
                    { 10, 10 },
                    { 11, 11 },
                    { 12, 12 },
                    { 13, 13 },
                    { 14, 14 },
                    { 15, 15 },
                    { 16, 16 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_moments_LectorId",
                table: "moments",
                column: "LectorId");

            migrationBuilder.CreateIndex(
                name: "IX_presences_MomentId",
                table: "presences",
                column: "MomentId");

            migrationBuilder.CreateIndex(
                name: "IX_presences_StudentId",
                table: "presences",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_users_username",
                table: "users",
                column: "username",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admins");

            migrationBuilder.DropTable(
                name: "presences");

            migrationBuilder.DropTable(
                name: "moments");

            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "lectors");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
