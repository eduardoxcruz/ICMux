using Microsoft.EntityFrameworkCore;
using Mux.Entity;
using Mux.IndexProperty;
using Mux.Model;
using Mux.NavigationProperty;
using Mux.Relationship;

namespace Mux;

public class ICContext : DbContext
{
	private readonly string _connectionString;

	public virtual DbSet<ProductToBuy> ShoppingCart { get; set; }
	public virtual DbSet<ProductChangelog> ProductChangelogs { get; set; }
	public virtual DbSet<Product> Products { get; set; }
	public virtual DbSet<ProductRequest> ProductRequests { get; set; }
	public virtual DbSet<Employee> Employees { get; set; }
	public virtual DbSet<Category> Categories { get; set; }
	public virtual DbSet<EncapsulationType> EncapsulationTypes { get; set; }
	public virtual DbSet<MountingTechnology> MountingTechnologies { get; set; }
	public virtual DbSet<Provider> Providers { get; set; }
	public virtual DbSet<Manufacturer> Manufacturers { get; set; }
	public virtual DbSet<UnitType> UnitTypes { get; set; }
	public virtual DbSet<ProductCategories> ProductCategories { get; set; }

	public ICContext()
	{
		_connectionString = "Server=192.168.0.254;Database=Testing;User Id=sa;Password=Tlacua015;";
	}

	public ICContext(string connectionString)
	{
		_connectionString = connectionString;
	}

	public ICContext(DbContextOptions<ICContext> options) : base(options) {}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer(_connectionString);
		optionsBuilder.EnableDetailedErrors();
		optionsBuilder.EnableSensitiveDataLogging();
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

		StartEntityTypesConfiguration(ref modelBuilder);
		StartRelationshipsConfiguration(ref modelBuilder);
		StartNavigationPropertiesConfiguration(ref modelBuilder);
		StartIndexPropertiesConfiguration(ref modelBuilder);
	}

	private static void StartEntityTypesConfiguration(ref ModelBuilder modelBuilder)
	{
		new ProductToBuyEntity().Configure(modelBuilder.Entity<ProductToBuy>());
		new ProductChangelogEntity().Configure(modelBuilder.Entity<ProductChangelog>());
		new ProductEntity().Configure(modelBuilder.Entity<Product>());
		new ProductRequestEntity().Configure(modelBuilder.Entity<ProductRequest>());
		new EmployeeEntity().Configure(modelBuilder.Entity<Employee>());
		new CategoryEntity().Configure(modelBuilder.Entity<Category>());
		new EncapsulationTypeEntity().Configure(modelBuilder.Entity<EncapsulationType>());
		new MountingTechnologyEntity().Configure(modelBuilder.Entity<MountingTechnology>());
		new ProviderEntity().Configure(modelBuilder.Entity<Provider>());
		new ManufacturerEntity().Configure(modelBuilder.Entity<Manufacturer>());
		new UnitTypeEntity().Configure(modelBuilder.Entity<UnitType>());
	}

	private static void StartRelationshipsConfiguration(ref ModelBuilder modelBuilder)
	{
		new ProductCategoriesRelationship().Configure(ref modelBuilder);
		new ProductChangelogRelationship().Configure(ref modelBuilder);
		new ProductRequestRelationship().Configure(ref modelBuilder);
		new ShoppingCartRelationship().Configure(ref modelBuilder);
		new ProductRelationship().Configure(ref modelBuilder);
	}

	private static void StartNavigationPropertiesConfiguration(ref ModelBuilder modelBuilder)
	{
		new ManufacturerNavigationProperty().Configure(ref modelBuilder);
		new ProviderNavigationProperty().Configure(ref modelBuilder);
		new ProductNavigationProperty().Configure(ref modelBuilder);
		new EmployeeNavigationProperty().Configure(ref modelBuilder);
		new EncapsulationTypeNavigationProperty().Configure(ref modelBuilder);
		new MountingTechnologyNavigationProperty().Configure(ref modelBuilder);
		new UnitTypeNavigationProperty().Configure(ref modelBuilder);
	}

	private static void StartIndexPropertiesConfiguration(ref ModelBuilder modelBuilder)
	{
		new ProductChangelogIndexProperty().Configure(ref modelBuilder);
		new ProductRequestIndexProperty().Configure(ref modelBuilder);
		new ProductToBuyIndexProperty().Configure(ref modelBuilder);
		new ProductIndexProperty().Configure(ref modelBuilder);
		new ProductCategoriesIndexProperty().Configure(ref modelBuilder);
	}
}
