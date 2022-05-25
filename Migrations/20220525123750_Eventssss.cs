using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class Eventssss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Event",
                newName: "EventId");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Event",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f51b264-22ca-484e-8fc5-ba0a0b41a4c7", "AQAAAAEAACcQAAAAEIM+5VI/9FJpLXo9BLVyhGQ+LGHgdICFEw7EsH8NSlR012xHyfzQYIVh08UHW+52eA==", "d0994dab-b9a8-4837-a170-d9d46d7121f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62982b08-7ef3-4086-b979-a673ea07fd66", "AQAAAAEAACcQAAAAEMtfF+Iga6bDK/FiM6/xxVZqqxU1AGyASkoUCIa9iMm5h+LWZpqKtSPKyNyRflNaeA==", "84ebc54b-d631-4e9b-b785-affc831a9d93" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 14, 37, 49, 910, DateTimeKind.Local).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 14, 37, 49, 910, DateTimeKind.Local).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 14, 37, 49, 910, DateTimeKind.Local).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 14, 37, 49, 910, DateTimeKind.Local).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 5, 25, 14, 37, 49, 910, DateTimeKind.Local).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 5, 25, 14, 37, 49, 910, DateTimeKind.Local).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 5, 25, 14, 37, 49, 910, DateTimeKind.Local).AddTicks(1250));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EventId",
                table: "Event",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Event",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fc4d080-24ba-45ce-8d27-771e71d46aa5", "AQAAAAEAACcQAAAAEBn5ES2gxgXobb2PSAMT8eteqdxonXnOxzrmrBG9bvOuo1Js3fIisWz+4Q9A3bKnEg==", "552a72b3-c5db-4bed-9ef7-8a6f6e2cb40a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06f3cd82-2e7d-4000-bfdc-4446e45f9bfc", "AQAAAAEAACcQAAAAEHB+YM+laf2LIDzu+8MzsrydaU3YkHJ/6qSwFxru3jdKv/og+1Yv1jrLiv5dIShroQ==", "e48ee20a-0181-4e48-b975-58aeeef7560c" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 13, 45, 0, 105, DateTimeKind.Local).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 13, 45, 0, 105, DateTimeKind.Local).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 13, 45, 0, 105, DateTimeKind.Local).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 13, 45, 0, 105, DateTimeKind.Local).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 5, 25, 13, 45, 0, 105, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 5, 25, 13, 45, 0, 105, DateTimeKind.Local).AddTicks(2222));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 5, 25, 13, 45, 0, 105, DateTimeKind.Local).AddTicks(2223));
        }
    }
}
