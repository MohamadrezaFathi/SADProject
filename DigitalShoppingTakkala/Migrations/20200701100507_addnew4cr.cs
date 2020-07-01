using Microsoft.EntityFrameworkCore.Migrations;

namespace DigitalShoppingTakkala.Migrations
{
    public partial class addnew4cr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "addressofcr",
                table: "ClientReceivers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "lastnameofcr",
                table: "ClientReceivers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "phoneofcr",
                table: "ClientReceivers",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "addressofcr",
                table: "ClientReceivers");

            migrationBuilder.DropColumn(
                name: "lastnameofcr",
                table: "ClientReceivers");

            migrationBuilder.DropColumn(
                name: "phoneofcr",
                table: "ClientReceivers");
        }
    }
}
