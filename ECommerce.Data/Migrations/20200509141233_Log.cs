using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.Data.Migrations
{
    public partial class Log : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2020, 5, 9, 14, 12, 33, 275, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2020, 5, 9, 14, 12, 33, 275, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2020, 5, 9, 14, 12, 33, 275, DateTimeKind.Utc));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200);

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2020, 5, 2, 13, 9, 25, 346, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2020, 5, 2, 13, 9, 25, 346, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2020, 5, 2, 13, 9, 25, 346, DateTimeKind.Utc));
        }
    }
}
