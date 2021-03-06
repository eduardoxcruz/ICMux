using Microsoft.EntityFrameworkCore;
using Mux.Model;

namespace Mux.Relationship
{
	internal class ProductRelationship : RelationshipConfiguration
	{
		public void Configure(ref ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>()
				.HasOne(product => product.EncapsulationType)
				.WithMany(encapsulationType => encapsulationType.Products)
				.HasForeignKey(product => product.EncapsulationTypeId)
				.OnDelete(DeleteBehavior.SetNull);

			modelBuilder.Entity<Product>()
				.HasOne(product => product.MountingTechnology)
				.WithMany(mountingTechnology => mountingTechnology.Products)
				.HasForeignKey(product => product.MountingTechnologyId)
				.OnDelete(DeleteBehavior.SetNull);

			modelBuilder.Entity<Product>()
				.HasOne(product => product.Manufacturer)
				.WithMany(manufacturer => manufacturer.Products)
				.HasForeignKey(product => product.ManufacturerId)
				.OnDelete(DeleteBehavior.SetNull);

			modelBuilder.Entity<Product>()
				.HasOne(product => product.UnitType)
				.WithMany(unitType => unitType.Products)
				.HasForeignKey(product => product.UnitTypeId)
				.OnDelete(DeleteBehavior.SetNull);
		}
	}
}
