using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mux.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EncapsulationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    BodyWidth = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    FullDescription = table.Column<string>(type: "nvarchar(max)", nullable: true, computedColumnSql: "[Name] + ' (' + [BodyWidth] + ')'", stored: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EncapsulationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    DebugCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Enrollment = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    OldMountingTechnology = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    OldEncapsulationType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Category = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsUsingInventory = table.Column<bool>(type: "bit", nullable: false),
                    CurrentAmount = table.Column<int>(type: "int", nullable: false),
                    MinAmount = table.Column<int>(type: "int", nullable: false),
                    MaxAmount = table.Column<int>(type: "int", nullable: false),
                    Container = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Location = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    BranchOffice = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Rack = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Shelf = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    BuyPrice = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: false),
                    OldUnitType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    OldManufacturer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PartNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    TypeOfStock = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IsManualProfit = table.Column<bool>(type: "bit", nullable: false),
                    PercentageOfProfit = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: true),
                    PercentageOfDiscount = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: true),
                    SalePriceWithoutDiscount = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: true),
                    SalePriceWithDiscount = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: true),
                    ProfitWithoutDiscount = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: true),
                    ProfitWithDiscount = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: true),
                    FullDescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Memo = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    Entrys = table.Column<int>(type: "int", nullable: false),
                    Devolutions = table.Column<int>(type: "int", nullable: false),
                    Egresses = table.Column<int>(type: "int", nullable: false),
                    AmountAdjustments = table.Column<int>(type: "int", nullable: false),
                    PriceAdjustments = table.Column<int>(type: "int", nullable: false),
                    EncapsulationTypeId = table.Column<int>(type: "int", nullable: true),
                    MountingTechnologyId = table.Column<int>(type: "int", nullable: true),
                    ManufacturerId = table.Column<int>(type: "int", nullable: true),
                    UnitTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_EncapsulationTypes_EncapsulationTypeId",
                        column: x => x.EncapsulationTypeId,
                        principalTable: "EncapsulationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Products_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Products_MountingTechnologies_MountingTechnologyId",
                        column: x => x.MountingTechnologyId,
                        principalTable: "MountingTechnologies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Products_UnitTypes_UnitTypeId",
                        column: x => x.UnitTypeId,
                        principalTable: "UnitTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => new { x.CategoryId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductChangelogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: true),
                    PreviousAmount = table.Column<int>(type: "int", nullable: true),
                    NewAmount = table.Column<int>(type: "int", nullable: true),
                    PurchasePrice = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: true),
                    OldProvider = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    ProviderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductChangelogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductChangelogs_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_ProductChangelogs_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductChangelogs_Providers_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "Providers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "ProductRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductRequests_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_ProductRequests_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    ProviderId = table.Column<int>(type: "int", nullable: true),
                    OrderReference = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LocationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SellerId = table.Column<int>(type: "int", nullable: true),
                    ArrivalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PetitionerId = table.Column<int>(type: "int", nullable: true),
                    InternalReference = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RequestedAmount = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    MountingTechnology = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    EncapsulationType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Priority = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    OriginalProductPirce = table.Column<decimal>(type: "decimal(8,6)", precision: 8, scale: 6, nullable: true),
                    IvaIncluded = table.Column<bool>(type: "bit", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ExtraCost = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: false),
                    ProductPriceWithIva = table.Column<decimal>(type: "decimal(8,6)", precision: 8, scale: 6, nullable: true),
                    SubTotal = table.Column<decimal>(type: "decimal(8,6)", precision: 8, scale: 6, nullable: false),
                    ProductUrl = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCart_Employees_PetitionerId",
                        column: x => x.PetitionerId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ShoppingCart_Employees_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_ShoppingCart_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_ShoppingCart_Providers_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "Providers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Manufacturers_Id",
                table: "Manufacturers",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_CategoryId",
                table: "ProductCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_ProductId",
                table: "ProductCategories",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductChangelogs_EmployeeId",
                table: "ProductChangelogs",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductChangelogs_ProductId",
                table: "ProductChangelogs",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductChangelogs_ProviderId",
                table: "ProductChangelogs",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductRequests_EmployeeId",
                table: "ProductRequests",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductRequests_ProductId",
                table: "ProductRequests",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_EncapsulationTypeId",
                table: "Products",
                column: "EncapsulationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ManufacturerId",
                table: "Products",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_MountingTechnologyId",
                table: "Products",
                column: "MountingTechnologyId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_UnitTypeId",
                table: "Products",
                column: "UnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Providers_Id",
                table: "Providers",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCart_PetitionerId",
                table: "ShoppingCart",
                column: "PetitionerId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCart_ProductId",
                table: "ShoppingCart",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCart_ProviderId",
                table: "ShoppingCart",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCart_SellerId",
                table: "ShoppingCart",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitTypes_Id",
                table: "UnitTypes",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "ProductChangelogs");

            migrationBuilder.DropTable(
                name: "ProductRequests");

            migrationBuilder.DropTable(
                name: "ShoppingCart");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Providers");

            migrationBuilder.DropTable(
                name: "EncapsulationTypes");

            migrationBuilder.DropTable(
                name: "Manufacturers");

            migrationBuilder.DropTable(
                name: "MountingTechnologies");

            migrationBuilder.DropTable(
                name: "UnitTypes");
        }
    }
}
