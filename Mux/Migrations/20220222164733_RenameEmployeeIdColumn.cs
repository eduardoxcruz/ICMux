using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mux.Migrations
{
    public partial class RenameEmployeeIdColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCart_Employees_EmployeeId",
                table: "ShoppingCart");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "ShoppingCart",
                newName: "SellerId");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCart_EmployeeId",
                table: "ShoppingCart",
                newName: "IX_ShoppingCart_SellerId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCart_Employees_SellerId",
                table: "ShoppingCart",
                column: "SellerId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCart_Employees_SellerId",
                table: "ShoppingCart");

            migrationBuilder.RenameColumn(
                name: "SellerId",
                table: "ShoppingCart",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCart_SellerId",
                table: "ShoppingCart",
                newName: "IX_ShoppingCart_EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCart_Employees_EmployeeId",
                table: "ShoppingCart",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
