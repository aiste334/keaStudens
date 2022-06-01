using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class testmeout : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0628dee-3144-4d8f-9581-560e2a70e768", "AQAAAAEAACcQAAAAEIDIJtXKjGeYKbxIVJJKz5xopkBLAKjT/V+Svem/ytvsMHWxczxJk33CFP8pX9TFNA==", "00d9a49a-45bb-44ee-a49a-c729ea4b0873" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a7b495b-34ac-45ee-a9fc-e06030d2f9a0", "AQAAAAEAACcQAAAAEMDGKGtnDxAj7zaCdi3wFs2lWuQrpez0rXnzsZWgs+pgMrpDiPK4YjvD+jvagi9fsw==", "678fbab0-8e25-4ecc-89ab-e59d8bbdb120" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 30, 15, 2, 49, 191, DateTimeKind.Local).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 30, 15, 2, 49, 191, DateTimeKind.Local).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 30, 15, 2, 49, 191, DateTimeKind.Local).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 30, 15, 2, 49, 191, DateTimeKind.Local).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f51b264-22ca-484e-8fc5-ba0a0b41a4c7", "AQAAAAEAACcQAAAAEIM+5VI/9FJpLXo9BLVyhGQ+LGHgdICFEw7EsH8NSlR012xHyfzQYIVh08UHW+52eA==", "d0994dab-b9a8-4837-a170-d9d46d7121f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62982b08-7ef3-4086-b979-a673ea07fd66", "AQAAAAEAACcQAAAAEMtfF+Iga6bDK/FiM6/xxVZqqxU1AGyASkoUCIa9iMm5h+LWZpqKtSPKyNyRflNaeA==", "84ebc54b-d631-4e9b-b785-affc831a9d93" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 14, 37, 49, 910, DateTimeKind.Local).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 14, 37, 49, 910, DateTimeKind.Local).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 14, 37, 49, 910, DateTimeKind.Local).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 14, 37, 49, 910, DateTimeKind.Local).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 5, 25, 14, 37, 49, 910, DateTimeKind.Local).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 5, 25, 14, 37, 49, 910, DateTimeKind.Local).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 5, 25, 14, 37, 49, 910, DateTimeKind.Local).AddTicks(1250));
        }
    }
}
