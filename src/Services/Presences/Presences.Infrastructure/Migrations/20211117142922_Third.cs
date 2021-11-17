using Microsoft.EntityFrameworkCore.Migrations;

namespace Presences.Infrastructure.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11903691,
                column: "ConcurrencyStamp",
                value: "b9e6e4d4-cf37-475a-a4f2-831a0dd1e924");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15559621,
                column: "ConcurrencyStamp",
                value: "efb53a24-7f98-4521-bfde-fff1880ba622");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 30441858,
                column: "ConcurrencyStamp",
                value: "65f4aab7-31da-4cb9-9b80-5913566b40d3");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 46559947,
                column: "ConcurrencyStamp",
                value: "74e042c6-63b9-4969-af15-2d702ed1f359");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 49014562,
                column: "ConcurrencyStamp",
                value: "1dba19cd-e587-4114-ab43-c4a1be388c45");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 50317565,
                column: "ConcurrencyStamp",
                value: "5eb20a68-75b2-426d-81a7-c106189501e8");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 50531122,
                column: "ConcurrencyStamp",
                value: "8e6051ef-c642-46d1-aff6-4f7fbfd3dacc");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 52449732,
                column: "ConcurrencyStamp",
                value: "2732a37f-d4bf-45b4-92b1-203ea7a681ae");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 63117126,
                column: "ConcurrencyStamp",
                value: "40844bf9-6bca-4de2-a3e5-272041321b28");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 84082214,
                column: "ConcurrencyStamp",
                value: "1d166125-3c3d-4786-bdf0-f463fa258fe9");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 91813987,
                column: "ConcurrencyStamp",
                value: "01865b22-3d67-4866-b772-45a7398ddc6b");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 97305845,
                column: "ConcurrencyStamp",
                value: "239f38d1-af8d-403f-bd35-8be836b3f9f2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11903691,
                column: "ConcurrencyStamp",
                value: "3c56e016-567c-42e9-9caa-a03a114ecbdc");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15559621,
                column: "ConcurrencyStamp",
                value: "f582d649-1681-4de4-8641-abfea6db2346");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 30441858,
                column: "ConcurrencyStamp",
                value: "6c0ce59b-b2ef-4164-941f-2f14d67ab484");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 46559947,
                column: "ConcurrencyStamp",
                value: "80f779c2-b839-4909-90ff-4f4f7116844b");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 49014562,
                column: "ConcurrencyStamp",
                value: "6f24e7ab-41ab-4509-87f4-d0bd6f254b3f");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 50317565,
                column: "ConcurrencyStamp",
                value: "5d6d4e2d-a4ab-4bba-8e42-92d6a80ad89a");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 50531122,
                column: "ConcurrencyStamp",
                value: "e3451cdb-bb41-4941-b289-cc5223d5c717");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 52449732,
                column: "ConcurrencyStamp",
                value: "49522f32-7c76-4723-b90c-e8d7aba34fff");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 63117126,
                column: "ConcurrencyStamp",
                value: "39303a36-e10a-457c-90a7-25ab919223a9");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 84082214,
                column: "ConcurrencyStamp",
                value: "70f0434c-cd94-4468-a284-179f3ebe702c");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 91813987,
                column: "ConcurrencyStamp",
                value: "cd37c65f-8843-4ea2-af52-6e8183b763df");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 97305845,
                column: "ConcurrencyStamp",
                value: "e9f1dd24-919f-4477-af69-39a8c4735775");
        }
    }
}
