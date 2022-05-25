using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Volunteer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Volunteer", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bb48e3e-d5e8-4d14-b199-7b325999ffc5", "AQAAAAEAACcQAAAAEDTn5eC8p5lwKTZcSsvNpQ6qovxU+ALiGhp3YPq8g3XPW6/ebJ3v7pKuwBl6h9RTPA==", "629ce43e-d2f1-491c-a0f4-f06feea85e85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1e5cde2-05ce-4ab1-857f-1689666fb543", "AQAAAAEAACcQAAAAENaLa5Pfiu5+nsU+F3zb8HNm42V9sMksHr5h35JzvkSV12h3OaQTTfH96XlRVH/A/g==", "8521738f-47b5-4a4e-85b9-776cdf4f5a90" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 10, 54, 13, 422, DateTimeKind.Local).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 10, 54, 13, 422, DateTimeKind.Local).AddTicks(3705));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 10, 54, 13, 422, DateTimeKind.Local).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 10, 54, 13, 422, DateTimeKind.Local).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 5, 25, 10, 54, 13, 422, DateTimeKind.Local).AddTicks(3638));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 5, 25, 10, 54, 13, 422, DateTimeKind.Local).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 5, 25, 10, 54, 13, 422, DateTimeKind.Local).AddTicks(3683));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Volunteer");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea6e0e8b-5c42-49dd-81a4-4e2d51402328", "AQAAAAEAACcQAAAAEAtw7H60mzjhPwaZ+NqRkAjZ4aeSde5fu3YGLSI94/mU/6WuVkBLkykIKECj4a1BxQ==", "3022a109-4222-44bc-a24c-7af9e69df2d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6dc398c9-9202-49b1-b82a-b5e1efd6838b", "AQAAAAEAACcQAAAAEJJ6LmqTnZ+ADQg+V3hgbbOL7y45YvStRo+ySZYGZIEFjHcV0qG8c3I5x06VKudZ1Q==", "26034978-c05a-40e5-92d2-3a5262682eb6" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 4, 25, 10, 6, 46, 740, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 4, 25, 10, 6, 46, 740, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 4, 25, 10, 6, 46, 740, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 4, 25, 10, 6, 46, 740, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 4, 25, 10, 6, 46, 739, DateTimeKind.Local).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 4, 25, 10, 6, 46, 740, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 4, 25, 10, 6, 46, 740, DateTimeKind.Local).AddTicks(30));
        }
    }
}
