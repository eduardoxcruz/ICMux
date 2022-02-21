using Microsoft.EntityFrameworkCore;
using Mux.Model;

namespace Mux.IndexProperty
{
	internal class ProductChangelogIndexProperty : IndexPropertyConfiguration
	{
		public void Configure(ref ModelBuilder modelBuilder)
		{
			modelBuilder
				.Entity<ProductChangelog>()
				.HasIndex(recordOfProductMovement => recordOfProductMovement.ProductId)
				.IsUnique(false);

			modelBuilder
				.Entity<ProductChangelog>()
				.HasIndex(recordOfProductMovement => recordOfProductMovement.EmployeeId)
				.IsUnique(false);
		}
	}
}
