using Microsoft.EntityFrameworkCore.Migrations;

namespace EventCatalogAPI.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Event Locations",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Event Locations",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StateName",
                table: "Event Locations",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<long>(
                name: "PhoneNumber",
                table: "Event",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Event Locations");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Event Locations");

            migrationBuilder.DropColumn(
                name: "StateName",
                table: "Event Locations");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Event",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(long),
                oldMaxLength: 10);
        }
    }
}
