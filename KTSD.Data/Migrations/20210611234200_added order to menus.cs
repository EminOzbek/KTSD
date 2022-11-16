using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KTSD.Data.Migrations
{
    public partial class addedordertomenus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WeeklyInfos",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 42, 0, 41, DateTimeKind.Local).AddTicks(2110),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 697, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 41, 59, 956, DateTimeKind.Local).AddTicks(4450),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 627, DateTimeKind.Local).AddTicks(2970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 42, 0, 37, DateTimeKind.Local).AddTicks(1170),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 693, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Projects",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 41, 59, 991, DateTimeKind.Local).AddTicks(4640),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 660, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pages",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 41, 59, 974, DateTimeKind.Local).AddTicks(7370),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 644, DateTimeKind.Local).AddTicks(5840));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 42, 0, 17, DateTimeKind.Local).AddTicks(7480),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 684, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Menus",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 41, 59, 979, DateTimeKind.Local).AddTicks(2060),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 648, DateTimeKind.Local).AddTicks(9280));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Files",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 41, 59, 986, DateTimeKind.Local).AddTicks(7670),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 656, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 41, 59, 997, DateTimeKind.Local).AddTicks(1890),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 666, DateTimeKind.Local).AddTicks(2630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ContactInfos",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 42, 0, 22, DateTimeKind.Local).AddTicks(5780),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 689, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Banners",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 42, 0, 13, DateTimeKind.Local).AddTicks(1490),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 680, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Announcements",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 41, 59, 983, DateTimeKind.Local).AddTicks(5050),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 653, DateTimeKind.Local).AddTicks(3300));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WeeklyInfos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 697, DateTimeKind.Local).AddTicks(4100),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 42, 0, 41, DateTimeKind.Local).AddTicks(2110));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 627, DateTimeKind.Local).AddTicks(2970),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 41, 59, 956, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 693, DateTimeKind.Local).AddTicks(7070),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 42, 0, 37, DateTimeKind.Local).AddTicks(1170));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 660, DateTimeKind.Local).AddTicks(7060),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 41, 59, 991, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 644, DateTimeKind.Local).AddTicks(5840),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 41, 59, 974, DateTimeKind.Local).AddTicks(7370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 684, DateTimeKind.Local).AddTicks(9170),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 42, 0, 17, DateTimeKind.Local).AddTicks(7480));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 648, DateTimeKind.Local).AddTicks(9280),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 41, 59, 979, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Files",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 656, DateTimeKind.Local).AddTicks(5070),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 41, 59, 986, DateTimeKind.Local).AddTicks(7670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 666, DateTimeKind.Local).AddTicks(2630),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 41, 59, 997, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ContactInfos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 689, DateTimeKind.Local).AddTicks(4050),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 42, 0, 22, DateTimeKind.Local).AddTicks(5780));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Banners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 680, DateTimeKind.Local).AddTicks(4610),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 42, 0, 13, DateTimeKind.Local).AddTicks(1490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Announcements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 653, DateTimeKind.Local).AddTicks(3300),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 41, 59, 983, DateTimeKind.Local).AddTicks(5050));
        }
    }
}
