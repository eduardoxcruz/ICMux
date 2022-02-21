using Microsoft.EntityFrameworkCore;
using Mux.Model;

namespace Mux.IndexProperty
{
	internal class ProductToBuyIndexProperty : IndexPropertyConfiguration
	{
		public void Configure(ref ModelBuilder modelBuilder)
		{
			modelBuilder
				.Entity<ProductToBuy>()
				.HasIndex(productForBuy => productForBuy.ProductId)
				.IsUnique(false);

			modelBuilder
				.Entity<ProductToBuy>()
				.HasIndex(productForBuy => productForBuy.EmployeeId)
				.IsUnique(false);
		}
	}
}
