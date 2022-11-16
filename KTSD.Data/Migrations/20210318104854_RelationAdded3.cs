using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KTSD.Data.Migrations
{
    public partial class RelationAdded3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 18, 13, 48, 54, 452, DateTimeKind.Local).AddTicks(8870),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 18, 13, 25, 39, 647, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Projects",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 18, 13, 48, 54, 486, DateTimeKind.Local).AddTicks(6030),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 18, 13, 25, 39, 682, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pages",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 18, 13, 48, 54, 469, DateTimeKind.Local).AddTicks(6560),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 18, 13, 25, 39, 665, DateTimeKind.Local).AddTicks(5600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Menus",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 18, 13, 48, 54, 474, DateTimeKind.Local).AddTicks(3420),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 18, 13, 25, 39, 669, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Files",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 18, 13, 48, 54, 481, DateTimeKind.Local).AddTicks(9260),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 18, 13, 25, 39, 678, DateTimeKind.Local).AddTicks(4960));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 18, 13, 48, 54, 492, DateTimeKind.Local).AddTicks(1760),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 18, 13, 25, 39, 688, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Announcements",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 18, 13, 48, 54, 478, DateTimeKind.Local).AddTicks(7420),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 18, 13, 25, 39, 674, DateTimeKind.Local).AddTicks(1460));

            migrationBuilder.CreateTable(
                name: "UserFolders",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    FolderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFolders", x => new { x.UserId, x.FolderId });
                    table.ForeignKey(
                        name: "FK_UserFolders_Folder_FolderId",
                        column: x => x.FolderId,
                        principalTable: "Folder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFolders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserFolders_FolderId",
                table: "UserFolders",
                column: "FolderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserFolders");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 18, 13, 25, 39, 647, DateTimeKind.Local).AddTicks(4360),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 18, 13, 48, 54, 452, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 18, 13, 25, 39, 682, DateTimeKind.Local).AddTicks(4810),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 18, 13, 48, 54, 486, DateTimeKind.Local).AddTicks(6030));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 18, 13, 25, 39, 665, DateTimeKind.Local).AddTicks(5600),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 18, 13, 48, 54, 469, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 18, 13, 25, 39, 669, DateTimeKind.Local).AddTicks(8830),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 18, 13, 48, 54, 474, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Files",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 18, 13, 25, 39, 678, DateTimeKind.Local).AddTicks(4960),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 18, 13, 48, 54, 481, DateTimeKind.Local).AddTicks(9260));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 18, 13, 25, 39, 688, DateTimeKind.Local).AddTicks(2130),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 18, 13, 48, 54, 492, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Announcements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 18, 13, 25, 39, 674, DateTimeKind.Local).AddTicks(1460),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 18, 13, 48, 54, 478, DateTimeKind.Local).AddTicks(7420));
        }
    }
}
