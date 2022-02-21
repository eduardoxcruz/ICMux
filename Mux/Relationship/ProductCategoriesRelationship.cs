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
				.UsingEntity<Dictionary<string, object>>(
					"ProductCategories",
					entityTypeBuilder => entityTypeBuilder
						.HasOne<Category>()
						.WithMany()
						.HasForeignKey("CategoryId")
						.HasConstraintName("FK_ProductCategories_Categories_CategoryId")
						.OnDelete(DeleteBehavior.ClientSetNull),
					entityTypeBuilder => entityTypeBuilder
						.HasOne<Product>()
						.WithMany()
						.HasForeignKey("ProductId")
						.HasConstraintName("FK_ProductCategories_Products_ProductId")
						.OnDelete(DeleteBehavior.ClientSetNull)
				);
		}
	}
}
