using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class SeedEvents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    VolunteerId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55208830-9fc2-4268-8eb5-de1d26a23c17", "AQAAAAEAACcQAAAAEB9/hXAyPy1AjYdfx4gROoqe6k3FaKWhswif4UOG2i1slsY4/zKxxRBsU55SOdAzYw==", "9e1f2193-30c3-4405-a6e9-c58713493d0d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd70c511-d9b5-476e-bd4a-7bce1647024c", "AQAAAAEAACcQAAAAEKCKbstjY0P6vV+KQ5J2QJNICBINGSo+FBrnEzg+IbYSrd1ys9U1Z0U2Ir5QX7J9mA==", "05273162-8d58-4db8-b059-b31b6af7210f" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 12, 28, 29, 305, DateTimeKind.Local).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 12, 28, 29, 305, DateTimeKind.Local).AddTicks(3232));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 12, 28, 29, 305, DateTimeKind.Local).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 12, 28, 29, 305, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 5, 25, 12, 28, 29, 305, DateTimeKind.Local).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 5, 25, 12, 28, 29, 305, DateTimeKind.Local).AddTicks(3198));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 5, 25, 12, 28, 29, 305, DateTimeKind.Local).AddTicks(3200));
        }
    }
}
