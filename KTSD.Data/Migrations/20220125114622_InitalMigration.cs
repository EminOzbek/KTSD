using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KTSD.Data.Migrations
{
    public partial class InitalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WeeklyInfos",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 148, DateTimeKind.Local).AddTicks(1410),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 974, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 49, DateTimeKind.Local).AddTicks(7520),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 894, DateTimeKind.Local).AddTicks(9970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 143, DateTimeKind.Local).AddTicks(6110),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 971, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Projects",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 101, DateTimeKind.Local).AddTicks(3400),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 929, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pages",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 80, DateTimeKind.Local).AddTicks(4780),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 912, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 133, DateTimeKind.Local).AddTicks(3830),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 962, DateTimeKind.Local).AddTicks(3960));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Menus",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 84, DateTimeKind.Local).AddTicks(7040),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 916, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Files",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 96, DateTimeKind.Local).AddTicks(1590),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 925, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 108, DateTimeKind.Local).AddTicks(1080),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 935, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ContactInfos",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 138, DateTimeKind.Local).AddTicks(6450),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 966, DateTimeKind.Local).AddTicks(9890));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Banners",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 128, DateTimeKind.Local).AddTicks(5240),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 958, DateTimeKind.Local).AddTicks(1420));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Announcements",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 91, DateTimeKind.Local).AddTicks(4880),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 921, DateTimeKind.Local).AddTicks(8550));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WeeklyInfos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 974, DateTimeKind.Local).AddTicks(8680),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 148, DateTimeKind.Local).AddTicks(1410));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 894, DateTimeKind.Local).AddTicks(9970),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 49, DateTimeKind.Local).AddTicks(7520));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 971, DateTimeKind.Local).AddTicks(1760),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 143, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 929, DateTimeKind.Local).AddTicks(2910),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 101, DateTimeKind.Local).AddTicks(3400));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 912, DateTimeKind.Local).AddTicks(920),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 80, DateTimeKind.Local).AddTicks(4780));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 962, DateTimeKind.Local).AddTicks(3960),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 133, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 916, DateTimeKind.Local).AddTicks(9540),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 84, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Files",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 925, DateTimeKind.Local).AddTicks(1670),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 96, DateTimeKind.Local).AddTicks(1590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 935, DateTimeKind.Local).AddTicks(1010),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 108, DateTimeKind.Local).AddTicks(1080));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ContactInfos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 966, DateTimeKind.Local).AddTicks(9890),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 138, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Banners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 958, DateTimeKind.Local).AddTicks(1420),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 128, DateTimeKind.Local).AddTicks(5240));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Announcements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 921, DateTimeKind.Local).AddTicks(8550),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 1, 25, 14, 46, 22, 91, DateTimeKind.Local).AddTicks(4880));
        }
    }
}
