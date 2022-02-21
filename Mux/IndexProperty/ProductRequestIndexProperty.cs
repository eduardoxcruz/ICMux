using Microsoft.EntityFrameworkCore;
using Mux.Model;

namespace Mux.IndexProperty
{
	internal class ProductRequestIndexProperty : IndexPropertyConfiguration
	{
		public void Configure(ref ModelBuilder modelBuilder)
		{
			modelBuilder
				.Entity<ProductRequest>()
				.HasIndex(productRequest => productRequest.ProductId)
				.IsUnique(false);

			modelBuilder
				.Entity<ProductRequest>()
				.HasIndex(productRequest => productRequest.EmployeeId)
				.IsUnique(false);
		}
	}
}
