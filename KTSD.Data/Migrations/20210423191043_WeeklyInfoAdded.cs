using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KTSD.Data.Migrations
{
    public partial class WeeklyInfoAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 627, DateTimeKind.Local).AddTicks(2970),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 12, 21, 28, 19, 159, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 693, DateTimeKind.Local).AddTicks(7070),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 12, 21, 28, 19, 226, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Projects",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 660, DateTimeKind.Local).AddTicks(7060),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 12, 21, 28, 19, 193, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pages",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 644, DateTimeKind.Local).AddTicks(5840),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 12, 21, 28, 19, 177, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 684, DateTimeKind.Local).AddTicks(9170),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 12, 21, 28, 19, 217, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Menus",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 648, DateTimeKind.Local).AddTicks(9280),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 12, 21, 28, 19, 181, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Files",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 656, DateTimeKind.Local).AddTicks(5070),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 12, 21, 28, 19, 189, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 666, DateTimeKind.Local).AddTicks(2630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 12, 21, 28, 19, 198, DateTimeKind.Local).AddTicks(8020));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ContactInfos",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 689, DateTimeKind.Local).AddTicks(4050),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 12, 21, 28, 19, 221, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Banners",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 680, DateTimeKind.Local).AddTicks(4610),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 12, 21, 28, 19, 212, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Announcements",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 653, DateTimeKind.Local).AddTicks(3300),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 12, 21, 28, 19, 186, DateTimeKind.Local).AddTicks(350));

            migrationBuilder.CreateTable(
                name: "WeeklyInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 697, DateTimeKind.Local).AddTicks(4100)),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    UpdatedBy = table.Column<int>(nullable: true),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeeklyInfos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeeklyInfos");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 12, 21, 28, 19, 159, DateTimeKind.Local).AddTicks(7430),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 627, DateTimeKind.Local).AddTicks(2970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 12, 21, 28, 19, 226, DateTimeKind.Local).AddTicks(9380),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 693, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 12, 21, 28, 19, 193, DateTimeKind.Local).AddTicks(2760),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 660, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 12, 21, 28, 19, 177, DateTimeKind.Local).AddTicks(1640),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 644, DateTimeKind.Local).AddTicks(5840));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 12, 21, 28, 19, 217, DateTimeKind.Local).AddTicks(1730),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 684, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 12, 21, 28, 19, 181, DateTimeKind.Local).AddTicks(6170),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 648, DateTimeKind.Local).AddTicks(9280));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Files",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 12, 21, 28, 19, 189, DateTimeKind.Local).AddTicks(2530),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 656, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 12, 21, 28, 19, 198, DateTimeKind.Local).AddTicks(8020),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 666, DateTimeKind.Local).AddTicks(2630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ContactInfos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 12, 21, 28, 19, 221, DateTimeKind.Local).AddTicks(8830),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 689, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Banners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 12, 21, 28, 19, 212, DateTimeKind.Local).AddTicks(8150),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 680, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Announcements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 12, 21, 28, 19, 186, DateTimeKind.Local).AddTicks(350),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 4, 23, 22, 10, 42, 653, DateTimeKind.Local).AddTicks(3300));
        }
    }
}
