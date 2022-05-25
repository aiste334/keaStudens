using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class CreateEvents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
