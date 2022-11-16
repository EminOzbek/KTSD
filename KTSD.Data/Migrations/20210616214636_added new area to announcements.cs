using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KTSD.Data.Migrations
{
    public partial class addednewareatoannouncements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WeeklyInfos",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 748, DateTimeKind.Local).AddTicks(4510),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 978, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 672, DateTimeKind.Local).AddTicks(5410),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 907, DateTimeKind.Local).AddTicks(3080));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 745, DateTimeKind.Local).AddTicks(800),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 975, DateTimeKind.Local).AddTicks(1200));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Projects",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 706, DateTimeKind.Local).AddTicks(6510),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 941, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pages",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 688, DateTimeKind.Local).AddTicks(9420),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 924, DateTimeKind.Local).AddTicks(1970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 731, DateTimeKind.Local).AddTicks(9500),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 965, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Menus",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 693, DateTimeKind.Local).AddTicks(5850),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 928, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Files",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 701, DateTimeKind.Local).AddTicks(7860),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 936, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 713, DateTimeKind.Local).AddTicks(2620),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 946, DateTimeKind.Local).AddTicks(7890));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ContactInfos",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 741, DateTimeKind.Local).AddTicks(1710),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 971, DateTimeKind.Local).AddTicks(70));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Banners",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 727, DateTimeKind.Local).AddTicks(7440),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 961, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Announcements",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 698, DateTimeKind.Local).AddTicks(1040),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 933, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Announcements",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Thumbnail",
                table: "Announcements",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Announcements");

            migrationBuilder.DropColumn(
                name: "Thumbnail",
                table: "Announcements");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WeeklyInfos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 978, DateTimeKind.Local).AddTicks(9950),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 748, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 907, DateTimeKind.Local).AddTicks(3080),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 672, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 975, DateTimeKind.Local).AddTicks(1200),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 745, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 941, DateTimeKind.Local).AddTicks(800),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 706, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 924, DateTimeKind.Local).AddTicks(1970),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 688, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 965, DateTimeKind.Local).AddTicks(9380),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 731, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 928, DateTimeKind.Local).AddTicks(8970),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 693, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Files",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 936, DateTimeKind.Local).AddTicks(8100),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 701, DateTimeKind.Local).AddTicks(7860));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 946, DateTimeKind.Local).AddTicks(7890),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 713, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ContactInfos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 971, DateTimeKind.Local).AddTicks(70),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 741, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Banners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 961, DateTimeKind.Local).AddTicks(4240),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 727, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Announcements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 12, 2, 46, 0, 933, DateTimeKind.Local).AddTicks(6420),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 6, 17, 0, 46, 35, 698, DateTimeKind.Local).AddTicks(1040));
        }
    }
}
