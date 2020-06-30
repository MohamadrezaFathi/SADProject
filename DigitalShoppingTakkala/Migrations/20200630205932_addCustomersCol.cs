using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DigitalShoppingTakkala.Migrations
{
    public partial class addCustomersCol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "customerId",
                table: "Orders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    customerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    userId = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: false),
                    lastname = table.Column<string>(nullable: false),
                    province = table.Column<string>(nullable: false),
                    address = table.Column<string>(nullable: false),
                    gender = table.Column<string>(nullable: true),
                    phonenumber = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.customerId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_customerId",
                table: "Orders",
                column: "customerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_customerId",
                table: "Orders",
                column: "customerId",
                principalTable: "Customers",
                principalColumn: "customerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_customerId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Orders_customerId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "customerId",
                table: "Orders");
        }
    }
}
