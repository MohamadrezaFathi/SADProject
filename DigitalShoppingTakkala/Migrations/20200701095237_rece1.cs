using Microsoft.EntityFrameworkCore.Migrations;

namespace DigitalShoppingTakkala.Migrations
{
    public partial class rece1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "phone",
                table: "Receivers",
                newName: "phones");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Receivers",
                newName: "names");

            migrationBuilder.RenameColumn(
                name: "lastname",
                table: "Receivers",
                newName: "lastnames");

            migrationBuilder.RenameColumn(
                name: "ReceiverUserId",
                table: "Receivers",
                newName: "ReceiversUserId");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Receivers",
                newName: "Addresss");

            migrationBuilder.RenameColumn(
                name: "ReceiverId",
                table: "Receivers",
                newName: "ReceiversId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "phones",
                table: "Receivers",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "names",
                table: "Receivers",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "lastnames",
                table: "Receivers",
                newName: "lastname");

            migrationBuilder.RenameColumn(
                name: "ReceiversUserId",
                table: "Receivers",
                newName: "ReceiverUserId");

            migrationBuilder.RenameColumn(
                name: "Addresss",
                table: "Receivers",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "ReceiversId",
                table: "Receivers",
                newName: "ReceiverId");
        }
    }
}
