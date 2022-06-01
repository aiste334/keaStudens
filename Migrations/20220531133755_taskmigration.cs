using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class taskmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Task",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    IsComplete = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Task", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ed5c2f6-3ae0-4903-a270-9cba4c0166de", "AQAAAAEAACcQAAAAECje71udUAz0jr+eTSGVkP1DLHKTHnxt2apDgIX/A/E2O3mOqpdV4VCVkao+QfgLew==", "b64041d9-59f9-4500-81e1-776f064e55d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33ddc0f8-ae59-4ea8-8b68-0bf07f1e8fb2", "AQAAAAEAACcQAAAAEDMs/NQvknQSERC0HL47zFj3c+dKgqBBRKlhJd1NA/ahznEoHPDm1TydOeVDI9Y6tg==", "21940652-981a-43cc-8775-b08a9e0dd05a" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 31, 15, 37, 54, 897, DateTimeKind.Local).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 31, 15, 37, 54, 897, DateTimeKind.Local).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 31, 15, 37, 54, 897, DateTimeKind.Local).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 31, 15, 37, 54, 897, DateTimeKind.Local).AddTicks(7875));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Task");

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
        }
    }
}
