using Microsoft.EntityFrameworkCore.Migrations;

namespace DigitalShoppingTakkala.Migrations
{
    public partial class newOrder1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DelivAddress",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DelivLastName",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DelivName",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DelivPhone",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DelivProvince",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Orders",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DelivAddress",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DelivLastName",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DelivName",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DelivPhone",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DelivProvince",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Orders");
        }
    }
}
