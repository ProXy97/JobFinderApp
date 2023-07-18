using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobFinderApp.Data.Migrations
{
    public partial class UpdateDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ResumeeId",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePosted",
                value: new DateTime(2023, 7, 18, 11, 47, 25, 645, DateTimeKind.Utc).AddTicks(7642));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatePosted",
                value: new DateTime(2023, 7, 18, 11, 47, 25, 645, DateTimeKind.Utc).AddTicks(7651));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatePosted",
                value: new DateTime(2023, 7, 18, 11, 47, 25, 645, DateTimeKind.Utc).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatePosted",
                value: new DateTime(2023, 7, 18, 11, 47, 25, 645, DateTimeKind.Utc).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 5,
                column: "DatePosted",
                value: new DateTime(2023, 7, 18, 11, 47, 25, 645, DateTimeKind.Utc).AddTicks(7655));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ResumeeId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePosted",
                value: new DateTime(2023, 7, 11, 14, 40, 37, 238, DateTimeKind.Utc).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatePosted",
                value: new DateTime(2023, 7, 11, 14, 40, 37, 238, DateTimeKind.Utc).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatePosted",
                value: new DateTime(2023, 7, 11, 14, 40, 37, 238, DateTimeKind.Utc).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatePosted",
                value: new DateTime(2023, 7, 11, 14, 40, 37, 238, DateTimeKind.Utc).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 5,
                column: "DatePosted",
                value: new DateTime(2023, 7, 11, 14, 40, 37, 238, DateTimeKind.Utc).AddTicks(8289));
        }
    }
}
