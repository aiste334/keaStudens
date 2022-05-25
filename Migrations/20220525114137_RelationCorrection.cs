using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class RelationCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VolunteerId1",
                table: "Event",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0312790c-cad4-449e-82ca-b60e34cf4471", "AQAAAAEAACcQAAAAEO3ks9ngu1I1KqISLh5XBuXiEJGsNyOrveydUNFCqWnZXCqFqjO67wG5cvbmWHePjQ==", "dd42d203-ab53-4a07-afb6-a48e765bbf68" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "839cd2fd-93b8-4f55-89d0-3dc51380f157", "AQAAAAEAACcQAAAAEBvAr5s7axjFUaHgeNUhcQTyUvUR6HF98rJbZZMT+UrXnMVZwGLGQYnJWwGBFyP8iQ==", "9472ad4b-426c-4b18-89ff-e97e66374016" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 13, 41, 37, 522, DateTimeKind.Local).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 13, 41, 37, 522, DateTimeKind.Local).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 13, 41, 37, 522, DateTimeKind.Local).AddTicks(9447));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 13, 41, 37, 522, DateTimeKind.Local).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 5, 25, 13, 41, 37, 522, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 5, 25, 13, 41, 37, 522, DateTimeKind.Local).AddTicks(9426));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 5, 25, 13, 41, 37, 522, DateTimeKind.Local).AddTicks(9428));

            migrationBuilder.CreateIndex(
                name: "IX_Event_VolunteerId1",
                table: "Event",
                column: "VolunteerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Volunteer_VolunteerId1",
                table: "Event",
                column: "VolunteerId1",
                principalTable: "Volunteer",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_Volunteer_VolunteerId1",
                table: "Event");

            migrationBuilder.DropIndex(
                name: "IX_Event_VolunteerId1",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "VolunteerId1",
                table: "Event");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d04639fc-1dce-4268-aa7e-fa4fc82f55a2", "AQAAAAEAACcQAAAAEAoobw7iF73uA2047ZIApfMFAPpzUmxNC6nVnkfUV8ORdbuyYUhiZ5g93S2LJUH4Nw==", "768ab34a-5e83-4fe4-9a46-5ad0d6749376" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef13e65a-7927-4842-ac71-35d56b3ac2c6", "AQAAAAEAACcQAAAAEJUmnqjTmLkRrUxne2C7Wv/RZ9XEorOu7fOxw8lkxtTnmTwdQ4jxbpj+5RFeutV/9w==", "e11f8370-bffa-4433-8f11-369d8331fde3" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 13, 35, 3, 785, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 13, 35, 3, 785, DateTimeKind.Local).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 13, 35, 3, 785, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 13, 35, 3, 785, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 5, 25, 13, 35, 3, 785, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 5, 25, 13, 35, 3, 785, DateTimeKind.Local).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 5, 25, 13, 35, 3, 785, DateTimeKind.Local).AddTicks(2086));
        }
    }
}
