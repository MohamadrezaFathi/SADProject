using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DigitalShoppingTakkala.Migrations
{
    public partial class newcoloumnsadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.CreateTable(
                name: "DeliverCustomers",
                columns: table => new
                {
                    DeliverID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SiteUser = table.Column<string>(nullable: false),
                    Delivername = table.Column<string>(nullable: false),
                    Deliverlastname = table.Column<string>(nullable: false),
                    Deliverprovince = table.Column<string>(nullable: false),
                    Deliveraddress = table.Column<string>(nullable: false),
                    Delivergender = table.Column<string>(nullable: true),
                    DeliverPhone = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliverCustomers", x => x.DeliverID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeliverCustomers");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Phone = table.Column<string>(nullable: false),
                    address = table.Column<string>(nullable: false),
                    gender = table.Column<string>(nullable: true),
                    lastname = table.Column<string>(nullable: false),
                    name = table.Column<string>(nullable: false),
                    province = table.Column<string>(nullable: false),
                    user = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CusId);
                });
        }
    }
}
