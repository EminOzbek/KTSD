using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KTSD.Data.Migrations
{
    public partial class NewFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 2, 1, 44, 11, 969, DateTimeKind.Local).AddTicks(6000),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 23, 23, 34, 14, 392, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Projects",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 2, 1, 44, 12, 12, DateTimeKind.Local).AddTicks(3620),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 23, 23, 34, 14, 437, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.AddColumn<string>(
                name: "LangCode",
                table: "Projects",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pages",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 2, 1, 44, 11, 990, DateTimeKind.Local).AddTicks(660),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 23, 23, 34, 14, 415, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.AddColumn<string>(
                name: "LangCode",
                table: "Pages",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 2, 1, 44, 12, 43, DateTimeKind.Local).AddTicks(8480),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 23, 23, 34, 14, 471, DateTimeKind.Local).AddTicks(4990));

            migrationBuilder.AddColumn<string>(
                name: "LangCode",
                table: "Messages",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Menus",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 2, 1, 44, 11, 998, DateTimeKind.Local).AddTicks(3430),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 23, 23, 34, 14, 421, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.AddColumn<string>(
                name: "LangCode",
                table: "Menus",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Files",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 2, 1, 44, 12, 7, DateTimeKind.Local).AddTicks(5860),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 23, 23, 34, 14, 431, DateTimeKind.Local).AddTicks(4970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 2, 1, 44, 12, 19, DateTimeKind.Local).AddTicks(1330),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 23, 23, 34, 14, 445, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Banners",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 2, 1, 44, 12, 37, DateTimeKind.Local).AddTicks(6650),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 23, 23, 34, 14, 466, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.AddColumn<string>(
                name: "LangCode",
                table: "Banners",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Announcements",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 2, 1, 44, 12, 3, DateTimeKind.Local).AddTicks(1230),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 23, 23, 34, 14, 427, DateTimeKind.Local).AddTicks(90));

            migrationBuilder.AddColumn<string>(
                name: "LangCode",
                table: "Announcements",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ContactInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2021, 4, 2, 1, 44, 12, 49, DateTimeKind.Local).AddTicks(6170)),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    UpdatedBy = table.Column<int>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    FacebookLink = table.Column<string>(nullable: true),
                    LinkedinLink = table.Column<string>(nullable: true),
                    InstagramLink = table.Column<string>(nullable: true),
                    TwitterLink = table.Column<string>(nullable: true),
                    TiktokLink = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInfos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactInfos");

            migrationBuilder.DropColumn(
                name: "LangCode",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "LangCode",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "LangCode",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "LangCode",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "LangCode",
                table: "Banners");

            migrationBuilder.DropColumn(
                name: "LangCode",
                table: "Announcements");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 23, 23, 34, 14, 392, DateTimeKind.Local).AddTicks(2890),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 4, 2, 1, 44, 11, 969, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 23, 23, 34, 14, 437, DateTimeKind.Local).AddTicks(7050),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 4, 2, 1, 44, 12, 12, DateTimeKind.Local).AddTicks(3620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 23, 23, 34, 14, 415, DateTimeKind.Local).AddTicks(9630),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 4, 2, 1, 44, 11, 990, DateTimeKind.Local).AddTicks(660));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 23, 23, 34, 14, 471, DateTimeKind.Local).AddTicks(4990),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 4, 2, 1, 44, 12, 43, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 23, 23, 34, 14, 421, DateTimeKind.Local).AddTicks(9210),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 4, 2, 1, 44, 11, 998, DateTimeKind.Local).AddTicks(3430));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Files",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 23, 23, 34, 14, 431, DateTimeKind.Local).AddTicks(4970),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 4, 2, 1, 44, 12, 7, DateTimeKind.Local).AddTicks(5860));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 23, 23, 34, 14, 445, DateTimeKind.Local).AddTicks(2170),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 4, 2, 1, 44, 12, 19, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Banners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 23, 23, 34, 14, 466, DateTimeKind.Local).AddTicks(6450),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 4, 2, 1, 44, 12, 37, DateTimeKind.Local).AddTicks(6650));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Announcements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 23, 23, 34, 14, 427, DateTimeKind.Local).AddTicks(90),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 4, 2, 1, 44, 12, 3, DateTimeKind.Local).AddTicks(1230));
        }
    }
}
