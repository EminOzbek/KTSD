using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KTSD.Data.Migrations
{
    public partial class InitalMigrationn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WeeklyInfos",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 25, 16, 34, 21, 193, DateTimeKind.Local).AddTicks(1980),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 148, DateTimeKind.Local).AddTicks(1410));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 25, 16, 34, 21, 92, DateTimeKind.Local).AddTicks(9320),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 49, DateTimeKind.Local).AddTicks(7520));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 25, 16, 34, 21, 188, DateTimeKind.Local).AddTicks(3410),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 143, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Projects",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 25, 16, 34, 21, 146, DateTimeKind.Local).AddTicks(9340),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 101, DateTimeKind.Local).AddTicks(3400));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pages",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 25, 16, 34, 21, 124, DateTimeKind.Local).AddTicks(2550),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 80, DateTimeKind.Local).AddTicks(4780));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 25, 16, 34, 21, 178, DateTimeKind.Local).AddTicks(4750),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 133, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Menus",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 25, 16, 34, 21, 128, DateTimeKind.Local).AddTicks(9430),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 84, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.AddColumn<int>(
                name: "OrderIndex",
                table: "Folder",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Files",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 25, 16, 34, 21, 141, DateTimeKind.Local).AddTicks(5630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 96, DateTimeKind.Local).AddTicks(1590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 25, 16, 34, 21, 153, DateTimeKind.Local).AddTicks(6930),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 108, DateTimeKind.Local).AddTicks(1080));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ContactInfos",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 25, 16, 34, 21, 183, DateTimeKind.Local).AddTicks(1460),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 138, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Banners",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 25, 16, 34, 21, 173, DateTimeKind.Local).AddTicks(1410),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 128, DateTimeKind.Local).AddTicks(5240));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Announcements",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 25, 16, 34, 21, 135, DateTimeKind.Local).AddTicks(5580),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 91, DateTimeKind.Local).AddTicks(4880));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderIndex",
                table: "Folder");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WeeklyInfos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 148, DateTimeKind.Local).AddTicks(1410),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 1, 25, 16, 34, 21, 193, DateTimeKind.Local).AddTicks(1980));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 49, DateTimeKind.Local).AddTicks(7520),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 1, 25, 16, 34, 21, 92, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 143, DateTimeKind.Local).AddTicks(6110),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 1, 25, 16, 34, 21, 188, DateTimeKind.Local).AddTicks(3410));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 101, DateTimeKind.Local).AddTicks(3400),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 1, 25, 16, 34, 21, 146, DateTimeKind.Local).AddTicks(9340));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 80, DateTimeKind.Local).AddTicks(4780),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 1, 25, 16, 34, 21, 124, DateTimeKind.Local).AddTicks(2550));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 133, DateTimeKind.Local).AddTicks(3830),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 1, 25, 16, 34, 21, 178, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 84, DateTimeKind.Local).AddTicks(7040),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 1, 25, 16, 34, 21, 128, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Files",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 96, DateTimeKind.Local).AddTicks(1590),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 1, 25, 16, 34, 21, 141, DateTimeKind.Local).AddTicks(5630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 108, DateTimeKind.Local).AddTicks(1080),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 1, 25, 16, 34, 21, 153, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ContactInfos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 138, DateTimeKind.Local).AddTicks(6450),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 1, 25, 16, 34, 21, 183, DateTimeKind.Local).AddTicks(1460));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Banners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 128, DateTimeKind.Local).AddTicks(5240),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 1, 25, 16, 34, 21, 173, DateTimeKind.Local).AddTicks(1410));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Announcements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 91, DateTimeKind.Local).AddTicks(4880),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 1, 25, 16, 34, 21, 135, DateTimeKind.Local).AddTicks(5580));
        }
    }
}
