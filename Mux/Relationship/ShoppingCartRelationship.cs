using Microsoft.EntityFrameworkCore;
using Mux.Model;

namespace Mux.Relationship
{
	internal class ShoppingCartRelationship : RelationshipConfiguration
	{
		public void Configure(ref ModelBuilder modelBuilder)
		{
			modelBuilder
				.Entity<ProductToBuy>()
				.HasOne(productForBuy => productForBuy.Product)
				.WithMany(product => product.ShoppingCart)
				.HasForeignKey(productForBuy => productForBuy.ProductId)
				.OnDelete(DeleteBehavior.SetNull);

			modelBuilder
				.Entity<ProductToBuy>()
				.HasOne(productForBuy => productForBuy.Seller)
				.WithMany(employee => employee.ShoppingCart)
				.HasForeignKey(productForBuy => productForBuy.SellerId)
				.OnDelete(DeleteBehavior.SetNull);

			modelBuilder
				.Entity<ProductToBuy>()
				.HasOne(productToBuy => productToBuy.Provider)
				.WithMany(provider => provider.ShoppingCart)
				.HasForeignKey(productToBuy => productToBuy.ProviderId)
				.OnDelete(DeleteBehavior.SetNull);
		}
	}
}
