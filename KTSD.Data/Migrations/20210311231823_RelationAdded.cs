using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KTSD.Data.Migrations
{
    public partial class RelationAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 12, 2, 18, 23, 484, DateTimeKind.Local).AddTicks(7870),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 7, 22, 51, 44, 327, DateTimeKind.Local).AddTicks(2980));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Projects",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 12, 2, 18, 23, 518, DateTimeKind.Local).AddTicks(520),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 7, 22, 51, 44, 356, DateTimeKind.Local).AddTicks(1430));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pages",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 12, 2, 18, 23, 501, DateTimeKind.Local).AddTicks(4690),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 7, 22, 51, 44, 340, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Menus",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 12, 2, 18, 23, 505, DateTimeKind.Local).AddTicks(5030),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 7, 22, 51, 44, 344, DateTimeKind.Local).AddTicks(810));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Files",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 12, 2, 18, 23, 513, DateTimeKind.Local).AddTicks(3420),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 7, 22, 51, 44, 350, DateTimeKind.Local).AddTicks(470));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 12, 2, 18, 23, 524, DateTimeKind.Local).AddTicks(7380),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 7, 22, 51, 44, 360, DateTimeKind.Local).AddTicks(1910));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Announcements",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 12, 2, 18, 23, 509, DateTimeKind.Local).AddTicks(2860),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 7, 22, 51, 44, 346, DateTimeKind.Local).AddTicks(7610));

            migrationBuilder.CreateTable(
                name: "UserFile",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    FileId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFile", x => new { x.UserId, x.FileId });
                    table.ForeignKey(
                        name: "FK_UserFile_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFile_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserFile_FileId",
                table: "UserFile",
                column: "FileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserFile");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 7, 22, 51, 44, 327, DateTimeKind.Local).AddTicks(2980),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 12, 2, 18, 23, 484, DateTimeKind.Local).AddTicks(7870));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 7, 22, 51, 44, 356, DateTimeKind.Local).AddTicks(1430),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 12, 2, 18, 23, 518, DateTimeKind.Local).AddTicks(520));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 7, 22, 51, 44, 340, DateTimeKind.Local).AddTicks(9580),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 12, 2, 18, 23, 501, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 7, 22, 51, 44, 344, DateTimeKind.Local).AddTicks(810),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 12, 2, 18, 23, 505, DateTimeKind.Local).AddTicks(5030));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Files",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 7, 22, 51, 44, 350, DateTimeKind.Local).AddTicks(470),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 12, 2, 18, 23, 513, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 7, 22, 51, 44, 360, DateTimeKind.Local).AddTicks(1910),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 12, 2, 18, 23, 524, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Announcements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 7, 22, 51, 44, 346, DateTimeKind.Local).AddTicks(7610),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 12, 2, 18, 23, 509, DateTimeKind.Local).AddTicks(2860));
        }
    }
}
