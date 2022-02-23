using Microsoft.EntityFrameworkCore;
using Mux.Model;

namespace Mux.Relationship
{
	internal class ProductCategoriesRelationship : RelationshipConfiguration
	{
		public void Configure(ref ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>()
				.HasMany(product => product.Categories)
				.WithMany(category => category.Products)
				.UsingEntity<ProductCategories>(
					entityTypeBuilder => entityTypeBuilder
						.HasOne(productCategories => productCategories.Category)
						.WithMany(category => category.ProductCategories)
						.HasForeignKey(productCategories => productCategories.CategoryId)
						.OnDelete(DeleteBehavior.Cascade),
					entityTypeBuilder => entityTypeBuilder
						.HasOne(productCategories => productCategories.Product)
						.WithMany(product => product.ProductCategories)
						.HasForeignKey(productCategories => productCategories.ProductId)
						.OnDelete(DeleteBehavior.Cascade)
				);
		}
	}
}
