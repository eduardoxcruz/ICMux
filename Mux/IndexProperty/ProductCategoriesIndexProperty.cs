using Microsoft.EntityFrameworkCore;
using Mux.Model;

namespace Mux.IndexProperty;

internal class ProductCategoriesIndexProperty : IndexPropertyConfiguration
{
	public void Configure(ref ModelBuilder modelBuilder)
	{
		modelBuilder
			.Entity<ProductCategories>()
			.HasIndex(productCategories => productCategories.ProductId)
			.IsUnique(false);
		
		modelBuilder
			.Entity<ProductCategories>()
			.HasIndex(productCategories => productCategories.CategoryId)
			.IsUnique(false);
	}
}
