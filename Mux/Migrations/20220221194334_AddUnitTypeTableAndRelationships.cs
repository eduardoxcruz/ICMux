using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mux.Migrations
{
    public partial class AddUnitTypeTableAndRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UnitTypeId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "UnitTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_UnitTypeId",
                table: "Products",
                column: "UnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitTypes_Id",
                table: "UnitTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_UnitTypes_UnitTypeId",
                table: "Products",
                column: "UnitTypeId",
                principalTable: "UnitTypes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_UnitTypes_UnitTypeId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "UnitTypes");

            migrationBuilder.DropIndex(
                name: "IX_Products_UnitTypeId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UnitTypeId",
                table: "Products");
        }
    }
}
