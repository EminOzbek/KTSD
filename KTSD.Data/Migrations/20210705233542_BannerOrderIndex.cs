using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KTSD.Data.Migrations
{
    public partial class BannerOrderIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WeeklyInfos",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 145, DateTimeKind.Local).AddTicks(200),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 748, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 44, DateTimeKind.Local).AddTicks(4200),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 672, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 139, DateTimeKind.Local).AddTicks(7980),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 745, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Projects",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 86, DateTimeKind.Local).AddTicks(8320),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 706, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pages",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 64, DateTimeKind.Local).AddTicks(9870),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 688, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 116, DateTimeKind.Local).AddTicks(8540),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 731, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Menus",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 73, DateTimeKind.Local).AddTicks(2630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 693, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Files",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 82, DateTimeKind.Local).AddTicks(7700),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 701, DateTimeKind.Local).AddTicks(7860));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 93, DateTimeKind.Local).AddTicks(8790),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 713, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ContactInfos",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 134, DateTimeKind.Local).AddTicks(5460),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 741, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Banners",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 110, DateTimeKind.Local).AddTicks(9860),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 727, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.AddColumn<string>(
                name: "OrderIndex",
                table: "Banners",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Announcements",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 78, DateTimeKind.Local).AddTicks(2150),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 698, DateTimeKind.Local).AddTicks(1040));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderIndex",
                table: "Banners");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WeeklyInfos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 748, DateTimeKind.Local).AddTicks(4510),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 145, DateTimeKind.Local).AddTicks(200));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 672, DateTimeKind.Local).AddTicks(5410),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 44, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 745, DateTimeKind.Local).AddTicks(800),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 139, DateTimeKind.Local).AddTicks(7980));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 706, DateTimeKind.Local).AddTicks(6510),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 86, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 688, DateTimeKind.Local).AddTicks(9420),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 64, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 731, DateTimeKind.Local).AddTicks(9500),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 116, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 693, DateTimeKind.Local).AddTicks(5850),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 73, DateTimeKind.Local).AddTicks(2630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Files",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 701, DateTimeKind.Local).AddTicks(7860),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 82, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 713, DateTimeKind.Local).AddTicks(2620),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 93, DateTimeKind.Local).AddTicks(8790));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ContactInfos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 741, DateTimeKind.Local).AddTicks(1710),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 134, DateTimeKind.Local).AddTicks(5460));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Banners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 727, DateTimeKind.Local).AddTicks(7440),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 110, DateTimeKind.Local).AddTicks(9860));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Announcements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 698, DateTimeKind.Local).AddTicks(1040),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 7, 6, 2, 35, 42, 78, DateTimeKind.Local).AddTicks(2150));
        }
    }
}
