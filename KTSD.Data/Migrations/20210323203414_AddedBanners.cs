using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KTSD.Data.Migrations
{
    public partial class AddedBanners : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 23, 23, 34, 14, 392, DateTimeKind.Local).AddTicks(2890),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 18, 13, 48, 54, 452, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Projects",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 23, 23, 34, 14, 437, DateTimeKind.Local).AddTicks(7050),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 18, 13, 48, 54, 486, DateTimeKind.Local).AddTicks(6030));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pages",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 23, 23, 34, 14, 415, DateTimeKind.Local).AddTicks(9630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 18, 13, 48, 54, 469, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Menus",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 23, 23, 34, 14, 421, DateTimeKind.Local).AddTicks(9210),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 18, 13, 48, 54, 474, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Files",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 23, 23, 34, 14, 431, DateTimeKind.Local).AddTicks(4970),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 18, 13, 48, 54, 481, DateTimeKind.Local).AddTicks(9260));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 23, 23, 34, 14, 445, DateTimeKind.Local).AddTicks(2170),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 18, 13, 48, 54, 492, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Announcements",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 23, 23, 34, 14, 427, DateTimeKind.Local).AddTicks(90),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 18, 13, 48, 54, 478, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.CreateTable(
                name: "Banners",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2021, 3, 23, 23, 34, 14, 466, DateTimeKind.Local).AddTicks(6450)),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    UpdatedBy = table.Column<int>(nullable: true),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true),
                    ButtonText = table.Column<string>(nullable: true),
                    ButtonLink = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2021, 3, 23, 23, 34, 14, 471, DateTimeKind.Local).AddTicks(4990)),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    UpdatedBy = table.Column<int>(nullable: true),
                    Title = table.Column<string>(nullable: false),
                    Content = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Banners");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 18, 13, 48, 54, 452, DateTimeKind.Local).AddTicks(8870),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 23, 23, 34, 14, 392, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 18, 13, 48, 54, 486, DateTimeKind.Local).AddTicks(6030),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 23, 23, 34, 14, 437, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 18, 13, 48, 54, 469, DateTimeKind.Local).AddTicks(6560),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 23, 23, 34, 14, 415, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 18, 13, 48, 54, 474, DateTimeKind.Local).AddTicks(3420),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 23, 23, 34, 14, 421, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Files",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 18, 13, 48, 54, 481, DateTimeKind.Local).AddTicks(9260),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 23, 23, 34, 14, 431, DateTimeKind.Local).AddTicks(4970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 18, 13, 48, 54, 492, DateTimeKind.Local).AddTicks(1760),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 23, 23, 34, 14, 445, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Announcements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 18, 13, 48, 54, 478, DateTimeKind.Local).AddTicks(7420),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 23, 23, 34, 14, 427, DateTimeKind.Local).AddTicks(90));
        }
    }
}
