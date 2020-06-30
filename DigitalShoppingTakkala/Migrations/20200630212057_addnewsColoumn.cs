using Microsoft.EntityFrameworkCore.Migrations;

namespace DigitalShoppingTakkala.Migrations
{
    public partial class addnewsColoumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CusId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CusId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CusId",
                table: "Orders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CusId",
                table: "Orders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CusId",
                table: "Orders",
                column: "CusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CusId",
                table: "Orders",
                column: "CusId",
                principalTable: "Customers",
                principalColumn: "CusId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
