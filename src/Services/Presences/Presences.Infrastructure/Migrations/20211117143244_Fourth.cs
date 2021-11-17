using Microsoft.EntityFrameworkCore.Migrations;

namespace Presences.Infrastructure.Migrations
{
    public partial class Fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11903691,
                column: "ConcurrencyStamp",
                value: "486bf434-ccc2-4c2a-b53e-0788976bf4a6");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15559621,
                column: "ConcurrencyStamp",
                value: "d5edb3ac-8e6c-472f-993a-719ad262737b");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 30441858,
                column: "ConcurrencyStamp",
                value: "1d098f2f-12bc-4c69-9c56-f44bc111a092");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 46559947,
                column: "ConcurrencyStamp",
                value: "43998ced-98bc-4f7d-91f2-eed305220b15");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 49014562,
                column: "ConcurrencyStamp",
                value: "49e88580-b20d-4a59-86ba-ad2cc6e31f0f");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 50317565,
                column: "ConcurrencyStamp",
                value: "6d5bcca9-de1e-4d83-82f3-5cf3f64435c3");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 50531122,
                column: "ConcurrencyStamp",
                value: "deebfbc9-67d6-46a5-a45c-137614a37901");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 52449732,
                column: "ConcurrencyStamp",
                value: "cc9bf18d-ca9f-4087-8f15-440ec70184e4");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 63117126,
                column: "ConcurrencyStamp",
                value: "e171f780-9c2e-415c-ae5a-f937a0082461");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 84082214,
                column: "ConcurrencyStamp",
                value: "ee6a4c7b-5583-4296-8349-a10706007263");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 91813987,
                column: "ConcurrencyStamp",
                value: "88adcf82-55bf-4a4d-bfaa-62284f786ee9");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 97305845,
                column: "ConcurrencyStamp",
                value: "d64b9492-a6a1-4388-8d0b-4ce8b7763977");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
