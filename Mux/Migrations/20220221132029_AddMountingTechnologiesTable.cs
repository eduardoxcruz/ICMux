using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mux.Migrations
{
    public partial class AddMountingTechnologiesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MountingTechnologyId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MountingTechnologies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MountingTechnologies", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_MountingTechnologyId",
                table: "Products",
                column: "MountingTechnologyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_MountingTechnologies_MountingTechnologyId",
                table: "Products",
                column: "MountingTechnologyId",
                principalTable: "MountingTechnologies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_MountingTechnologies_MountingTechnologyId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "MountingTechnologies");

            migrationBuilder.DropIndex(
                name: "IX_Products_MountingTechnologyId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "MountingTechnologyId",
                table: "Products");
        }
    }
}
