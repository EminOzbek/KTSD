using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KTSD.Data.Migrations
{
    public partial class UserRoleUpdated1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WeeklyInfos",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 909, DateTimeKind.Local).AddTicks(2250),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 87, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.AlterColumn<bool>(
                name: "FirstLogin",
                table: "Users",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 801, DateTimeKind.Local).AddTicks(6410),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 41, 16, 975, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 904, DateTimeKind.Local).AddTicks(9190),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 82, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Projects",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 858, DateTimeKind.Local).AddTicks(2630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 32, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pages",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 831, DateTimeKind.Local).AddTicks(7110),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 3, DateTimeKind.Local).AddTicks(3980));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 893, DateTimeKind.Local).AddTicks(3330),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 66, DateTimeKind.Local).AddTicks(2920));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Menus",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 836, DateTimeKind.Local).AddTicks(8000),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 11, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Files",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 851, DateTimeKind.Local).AddTicks(4280),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 26, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 868, DateTimeKind.Local).AddTicks(2890),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 40, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ContactInfos",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 900, DateTimeKind.Local).AddTicks(850),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 77, DateTimeKind.Local).AddTicks(5270));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Banners",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 887, DateTimeKind.Local).AddTicks(7920),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 58, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Announcements",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 842, DateTimeKind.Local).AddTicks(6730),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 22, DateTimeKind.Local).AddTicks(2840));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WeeklyInfos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 87, DateTimeKind.Local).AddTicks(8310),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 909, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.AlterColumn<bool>(
                name: "FirstLogin",
                table: "Users",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 41, 16, 975, DateTimeKind.Local).AddTicks(9060),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 801, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 82, DateTimeKind.Local).AddTicks(8260),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 904, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 32, DateTimeKind.Local).AddTicks(8950),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 858, DateTimeKind.Local).AddTicks(2630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 3, DateTimeKind.Local).AddTicks(3980),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 831, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 66, DateTimeKind.Local).AddTicks(2920),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 893, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 11, DateTimeKind.Local).AddTicks(8080),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 836, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Files",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 26, DateTimeKind.Local).AddTicks(4290),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 851, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 40, DateTimeKind.Local).AddTicks(2360),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 868, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ContactInfos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 77, DateTimeKind.Local).AddTicks(5270),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 900, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Banners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 58, DateTimeKind.Local).AddTicks(4490),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 887, DateTimeKind.Local).AddTicks(7920));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Announcements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 41, 17, 22, DateTimeKind.Local).AddTicks(2840),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 842, DateTimeKind.Local).AddTicks(6730));
        }
    }
}
