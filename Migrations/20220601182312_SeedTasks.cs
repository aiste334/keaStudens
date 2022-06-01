using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class SeedTasks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d45bc73a-81e3-4151-b0ec-1356d2f7d19e", "AQAAAAEAACcQAAAAELB84+Zfb0eGqhq6zbo0xyjKeYTJx6rcO+hWJPUyFmX1LSghh2H3H2z75JwPO1L5Zw==", "4dcfcfce-999a-43cb-a53f-aa08679bdfb4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5604bcf5-64bc-4e20-bfc2-f6b2c8828bac", "AQAAAAEAACcQAAAAEI/oMNgHOq/41qKwyLSjcDCpQjd6jlYlOfu28e7LEI2l+BOb7481dk4w3zBn/MmqxA==", "43f44333-18c8-4b72-b18a-e31f18306eb0" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 1, 20, 23, 11, 722, DateTimeKind.Local).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 1, 20, 23, 11, 722, DateTimeKind.Local).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 1, 20, 23, 11, 722, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 1, 20, 23, 11, 722, DateTimeKind.Local).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 6, 1, 20, 23, 11, 722, DateTimeKind.Local).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 6, 1, 20, 23, 11, 722, DateTimeKind.Local).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 6, 1, 20, 23, 11, 722, DateTimeKind.Local).AddTicks(1101));

            migrationBuilder.InsertData(
                table: "Task",
                columns: new[] { "Id", "IsComplete", "Name", "VolunteerId" },
                values: new object[] { 3L, false, "Buy decorations", 1 });

            migrationBuilder.InsertData(
                table: "Task",
                columns: new[] { "Id", "IsComplete", "Name", "VolunteerId" },
                values: new object[] { 4L, false, "Buy food", 1 });

            migrationBuilder.InsertData(
                table: "Task",
                columns: new[] { "Id", "IsComplete", "Name", "VolunteerId" },
                values: new object[] { 5L, false, "Invite guests", 2 });

            migrationBuilder.InsertData(
                table: "Task",
                columns: new[] { "Id", "IsComplete", "Name", "VolunteerId" },
                values: new object[] { 6L, false, "Choose music", 3 });

            migrationBuilder.InsertData(
                table: "Task",
                columns: new[] { "Id", "IsComplete", "Name", "VolunteerId" },
                values: new object[] { 7L, false, "Book venue", 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "395c5961-c320-4b18-aace-019940b12b1e", "AQAAAAEAACcQAAAAEFhFDW9o4Fs7HK7V8EOjSC7wB6HWa5/aNrS7IIeuT6JQ5PiE1eHjJ7DxBt9Cz538jg==", "e4819b9f-628e-459e-b008-6fabe36e496a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7bd4b6af-a557-422f-b73f-19d6ecf03f12", "AQAAAAEAACcQAAAAELqrwzbdWBES7y1ILABfoqjHP2GLCwmdt9A7bI6gEiSobWqNeWCLdXsUvkwfnmNIAg==", "d536bbdc-bbd4-497c-b3cf-ae87b5974596" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 1, 16, 19, 48, 883, DateTimeKind.Local).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 1, 16, 19, 48, 883, DateTimeKind.Local).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 1, 16, 19, 48, 883, DateTimeKind.Local).AddTicks(9519));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 1, 16, 19, 48, 883, DateTimeKind.Local).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 6, 1, 16, 19, 48, 883, DateTimeKind.Local).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 6, 1, 16, 19, 48, 883, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 6, 1, 16, 19, 48, 883, DateTimeKind.Local).AddTicks(9483));
        }
    }
}
