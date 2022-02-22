﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mux;

#nullable disable

namespace Mux.Migrations
{
    [DbContext(typeof(ICContext))]
    [Migration("20220222164204_AddLocationDateColumn")]
    partial class AddLocationDateColumn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("Modern_Spanish_CI_AS")
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Mux.Model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Mux.Model.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FullName")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Password")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Type")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Mux.Model.EncapsulationType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BodyWidth")
                        .HasMaxLength(30)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("FullDescription")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("nvarchar(max)")
                        .HasComputedColumnSql("[Name] + ', ' + [BodyWidth]", true);

                    b.Property<string>("Name")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.ToTable("EncapsulationTypes");
                });

            modelBuilder.Entity("Mux.Model.Manufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BusinessName")
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("Manufacturers");
                });

            modelBuilder.Entity("Mux.Model.MountingTechnology", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasMaxLength(30)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("MountingTechnologies");
                });

            modelBuilder.Entity("Mux.Model.Product", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("AmountAdjustments")
                        .HasColumnType("int");

                    b.Property<string>("BranchOffice")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<decimal?>("BuyPrice")
                        .HasPrecision(6, 2)
                        .HasColumnType("decimal(6,2)");

                    b.Property<string>("Category")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Container")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)");

                    b.Property<int?>("CurrentAmount")
                        .HasColumnType("int");

                    b.Property<string>("DebugCode")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<int>("Devolutions")
                        .HasColumnType("int");

                    b.Property<int>("Egresses")
                        .HasColumnType("int");

                    b.Property<int>("EncapsulationTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Enrollment")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)");

                    b.Property<int>("Entrys")
                        .HasColumnType("int");

                    b.Property<string>("FullDescription")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<bool?>("IsManualProfit")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsUsingInventory")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)");

                    b.Property<int>("ManufacturerId")
                        .HasColumnType("int");

                    b.Property<int?>("MaxAmount")
                        .HasColumnType("int");

                    b.Property<string>("Memo")
                        .HasMaxLength(70)
                        .IsUnicode(false)
                        .HasColumnType("varchar(70)");

                    b.Property<int?>("MinAmount")
                        .HasColumnType("int");

                    b.Property<int>("MountingTechnologyId")
                        .HasColumnType("int");

                    b.Property<string>("OldEncapsulationType")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("OldManufacturer")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("OldMountingTechnology")
                        .HasMaxLength(16)
                        .IsUnicode(false)
                        .HasColumnType("varchar(16)");

                    b.Property<string>("OldUnitType")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("PartNumber")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<decimal?>("PercentageOfDiscount")
                        .HasPrecision(6, 2)
                        .HasColumnType("decimal(6,2)");

                    b.Property<decimal?>("PercentageOfProfit")
                        .HasPrecision(6, 2)
                        .HasColumnType("decimal(6,2)");

                    b.Property<int>("PriceAdjustments")
                        .HasColumnType("int");

                    b.Property<decimal?>("ProfitWithDiscount")
                        .HasPrecision(6, 2)
                        .HasColumnType("decimal(6,2)");

                    b.Property<decimal?>("ProfitWithoutDiscount")
                        .HasPrecision(6, 2)
                        .HasColumnType("decimal(6,2)");

                    b.Property<string>("Rack")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<decimal?>("SalePriceWithDiscount")
                        .HasPrecision(6, 2)
                        .HasColumnType("decimal(6,2)");

                    b.Property<decimal?>("SalePriceWithoutDiscount")
                        .HasPrecision(6, 2)
                        .HasColumnType("decimal(6,2)");

                    b.Property<string>("Shelf")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("ShortDescription")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Status")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("TypeOfStock")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<int>("UnitTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EncapsulationTypeId");

                    b.HasIndex("ManufacturerId");

                    b.HasIndex("MountingTechnologyId");

                    b.HasIndex("UnitTypeId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Mux.Model.ProductChangelog", b =>
                {
                    b.Property<int?>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeName")
                        .HasMaxLength(35)
                        .IsUnicode(false)
                        .HasColumnType("varchar(35)");

                    b.Property<int?>("NewAmount")
                        .HasColumnType("int");

                    b.Property<string>("OldProvider")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("PreviousAmount")
                        .HasColumnType("int");

                    b.Property<string>("ProductFullDescription")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("ProviderId")
                        .HasColumnType("int");

                    b.Property<decimal?>("PurchasePrice")
                        .HasPrecision(6, 2)
                        .HasColumnType("decimal(6,2)");

                    b.Property<string>("Type")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProviderId");

                    b.ToTable("ProductChangeLogs");
                });

            modelBuilder.Entity("Mux.Model.ProductRequest", b =>
                {
                    b.Property<int?>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeName")
                        .HasMaxLength(35)
                        .IsUnicode(false)
                        .HasColumnType("varchar(35)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasMaxLength(35)
                        .IsUnicode(false)
                        .HasColumnType("varchar(35)");

                    b.Property<string>("Type")
                        .HasMaxLength(35)
                        .IsUnicode(false)
                        .HasColumnType("varchar(35)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductRequests");
                });

            modelBuilder.Entity("Mux.Model.ProductToBuy", b =>
                {
                    b.Property<int?>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LocationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OldProvider")
                        .HasMaxLength(35)
                        .IsUnicode(false)
                        .HasColumnType("varchar(35)");

                    b.Property<string>("OrderReference")
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("ProviderId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("RequestDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RequestedAmount")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProviderId");

                    b.ToTable("ShoppingCart");
                });

            modelBuilder.Entity("Mux.Model.Provider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BusinessName")
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("Providers");
                });

            modelBuilder.Entity("Mux.Model.UnitType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasMaxLength(30)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("UnitTypes");
                });

            modelBuilder.Entity("ProductCategories", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("Mux.Model.Product", b =>
                {
                    b.HasOne("Mux.Model.EncapsulationType", "EncapsulationType")
                        .WithMany("Products")
                        .HasForeignKey("EncapsulationTypeId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("Mux.Model.Manufacturer", "Manufacturer")
                        .WithMany("Products")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mux.Model.MountingTechnology", "MountingTechnology")
                        .WithMany("Products")
                        .HasForeignKey("MountingTechnologyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mux.Model.UnitType", "UnitType")
                        .WithMany("Products")
                        .HasForeignKey("UnitTypeId")
                        .IsRequired();

                    b.Navigation("EncapsulationType");

                    b.Navigation("Manufacturer");

                    b.Navigation("MountingTechnology");

                    b.Navigation("UnitType");
                });

            modelBuilder.Entity("Mux.Model.ProductChangelog", b =>
                {
                    b.HasOne("Mux.Model.Employee", "Employee")
                        .WithMany("ProductChangelogs")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Mux.Model.Product", "Product")
                        .WithMany("ProductChangeLogs")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Mux.Model.Provider", "Provider")
                        .WithMany("ProductChangelogs")
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Employee");

                    b.Navigation("Product");

                    b.Navigation("Provider");
                });

            modelBuilder.Entity("Mux.Model.ProductRequest", b =>
                {
                    b.HasOne("Mux.Model.Employee", "Employee")
                        .WithMany("ProductRequests")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Mux.Model.Product", "Product")
                        .WithMany("ProductRequests")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Employee");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Mux.Model.ProductToBuy", b =>
                {
                    b.HasOne("Mux.Model.Employee", "Employee")
                        .WithMany("ShoppingCart")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Mux.Model.Product", "Product")
                        .WithMany("ShoppingCart")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Mux.Model.Provider", "Provider")
                        .WithMany("ShoppingCart")
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Employee");

                    b.Navigation("Product");

                    b.Navigation("Provider");
                });

            modelBuilder.Entity("ProductCategories", b =>
                {
                    b.HasOne("Mux.Model.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .IsRequired()
                        .HasConstraintName("FK_ProductCategories_Categories_CategoryId");

                    b.HasOne("Mux.Model.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("FK_ProductCategories_Products_ProductId");
                });

            modelBuilder.Entity("Mux.Model.Employee", b =>
                {
                    b.Navigation("ProductChangelogs");

                    b.Navigation("ProductRequests");

                    b.Navigation("ShoppingCart");
                });

            modelBuilder.Entity("Mux.Model.EncapsulationType", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Mux.Model.Manufacturer", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Mux.Model.MountingTechnology", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Mux.Model.Product", b =>
                {
                    b.Navigation("ProductChangeLogs");

                    b.Navigation("ProductRequests");

                    b.Navigation("ShoppingCart");
                });

            modelBuilder.Entity("Mux.Model.Provider", b =>
                {
                    b.Navigation("ProductChangelogs");

                    b.Navigation("ShoppingCart");
                });

            modelBuilder.Entity("Mux.Model.UnitType", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
