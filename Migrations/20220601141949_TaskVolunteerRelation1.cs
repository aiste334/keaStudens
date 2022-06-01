using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class TaskVolunteerRelation1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84aa34d2-c990-417b-a177-80f2895ff014", "AQAAAAEAACcQAAAAEAIS12SpDr1UWnGl9PqZZc94llmw4KDi5KI+nKLUr1JWodPYjnB6ulNvxG61/Khq+Q==", "5412b69c-5e51-4c4b-a936-17eee751535e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7540945-50f1-4fcf-b775-06676c74f271", "AQAAAAEAACcQAAAAECIrp+do6kWWWnZ2oOMkf06EuW/yoRi8FIFztY44/Lm/CqFsqtr1QOF1OywO1UXI1w==", "984af48b-4ca9-43fe-933d-8a0a25060f5d" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 1, 16, 16, 24, 111, DateTimeKind.Local).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 1, 16, 16, 24, 111, DateTimeKind.Local).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 1, 16, 16, 24, 111, DateTimeKind.Local).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 1, 16, 16, 24, 111, DateTimeKind.Local).AddTicks(7915));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 6, 1, 16, 16, 24, 111, DateTimeKind.Local).AddTicks(7845));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 6, 1, 16, 16, 24, 111, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 6, 1, 16, 16, 24, 111, DateTimeKind.Local).AddTicks(7884));
        }
    }
}
