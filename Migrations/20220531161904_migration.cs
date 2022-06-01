using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
