using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KTSD.Data.Migrations
{
    public partial class UserWorkGroupConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_WorkGroups_WorkGroupId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_WorkGroupId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "WorkGroupId",
                table: "Users");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WeeklyInfos",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 750, DateTimeKind.Local).AddTicks(8520),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 909, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 647, DateTimeKind.Local).AddTicks(5610),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 801, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 744, DateTimeKind.Local).AddTicks(7980),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 904, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Projects",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 702, DateTimeKind.Local).AddTicks(5870),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 858, DateTimeKind.Local).AddTicks(2630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pages",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 669, DateTimeKind.Local).AddTicks(5690),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 831, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 733, DateTimeKind.Local).AddTicks(6090),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 893, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Menus",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 689, DateTimeKind.Local).AddTicks(20),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 836, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Files",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 697, DateTimeKind.Local).AddTicks(9960),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 851, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 709, DateTimeKind.Local).AddTicks(9280),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 868, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ContactInfos",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 739, DateTimeKind.Local).AddTicks(2160),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 900, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Banners",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 729, DateTimeKind.Local).AddTicks(330),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 887, DateTimeKind.Local).AddTicks(7920));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Announcements",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 694, DateTimeKind.Local).AddTicks(2940),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 842, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.CreateTable(
                name: "UserWorkflow",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    WorkGroupId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserWorkflow", x => new { x.UserId, x.WorkGroupId });
                    table.ForeignKey(
                        name: "FK_UserWorkflow_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserWorkflow_WorkGroups_WorkGroupId",
                        column: x => x.WorkGroupId,
                        principalTable: "WorkGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserWorkflow_WorkGroupId",
                table: "UserWorkflow",
                column: "WorkGroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserWorkflow");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WeeklyInfos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 909, DateTimeKind.Local).AddTicks(2250),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 750, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 801, DateTimeKind.Local).AddTicks(6410),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 647, DateTimeKind.Local).AddTicks(5610));

            migrationBuilder.AddColumn<int>(
                name: "WorkGroupId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 904, DateTimeKind.Local).AddTicks(9190),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 744, DateTimeKind.Local).AddTicks(7980));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 858, DateTimeKind.Local).AddTicks(2630),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 702, DateTimeKind.Local).AddTicks(5870));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 831, DateTimeKind.Local).AddTicks(7110),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 669, DateTimeKind.Local).AddTicks(5690));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 893, DateTimeKind.Local).AddTicks(3330),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 733, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 836, DateTimeKind.Local).AddTicks(8000),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 689, DateTimeKind.Local).AddTicks(20));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Files",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 851, DateTimeKind.Local).AddTicks(4280),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 697, DateTimeKind.Local).AddTicks(9960));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 868, DateTimeKind.Local).AddTicks(2890),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 709, DateTimeKind.Local).AddTicks(9280));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ContactInfos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 900, DateTimeKind.Local).AddTicks(850),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 739, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Banners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 887, DateTimeKind.Local).AddTicks(7920),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 729, DateTimeKind.Local).AddTicks(330));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Announcements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 12, 0, 53, 38, 842, DateTimeKind.Local).AddTicks(6730),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 694, DateTimeKind.Local).AddTicks(2940));

            migrationBuilder.CreateIndex(
                name: "IX_Users_WorkGroupId",
                table: "Users",
                column: "WorkGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_WorkGroups_WorkGroupId",
                table: "Users",
                column: "WorkGroupId",
                principalTable: "WorkGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
