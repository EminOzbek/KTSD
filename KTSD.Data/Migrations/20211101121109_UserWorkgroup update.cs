using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KTSD.Data.Migrations
{
    public partial class UserWorkgroupupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserWorkflow_Users_UserId",
                table: "UserWorkflow");

            migrationBuilder.DropForeignKey(
                name: "FK_UserWorkflow_WorkGroups_WorkGroupId",
                table: "UserWorkflow");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserWorkflow",
                table: "UserWorkflow");

            migrationBuilder.RenameTable(
                name: "UserWorkflow",
                newName: "UserWorkgroup");

            migrationBuilder.RenameIndex(
                name: "IX_UserWorkflow_WorkGroupId",
                table: "UserWorkgroup",
                newName: "IX_UserWorkgroup_WorkGroupId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WeeklyInfos",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 887, DateTimeKind.Local).AddTicks(590),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 750, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 804, DateTimeKind.Local).AddTicks(8830),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 647, DateTimeKind.Local).AddTicks(5610));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 882, DateTimeKind.Local).AddTicks(9440),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 744, DateTimeKind.Local).AddTicks(7980));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Projects",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 843, DateTimeKind.Local).AddTicks(9550),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 702, DateTimeKind.Local).AddTicks(5870));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pages",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 824, DateTimeKind.Local).AddTicks(5660),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 669, DateTimeKind.Local).AddTicks(5690));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 871, DateTimeKind.Local).AddTicks(8460),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 733, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Menus",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 830, DateTimeKind.Local).AddTicks(2650),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 689, DateTimeKind.Local).AddTicks(20));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Files",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 839, DateTimeKind.Local).AddTicks(6810),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 697, DateTimeKind.Local).AddTicks(9960));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 850, DateTimeKind.Local).AddTicks(5620),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 709, DateTimeKind.Local).AddTicks(9280));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ContactInfos",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 877, DateTimeKind.Local).AddTicks(1240),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 739, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Banners",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 867, DateTimeKind.Local).AddTicks(290),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 729, DateTimeKind.Local).AddTicks(330));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Announcements",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 836, DateTimeKind.Local).AddTicks(1850),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 694, DateTimeKind.Local).AddTicks(2940));

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserWorkgroup",
                table: "UserWorkgroup",
                columns: new[] { "UserId", "WorkGroupId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserWorkgroup_Users_UserId",
                table: "UserWorkgroup",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserWorkgroup_WorkGroups_WorkGroupId",
                table: "UserWorkgroup",
                column: "WorkGroupId",
                principalTable: "WorkGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserWorkgroup_Users_UserId",
                table: "UserWorkgroup");

            migrationBuilder.DropForeignKey(
                name: "FK_UserWorkgroup_WorkGroups_WorkGroupId",
                table: "UserWorkgroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserWorkgroup",
                table: "UserWorkgroup");

            migrationBuilder.RenameTable(
                name: "UserWorkgroup",
                newName: "UserWorkflow");

            migrationBuilder.RenameIndex(
                name: "IX_UserWorkgroup_WorkGroupId",
                table: "UserWorkflow",
                newName: "IX_UserWorkflow_WorkGroupId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WeeklyInfos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 750, DateTimeKind.Local).AddTicks(8520),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 887, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 647, DateTimeKind.Local).AddTicks(5610),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 804, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 744, DateTimeKind.Local).AddTicks(7980),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 882, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 702, DateTimeKind.Local).AddTicks(5870),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 843, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 669, DateTimeKind.Local).AddTicks(5690),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 824, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 733, DateTimeKind.Local).AddTicks(6090),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 871, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 689, DateTimeKind.Local).AddTicks(20),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 830, DateTimeKind.Local).AddTicks(2650));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Files",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 697, DateTimeKind.Local).AddTicks(9960),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 839, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 709, DateTimeKind.Local).AddTicks(9280),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 850, DateTimeKind.Local).AddTicks(5620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ContactInfos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 739, DateTimeKind.Local).AddTicks(2160),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 877, DateTimeKind.Local).AddTicks(1240));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Banners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 729, DateTimeKind.Local).AddTicks(330),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 867, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Announcements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 28, 2, 18, 27, 694, DateTimeKind.Local).AddTicks(2940),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 836, DateTimeKind.Local).AddTicks(1850));

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserWorkflow",
                table: "UserWorkflow",
                columns: new[] { "UserId", "WorkGroupId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserWorkflow_Users_UserId",
                table: "UserWorkflow",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserWorkflow_WorkGroups_WorkGroupId",
                table: "UserWorkflow",
                column: "WorkGroupId",
                principalTable: "WorkGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
