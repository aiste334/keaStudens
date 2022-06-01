using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class TaskVolunteerRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VolunteerId",
                table: "Task",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Task_VolunteerId",
                table: "Task",
                column: "VolunteerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Task_Volunteer_VolunteerId",
                table: "Task",
                column: "VolunteerId",
                principalTable: "Volunteer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Task_Volunteer_VolunteerId",
                table: "Task");

            migrationBuilder.DropIndex(
                name: "IX_Task_VolunteerId",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "VolunteerId",
                table: "Task");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "880d53e1-c0de-4b2e-8272-06d476cc4031", "AQAAAAEAACcQAAAAEG+jqg63veziBZ6hcC74Tvnk1VP2IT8goz7kyrksM+O+hR3FrXx1g9fxJwaWcfWf3w==", "7ba9e8e0-dd3a-409a-a795-b1a7a8c9949b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81569ddc-f01c-454e-89aa-1f06f5f597f0", "AQAAAAEAACcQAAAAEPhhazavhTIfWYb9osbz9uIWjXJI7enN0+o9KltPeKL8CmIERijbI/90gQBRDKAZFQ==", "5957154b-fd4d-415a-9bd7-c0fde41b528c" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 31, 18, 19, 3, 803, DateTimeKind.Local).AddTicks(3446));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 31, 18, 19, 3, 803, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 31, 18, 19, 3, 803, DateTimeKind.Local).AddTicks(3452));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 31, 18, 19, 3, 803, DateTimeKind.Local).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 5, 31, 18, 19, 3, 803, DateTimeKind.Local).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 5, 31, 18, 19, 3, 803, DateTimeKind.Local).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 5, 31, 18, 19, 3, 803, DateTimeKind.Local).AddTicks(3421));
        }
    }
}
