using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KTSD.Data.Migrations
{
    public partial class RelationAdded1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Members_MemberId",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "MemberId",
                table: "Users",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 0, 0, 54, 558, DateTimeKind.Local).AddTicks(420),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 12, 2, 18, 23, 484, DateTimeKind.Local).AddTicks(7870));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Projects",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 0, 0, 54, 591, DateTimeKind.Local).AddTicks(380),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 12, 2, 18, 23, 518, DateTimeKind.Local).AddTicks(520));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pages",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 0, 0, 54, 574, DateTimeKind.Local).AddTicks(8960),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 12, 2, 18, 23, 501, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Menus",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 0, 0, 54, 578, DateTimeKind.Local).AddTicks(4550),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 12, 2, 18, 23, 505, DateTimeKind.Local).AddTicks(5030));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Files",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 0, 0, 54, 586, DateTimeKind.Local).AddTicks(5990),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 12, 2, 18, 23, 513, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 0, 0, 54, 596, DateTimeKind.Local).AddTicks(1280),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 12, 2, 18, 23, 524, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Announcements",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 0, 0, 54, 582, DateTimeKind.Local).AddTicks(5760),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 12, 2, 18, 23, 509, DateTimeKind.Local).AddTicks(2860));

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Members_MemberId",
                table: "Users",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Members_MemberId",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "MemberId",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 12, 2, 18, 23, 484, DateTimeKind.Local).AddTicks(7870),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 17, 0, 0, 54, 558, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 12, 2, 18, 23, 518, DateTimeKind.Local).AddTicks(520),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 17, 0, 0, 54, 591, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 12, 2, 18, 23, 501, DateTimeKind.Local).AddTicks(4690),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 17, 0, 0, 54, 574, DateTimeKind.Local).AddTicks(8960));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 12, 2, 18, 23, 505, DateTimeKind.Local).AddTicks(5030),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 17, 0, 0, 54, 578, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Files",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 12, 2, 18, 23, 513, DateTimeKind.Local).AddTicks(3420),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 17, 0, 0, 54, 586, DateTimeKind.Local).AddTicks(5990));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 12, 2, 18, 23, 524, DateTimeKind.Local).AddTicks(7380),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 17, 0, 0, 54, 596, DateTimeKind.Local).AddTicks(1280));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Announcements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 12, 2, 18, 23, 509, DateTimeKind.Local).AddTicks(2860),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 17, 0, 0, 54, 582, DateTimeKind.Local).AddTicks(5760));

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Members_MemberId",
                table: "Users",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
