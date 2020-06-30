using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DigitalShoppingTakkala.Migrations
{
    public partial class newrows : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeliverCustomers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeliverCustomers",
                columns: table => new
                {
                    DeliverID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeliverPhone = table.Column<string>(nullable: false),
                    Deliveraddress = table.Column<string>(nullable: false),
                    Delivergender = table.Column<string>(nullable: true),
                    Deliverlastname = table.Column<string>(nullable: false),
                    Delivername = table.Column<string>(nullable: false),
                    Deliverprovince = table.Column<string>(nullable: false),
                    SiteUser = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliverCustomers", x => x.DeliverID);
                });
        }
    }
}
