using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KTSD.Data.Migrations
{
    public partial class UserRoleUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WeeklyInfos",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 87, DateTimeKind.Local).AddTicks(8310),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 145, DateTimeKind.Local).AddTicks(200));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 41, 16, 975, DateTimeKind.Local).AddTicks(9060),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 44, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.AddColumn<bool>(
                name: "FirstLogin",
                table: "Users",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 82, DateTimeKind.Local).AddTicks(8260),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 139, DateTimeKind.Local).AddTicks(7980));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Roles",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Projects",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 32, DateTimeKind.Local).AddTicks(8950),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 86, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pages",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 3, DateTimeKind.Local).AddTicks(3980),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 64, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 66, DateTimeKind.Local).AddTicks(2920),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 116, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Menus",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 11, DateTimeKind.Local).AddTicks(8080),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 73, DateTimeKind.Local).AddTicks(2630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Files",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 26, DateTimeKind.Local).AddTicks(4290),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 82, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 40, DateTimeKind.Local).AddTicks(2360),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 93, DateTimeKind.Local).AddTicks(8790));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ContactInfos",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 77, DateTimeKind.Local).AddTicks(5270),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 134, DateTimeKind.Local).AddTicks(5460));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Banners",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 58, DateTimeKind.Local).AddTicks(4490),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 110, DateTimeKind.Local).AddTicks(9860));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Announcements",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 22, DateTimeKind.Local).AddTicks(2840),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 78, DateTimeKind.Local).AddTicks(2150));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstLogin",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Roles");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WeeklyInfos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 145, DateTimeKind.Local).AddTicks(200),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 87, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 44, DateTimeKind.Local).AddTicks(4200),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 41, 16, 975, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 139, DateTimeKind.Local).AddTicks(7980),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 82, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 86, DateTimeKind.Local).AddTicks(8320),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 32, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 64, DateTimeKind.Local).AddTicks(9870),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 3, DateTimeKind.Local).AddTicks(3980));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 116, DateTimeKind.Local).AddTicks(8540),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 66, DateTimeKind.Local).AddTicks(2920));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 73, DateTimeKind.Local).AddTicks(2630),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 11, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Files",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 82, DateTimeKind.Local).AddTicks(7700),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 26, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 93, DateTimeKind.Local).AddTicks(8790),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 40, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ContactInfos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 134, DateTimeKind.Local).AddTicks(5460),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 77, DateTimeKind.Local).AddTicks(5270));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Banners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 110, DateTimeKind.Local).AddTicks(9860),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 58, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Announcements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 78, DateTimeKind.Local).AddTicks(2150),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 22, DateTimeKind.Local).AddTicks(2840));
        }
    }
}
