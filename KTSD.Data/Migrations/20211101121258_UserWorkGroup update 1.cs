using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KTSD.Data.Migrations
{
    public partial class UserWorkGroupupdate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                newName: "UserWorkGroup");

            migrationBuilder.RenameIndex(
                name: "IX_UserWorkgroup_WorkGroupId",
                table: "UserWorkGroup",
                newName: "IX_UserWorkGroup_WorkGroupId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WeeklyInfos",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 974, DateTimeKind.Local).AddTicks(8680),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 887, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 894, DateTimeKind.Local).AddTicks(9970),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 804, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 971, DateTimeKind.Local).AddTicks(1760),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 882, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Projects",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 929, DateTimeKind.Local).AddTicks(2910),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 843, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pages",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 912, DateTimeKind.Local).AddTicks(920),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 824, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 962, DateTimeKind.Local).AddTicks(3960),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 871, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Menus",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 916, DateTimeKind.Local).AddTicks(9540),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 830, DateTimeKind.Local).AddTicks(2650));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Files",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 925, DateTimeKind.Local).AddTicks(1670),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 839, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 935, DateTimeKind.Local).AddTicks(1010),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 850, DateTimeKind.Local).AddTicks(5620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ContactInfos",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 966, DateTimeKind.Local).AddTicks(9890),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 877, DateTimeKind.Local).AddTicks(1240));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Banners",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 958, DateTimeKind.Local).AddTicks(1420),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 867, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Announcements",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 921, DateTimeKind.Local).AddTicks(8550),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 836, DateTimeKind.Local).AddTicks(1850));

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserWorkGroup",
                table: "UserWorkGroup",
                columns: new[] { "UserId", "WorkGroupId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserWorkGroup_Users_UserId",
                table: "UserWorkGroup",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserWorkGroup_WorkGroups_WorkGroupId",
                table: "UserWorkGroup",
                column: "WorkGroupId",
                principalTable: "WorkGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserWorkGroup_Users_UserId",
                table: "UserWorkGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_UserWorkGroup_WorkGroups_WorkGroupId",
                table: "UserWorkGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserWorkGroup",
                table: "UserWorkGroup");

            migrationBuilder.RenameTable(
                name: "UserWorkGroup",
                newName: "UserWorkgroup");

            migrationBuilder.RenameIndex(
                name: "IX_UserWorkGroup_WorkGroupId",
                table: "UserWorkgroup",
                newName: "IX_UserWorkgroup_WorkGroupId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WeeklyInfos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 887, DateTimeKind.Local).AddTicks(590),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 974, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 804, DateTimeKind.Local).AddTicks(8830),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 894, DateTimeKind.Local).AddTicks(9970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 882, DateTimeKind.Local).AddTicks(9440),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 971, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 843, DateTimeKind.Local).AddTicks(9550),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 929, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 824, DateTimeKind.Local).AddTicks(5660),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 912, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 871, DateTimeKind.Local).AddTicks(8460),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 962, DateTimeKind.Local).AddTicks(3960));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 830, DateTimeKind.Local).AddTicks(2650),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 916, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Files",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 839, DateTimeKind.Local).AddTicks(6810),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 925, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 850, DateTimeKind.Local).AddTicks(5620),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 935, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ContactInfos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 877, DateTimeKind.Local).AddTicks(1240),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 966, DateTimeKind.Local).AddTicks(9890));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Banners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 867, DateTimeKind.Local).AddTicks(290),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 958, DateTimeKind.Local).AddTicks(1420));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Announcements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 1, 15, 11, 8, 836, DateTimeKind.Local).AddTicks(1850),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 11, 1, 15, 12, 57, 921, DateTimeKind.Local).AddTicks(8550));

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
    }
}
