using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mux.Migrations
{
    public partial class AddOrderReferenceToProductToBuy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
	        migrationBuilder.AddColumn<string>(
		        name: "OrderReference",
		        table: "ShoppingCart",
		        type: "nvarchar(50)",
		        maxLength: 50,
		        nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
	        migrationBuilder.DropColumn(
		        name: "OrderReference", 
		        table: "ShoppingCart");
        }
    }
}
