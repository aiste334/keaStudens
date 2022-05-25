using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class Create1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "524a7926-183b-4012-b354-e5d10641eadf", "AQAAAAEAACcQAAAAELfaH50+Bj5dL6UzTHpg+eCFEPOqXF61TX3jxFDyCOIkrULWlNWj+3LkzUmV22qDGA==", "1cf1ddae-aa0f-4e02-9808-984d333b1786" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bada0c49-9b4a-4091-8b3c-022efd3b3c65", "AQAAAAEAACcQAAAAEHIC3ChQ+DoBGbJeIdWbx5flEmtzxuSquD8ZjF1TWIHRRp84AVScF/gNXEmXuCYLPw==", "08131921-8cf4-4596-b4ac-a7be9b8934f9" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 12, 12, 17, 297, DateTimeKind.Local).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 12, 12, 17, 297, DateTimeKind.Local).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 12, 12, 17, 297, DateTimeKind.Local).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 12, 12, 17, 297, DateTimeKind.Local).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 5, 25, 12, 12, 17, 297, DateTimeKind.Local).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 5, 25, 12, 12, 17, 297, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 5, 25, 12, 12, 17, 297, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.InsertData(
                table: "Volunteer",
                columns: new[] { "Id", "Email", "LastName", "Name", "PhoneNumber", "Status" },
                values: new object[] { 2, "tina@gmail.com", "Lee", "Tina", 41236578, 1 });

            migrationBuilder.InsertData(
                table: "Volunteer",
                columns: new[] { "Id", "Email", "LastName", "Name", "PhoneNumber", "Status" },
                values: new object[] { 3, "rob@gmail.com", "Chee", "Rob", 41231258, 1 });

            migrationBuilder.InsertData(
                table: "Volunteer",
                columns: new[] { "Id", "Email", "LastName", "Name", "PhoneNumber", "Status" },
                values: new object[] { 4, "jan@gmail.com", "Bo", "Jan", 74236578, 1 });

            migrationBuilder.InsertData(
                table: "Volunteer",
                columns: new[] { "Id", "Email", "LastName", "Name", "PhoneNumber", "Status" },
                values: new object[] { 5, "bert@gmail.com", "Vert", "Bert", 32236578, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Volunteer",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Volunteer",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Volunteer",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Volunteer",
                keyColumn: "Id",
                keyValue: 5);

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
    }
}
