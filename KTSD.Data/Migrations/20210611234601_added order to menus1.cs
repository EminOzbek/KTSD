using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KTSD.Data.Migrations
{
    public partial class addedordertomenus1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WeeklyInfos",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 978, DateTimeKind.Local).AddTicks(9950),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 42, 0, 41, DateTimeKind.Local).AddTicks(2110));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 907, DateTimeKind.Local).AddTicks(3080),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 41, 59, 956, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 975, DateTimeKind.Local).AddTicks(1200),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 42, 0, 37, DateTimeKind.Local).AddTicks(1170));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Projects",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 941, DateTimeKind.Local).AddTicks(800),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 41, 59, 991, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pages",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 924, DateTimeKind.Local).AddTicks(1970),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 41, 59, 974, DateTimeKind.Local).AddTicks(7370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 965, DateTimeKind.Local).AddTicks(9380),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 42, 0, 17, DateTimeKind.Local).AddTicks(7480));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Menus",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 928, DateTimeKind.Local).AddTicks(8970),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 41, 59, 979, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.AddColumn<int>(
                name: "OrderIndex",
                table: "Menus",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Files",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 936, DateTimeKind.Local).AddTicks(8100),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 41, 59, 986, DateTimeKind.Local).AddTicks(7670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 946, DateTimeKind.Local).AddTicks(7890),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 41, 59, 997, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ContactInfos",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 971, DateTimeKind.Local).AddTicks(70),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 42, 0, 22, DateTimeKind.Local).AddTicks(5780));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Banners",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 961, DateTimeKind.Local).AddTicks(4240),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 42, 0, 13, DateTimeKind.Local).AddTicks(1490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Announcements",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 933, DateTimeKind.Local).AddTicks(6420),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 41, 59, 983, DateTimeKind.Local).AddTicks(5050));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderIndex",
                table: "Menus");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WeeklyInfos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 42, 0, 41, DateTimeKind.Local).AddTicks(2110),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 978, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 41, 59, 956, DateTimeKind.Local).AddTicks(4450),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 907, DateTimeKind.Local).AddTicks(3080));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 42, 0, 37, DateTimeKind.Local).AddTicks(1170),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 975, DateTimeKind.Local).AddTicks(1200));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 41, 59, 991, DateTimeKind.Local).AddTicks(4640),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 941, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 41, 59, 974, DateTimeKind.Local).AddTicks(7370),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 924, DateTimeKind.Local).AddTicks(1970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 42, 0, 17, DateTimeKind.Local).AddTicks(7480),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 965, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 41, 59, 979, DateTimeKind.Local).AddTicks(2060),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 928, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Files",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 41, 59, 986, DateTimeKind.Local).AddTicks(7670),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 936, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 41, 59, 997, DateTimeKind.Local).AddTicks(1890),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 946, DateTimeKind.Local).AddTicks(7890));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ContactInfos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 42, 0, 22, DateTimeKind.Local).AddTicks(5780),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 971, DateTimeKind.Local).AddTicks(70));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Banners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 42, 0, 13, DateTimeKind.Local).AddTicks(1490),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 961, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Announcements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 41, 59, 983, DateTimeKind.Local).AddTicks(5050),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 933, DateTimeKind.Local).AddTicks(6420));
        }
    }
}
