using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KTSD.Data.Migrations
{
    public partial class RelationAdded2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserFile_Files_FileId",
                table: "UserFile");

            migrationBuilder.DropForeignKey(
                name: "FK_UserFile_Users_UserId",
                table: "UserFile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserFile",
                table: "UserFile");

            migrationBuilder.RenameTable(
                name: "UserFile",
                newName: "UserFiles");

            migrationBuilder.RenameIndex(
                name: "IX_UserFile_FileId",
                table: "UserFiles",
                newName: "IX_UserFiles_FileId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 18, 13, 25, 39, 647, DateTimeKind.Local).AddTicks(4360),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 17, 0, 0, 54, 558, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Projects",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 18, 13, 25, 39, 682, DateTimeKind.Local).AddTicks(4810),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 17, 0, 0, 54, 591, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pages",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 18, 13, 25, 39, 665, DateTimeKind.Local).AddTicks(5600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 17, 0, 0, 54, 574, DateTimeKind.Local).AddTicks(8960));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Menus",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 18, 13, 25, 39, 669, DateTimeKind.Local).AddTicks(8830),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 17, 0, 0, 54, 578, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Files",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 18, 13, 25, 39, 678, DateTimeKind.Local).AddTicks(4960),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 17, 0, 0, 54, 586, DateTimeKind.Local).AddTicks(5990));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 18, 13, 25, 39, 688, DateTimeKind.Local).AddTicks(2130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 17, 0, 0, 54, 596, DateTimeKind.Local).AddTicks(1280));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Announcements",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 18, 13, 25, 39, 674, DateTimeKind.Local).AddTicks(1460),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 17, 0, 0, 54, 582, DateTimeKind.Local).AddTicks(5760));

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserFiles",
                table: "UserFiles",
                columns: new[] { "UserId", "FileId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserFiles_Files_FileId",
                table: "UserFiles",
                column: "FileId",
                principalTable: "Files",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserFiles_Users_UserId",
                table: "UserFiles",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserFiles_Files_FileId",
                table: "UserFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserFiles_Users_UserId",
                table: "UserFiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserFiles",
                table: "UserFiles");

            migrationBuilder.RenameTable(
                name: "UserFiles",
                newName: "UserFile");

            migrationBuilder.RenameIndex(
                name: "IX_UserFiles_FileId",
                table: "UserFile",
                newName: "IX_UserFile_FileId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 0, 0, 54, 558, DateTimeKind.Local).AddTicks(420),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 18, 13, 25, 39, 647, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 0, 0, 54, 591, DateTimeKind.Local).AddTicks(380),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 18, 13, 25, 39, 682, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 0, 0, 54, 574, DateTimeKind.Local).AddTicks(8960),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 18, 13, 25, 39, 665, DateTimeKind.Local).AddTicks(5600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 0, 0, 54, 578, DateTimeKind.Local).AddTicks(4550),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 18, 13, 25, 39, 669, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Files",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 0, 0, 54, 586, DateTimeKind.Local).AddTicks(5990),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 18, 13, 25, 39, 678, DateTimeKind.Local).AddTicks(4960));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 0, 0, 54, 596, DateTimeKind.Local).AddTicks(1280),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 18, 13, 25, 39, 688, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Announcements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 0, 0, 54, 582, DateTimeKind.Local).AddTicks(5760),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 18, 13, 25, 39, 674, DateTimeKind.Local).AddTicks(1460));

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserFile",
                table: "UserFile",
                columns: new[] { "UserId", "FileId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserFile_Files_FileId",
                table: "UserFile",
                column: "FileId",
                principalTable: "Files",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserFile_Users_UserId",
                table: "UserFile",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
