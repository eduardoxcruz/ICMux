using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mux.Model;

namespace Mux.Entity
{
	internal class ProductToBuyEntity : IEntityTypeConfiguration<ProductToBuy>
	{
		public void Configure(EntityTypeBuilder<ProductToBuy> builder)
		{
			builder.HasKey(productForBuy => productForBuy.Id);

			builder
				.Property(productForBuy => productForBuy.Id)
				.ValueGeneratedOnAdd();

			builder
				.Property(productForBuy => productForBuy.Status)
				.HasMaxLength(30)
				.IsUnicode(false);
			
			builder.Property(productToBuy => productToBuy.OrderReference)
				.HasMaxLength(50)
				.IsUnicode();

			builder.Property(productToBuy => productToBuy.LocationDate);

			builder.Property(productToBuy => productToBuy.ArrivalDate);

			builder.Property(productToBuy => productToBuy.Comments)
				.HasMaxLength(100)
				.IsUnicode();

			builder.Property(productToBuy => productToBuy.RequestDate);

			builder.Property(productToBuy => productToBuy.InternalReference)
				.HasMaxLength(50)
				.IsUnicode();

			builder.Property(productToBuy => productToBuy.ProductDescription)
				.HasMaxLength(100)
				.IsUnicode();

			builder.Property(productForBuy => productForBuy.RequestedAmount);
			
			builder.Property(productToBuy => productToBuy.MountingTechnology)
				.HasMaxLength(30)
				.IsUnicode();
			
			builder.Property(productToBuy => productToBuy.EncapsulationType)
				.HasMaxLength(50)
				.IsUnicode();
			
			builder.Property(productToBuy => productToBuy.Priority)
				.HasMaxLength(30)
				.IsUnicode();
			
			builder.Property(productToBuy => productToBuy.OriginalProductPirce)
				.HasPrecision(8, 6)
				.IsUnicode();
			
			builder.Property(productToBuy => productToBuy.IvaIncluded);
			
			builder.Property(productToBuy => productToBuy.Currency)
				.HasMaxLength(10)
				.IsUnicode();
			
			builder.Property(productToBuy => productToBuy.ExtraCost)
				.HasPrecision(6, 2)
				.IsUnicode();
			
			builder.Property(productToBuy => productToBuy.ProductPriceWithIva)
				.HasPrecision(8, 6)
				.IsUnicode();
			
			builder.Property(productToBuy => productToBuy.SubTotal)
				.HasPrecision(8, 6)
				.IsUnicode();
			
			builder.Property(productToBuy => productToBuy.ProductUrl)
				.HasMaxLength(100)
				.IsUnicode();
		}
	}
}
