using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class RelationCorrection1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "VolunteerId",
                table: "Event",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
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
                table: "Event",
                keyColumn: "Id",
                keyValue: 1,
                column: "VolunteerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 2,
                column: "VolunteerId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 3,
                column: "VolunteerId",
                value: 1);

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

            migrationBuilder.CreateIndex(
                name: "IX_Event_VolunteerId",
                table: "Event",
                column: "VolunteerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Volunteer_VolunteerId",
                table: "Event",
                column: "VolunteerId",
                principalTable: "Volunteer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_Volunteer_VolunteerId",
                table: "Event");

            migrationBuilder.DropIndex(
                name: "IX_Event_VolunteerId",
                table: "Event");

            migrationBuilder.AlterColumn<string>(
                name: "VolunteerId",
                table: "Event",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

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
                table: "Event",
                keyColumn: "Id",
                keyValue: 1,
                column: "VolunteerId",
                value: "1");

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 2,
                column: "VolunteerId",
                value: "2");

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 3,
                column: "VolunteerId",
                value: "1");

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
    }
}
