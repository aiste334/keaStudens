using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class SeedEvents1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id", "Date", "Description", "Title", "VolunteerId" },
                values: new object[] { 1, new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Party during the summer", "Summer Party", "1" });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id", "Date", "Description", "Title", "VolunteerId" },
                values: new object[] { 2, new DateTime(2022, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Party for Christmas", "Christmas Party", "2" });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id", "Date", "Description", "Title", "VolunteerId" },
                values: new object[] { 3, new DateTime(2022, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ben's birthday party", "Birthay Party", "1" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "980300fd-33d1-4286-9201-7f9339456e6c", "AQAAAAEAACcQAAAAEK76y0Fbm9aLA0QQ97JAA1P3+qbpOjWSWg4SsA2XpFlmJK7GT2Yr+fA9mN0vzRiUHA==", "89ca960b-91c4-4b8f-8a8c-c4a661d029fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c19c13a8-bb14-4539-8ccf-e7d12c663bc2", "AQAAAAEAACcQAAAAEHP6vlKTbXDr7EgvnMC8CyPP7FlVNYDpYzwZCxAmLmFpLPB8vAdYTX1/rlxULzoJhw==", "463e69a2-f468-4222-85de-ae350927c3a6" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 13, 31, 48, 767, DateTimeKind.Local).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 13, 31, 48, 767, DateTimeKind.Local).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 13, 31, 48, 767, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 13, 31, 48, 767, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 5, 25, 13, 31, 48, 767, DateTimeKind.Local).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 5, 25, 13, 31, 48, 767, DateTimeKind.Local).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 5, 25, 13, 31, 48, 767, DateTimeKind.Local).AddTicks(6650));
        }
    }
}
