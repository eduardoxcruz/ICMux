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
		}
	}
}
