using Microsoft.EntityFrameworkCore.Migrations;

namespace DigitalShoppingTakkala.Migrations
{
    public partial class addnewCol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_customerId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "customerId",
                table: "Orders",
                newName: "CusId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_customerId",
                table: "Orders",
                newName: "IX_Orders_CusId");

            migrationBuilder.RenameColumn(
                name: "phonenumber",
                table: "Customers",
                newName: "user");

            migrationBuilder.RenameColumn(
                name: "customerId",
                table: "Customers",
                newName: "CusId");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Customers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CusId",
                table: "Orders",
                column: "CusId",
                principalTable: "Customers",
                principalColumn: "CusId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CusId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "CusId",
                table: "Orders",
                newName: "customerId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_CusId",
                table: "Orders",
                newName: "IX_Orders_customerId");

            migrationBuilder.RenameColumn(
                name: "user",
                table: "Customers",
                newName: "phonenumber");

            migrationBuilder.RenameColumn(
                name: "CusId",
                table: "Customers",
                newName: "customerId");

            migrationBuilder.AddColumn<string>(
                name: "userId",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_customerId",
                table: "Orders",
                column: "customerId",
                principalTable: "Customers",
                principalColumn: "customerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
