using Microsoft.EntityFrameworkCore.Migrations;

namespace Presences.Infrastructure.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MomentStudent_Moments_MomentId",
                table: "MomentStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_MomentStudent_Students_StudentId",
                table: "MomentStudent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MomentStudent",
                table: "MomentStudent");

            migrationBuilder.RenameTable(
                name: "MomentStudent",
                newName: "MomentStudents");

            migrationBuilder.RenameIndex(
                name: "IX_MomentStudent_StudentId",
                table: "MomentStudents",
                newName: "IX_MomentStudents_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MomentStudents",
                table: "MomentStudents",
                columns: new[] { "MomentId", "StudentId" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11903691,
                column: "ConcurrencyStamp",
                value: "1a7b9661-f864-4424-bbdd-ad27883b9173");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15559621,
                column: "ConcurrencyStamp",
                value: "93dcab15-3194-45fc-983b-2073badd9f9b");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 30441858,
                column: "ConcurrencyStamp",
                value: "c6fb7153-bccb-431d-9cf9-e965ff535f3a");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 46559947,
                column: "ConcurrencyStamp",
                value: "aaff572d-835c-4133-899a-08bf7bbe6116");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 49014562,
                column: "ConcurrencyStamp",
                value: "96fc34ef-55c3-46f3-b621-433f5f454ae5");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 50317565,
                column: "ConcurrencyStamp",
                value: "7fcd9135-d496-4548-8269-425cde28e2ae");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 50531122,
                column: "ConcurrencyStamp",
                value: "3a6dced0-718d-497e-9124-1a9030fc248a");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 52449732,
                column: "ConcurrencyStamp",
                value: "ca86135a-3791-4348-814d-fc0142116449");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 63117126,
                column: "ConcurrencyStamp",
                value: "bc370375-6a04-4326-b001-1d533844a3f2");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 84082214,
                column: "ConcurrencyStamp",
                value: "94a6ee2e-26ae-4de9-b034-8160b5ff623c");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 91813987,
                column: "ConcurrencyStamp",
                value: "3ae9a9f9-fcc8-42e6-8ac4-2a97567a97f5");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 97305845,
                column: "ConcurrencyStamp",
                value: "6e7782c9-7e48-4159-b122-7cba67c0aacd");

            migrationBuilder.AddForeignKey(
                name: "FK_MomentStudents_Moments_MomentId",
                table: "MomentStudents",
                column: "MomentId",
                principalTable: "Moments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MomentStudents_Students_StudentId",
                table: "MomentStudents",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MomentStudents_Moments_MomentId",
                table: "MomentStudents");

            migrationBuilder.DropForeignKey(
                name: "FK_MomentStudents_Students_StudentId",
                table: "MomentStudents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MomentStudents",
                table: "MomentStudents");

            migrationBuilder.RenameTable(
                name: "MomentStudents",
                newName: "MomentStudent");

            migrationBuilder.RenameIndex(
                name: "IX_MomentStudents_StudentId",
                table: "MomentStudent",
                newName: "IX_MomentStudent_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MomentStudent",
                table: "MomentStudent",
                columns: new[] { "MomentId", "StudentId" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11903691,
                column: "ConcurrencyStamp",
                value: "62a7bd92-ba2f-4944-9a2c-31eeba5ed247");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15559621,
                column: "ConcurrencyStamp",
                value: "8073f747-e987-4d52-881f-277167503e9c");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 30441858,
                column: "ConcurrencyStamp",
                value: "04a644b4-80ec-4b29-9e62-fa7f77690918");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 46559947,
                column: "ConcurrencyStamp",
                value: "ded9e60e-6c35-4eb3-8382-0eea8cad135a");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 49014562,
                column: "ConcurrencyStamp",
                value: "9ca8995b-4fbf-467e-bcaf-07b8ac803dc0");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 50317565,
                column: "ConcurrencyStamp",
                value: "9456110a-b70e-40a0-9bc3-8c448894dd2f");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 50531122,
                column: "ConcurrencyStamp",
                value: "d493073c-4aa2-4abf-94e7-f0e52f0a1ef9");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 52449732,
                column: "ConcurrencyStamp",
                value: "803c2b48-8c5d-4588-8b8f-ce7ea6341971");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 63117126,
                column: "ConcurrencyStamp",
                value: "e5c23f1c-85aa-489e-a323-090b279b7b74");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 84082214,
                column: "ConcurrencyStamp",
                value: "dc6f6a1e-5bea-43cd-acd8-686db15e0170");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 91813987,
                column: "ConcurrencyStamp",
                value: "cc361c79-1c13-4a90-848e-e761dc08d0c3");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 97305845,
                column: "ConcurrencyStamp",
                value: "b8966e83-d9eb-43d1-906a-71d9ad271a67");

            migrationBuilder.AddForeignKey(
                name: "FK_MomentStudent_Moments_MomentId",
                table: "MomentStudent",
                column: "MomentId",
                principalTable: "Moments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MomentStudent_Students_StudentId",
                table: "MomentStudent",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
