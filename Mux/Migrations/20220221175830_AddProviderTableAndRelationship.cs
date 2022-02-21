using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mux.Migrations
{
    public partial class AddProviderTableAndRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProviderId",
                table: "ShoppingCart",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProviderId",
                table: "ProductChangeLogs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Providers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Providers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCart_ProviderId",
                table: "ShoppingCart",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductChangeLogs_ProviderId",
                table: "ProductChangeLogs",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_Providers_Id",
                table: "Providers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductChangeLogs_Providers_ProviderId",
                table: "ProductChangeLogs",
                column: "ProviderId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCart_Providers_ProviderId",
                table: "ShoppingCart",
                column: "ProviderId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductChangeLogs_Providers_ProviderId",
                table: "ProductChangeLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCart_Providers_ProviderId",
                table: "ShoppingCart");

            migrationBuilder.DropTable(
                name: "Providers");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCart_ProviderId",
                table: "ShoppingCart");

            migrationBuilder.DropIndex(
                name: "IX_ProductChangeLogs_ProviderId",
                table: "ProductChangeLogs");

            migrationBuilder.DropColumn(
                name: "ProviderId",
                table: "ShoppingCart");

            migrationBuilder.DropColumn(
                name: "ProviderId",
                table: "ProductChangeLogs");
        }
    }
}
