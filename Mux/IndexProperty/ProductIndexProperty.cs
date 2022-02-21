using Microsoft.EntityFrameworkCore;
using Mux.Model;

namespace Mux.IndexProperty
{
	internal class ProductIndexProperty : IndexPropertyConfiguration
	{
		public void Configure(ref ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>()
				.HasIndex(product => product.EncapsulationTypeId)
				.IsUnique(false);

			modelBuilder.Entity<Product>()
				.HasIndex(product => product.MountingTechnologyId)
				.IsUnique(false);

			modelBuilder.Entity<Product>()
				.HasIndex(product => product.ManufacturerId)
				.IsUnique(false);

			modelBuilder.Entity<Product>()
				.HasIndex(product => product.UnitTypeId)
				.IsUnique(false);
		}
	}
}
