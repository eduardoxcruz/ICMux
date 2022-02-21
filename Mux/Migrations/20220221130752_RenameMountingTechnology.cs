using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mux.Migrations
{
    public partial class RenameMountingTechnology : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MountingTechnology",
                table: "Products",
                newName: "OldMountingTechnology");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OldMountingTechnology",
                table: "Products",
                newName: "MountingTechnology");
        }
    }
}
