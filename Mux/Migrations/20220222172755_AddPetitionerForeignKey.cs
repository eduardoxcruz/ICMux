using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mux.Migrations
{
    public partial class AddPetitionerForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PetitionerId",
                table: "ShoppingCart",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCart_PetitionerId",
                table: "ShoppingCart",
                column: "PetitionerId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCart_Employees_PetitionerId",
                table: "ShoppingCart",
                column: "PetitionerId",
                principalTable: "Employees",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCart_Employees_PetitionerId",
                table: "ShoppingCart");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCart_PetitionerId",
                table: "ShoppingCart");

            migrationBuilder.DropColumn(
                name: "PetitionerId",
                table: "ShoppingCart");
        }
    }
}
