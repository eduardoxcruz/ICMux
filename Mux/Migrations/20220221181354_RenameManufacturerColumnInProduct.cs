using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mux.Migrations
{
    public partial class RenameManufacturerColumnInProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Manufacturer",
                table: "Products",
                newName: "OldManufacturer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OldManufacturer",
                table: "Products",
                newName: "Manufacturer");
        }
    }
}
