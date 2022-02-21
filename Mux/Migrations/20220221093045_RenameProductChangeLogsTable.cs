using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mux.Migrations
{
    public partial class RenameProductChangeLogsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductChangeLogs_Employees_EmployeeId",
                table: "ProductChangeLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductChangeLogs_Products_ProductId",
                table: "ProductChangeLogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductChangeLogs",
                table: "ProductChangeLogs");

            migrationBuilder.RenameTable(
                name: "ProductChangeLogs",
                newName: "ProductChangelogs");

            migrationBuilder.RenameIndex(
                name: "IX_ProductChangeLogs_ProductId",
                table: "ProductChangelogs",
                newName: "IX_ProductChangelogs_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductChangeLogs_EmployeeId",
                table: "ProductChangelogs",
                newName: "IX_ProductChangelogs_EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductChangelogs",
                table: "ProductChangelogs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductChangelogs_Employees_EmployeeId",
                table: "ProductChangelogs",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductChangelogs_Products_ProductId",
                table: "ProductChangelogs",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductChangelogs_Employees_EmployeeId",
                table: "ProductChangelogs");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductChangelogs_Products_ProductId",
                table: "ProductChangelogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductChangelogs",
                table: "ProductChangelogs");

            migrationBuilder.RenameTable(
                name: "ProductChangelogs",
                newName: "ProductChangeLogs");

            migrationBuilder.RenameIndex(
                name: "IX_ProductChangelogs_ProductId",
                table: "ProductChangeLogs",
                newName: "IX_ProductChangeLogs_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductChangelogs_EmployeeId",
                table: "ProductChangeLogs",
                newName: "IX_ProductChangeLogs_EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductChangeLogs",
                table: "ProductChangeLogs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductChangeLogs_Employees_EmployeeId",
                table: "ProductChangeLogs",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductChangeLogs_Products_ProductId",
                table: "ProductChangeLogs",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
