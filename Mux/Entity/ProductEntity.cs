using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mux.Model;

namespace Mux.Entity
{
	internal class ProductEntity : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			builder.HasKey(product => product.Id);

			builder
				.Property(product => product.Id)
				.ValueGeneratedNever();

			builder.Property(product => product.IsManualProfit);

			builder.Property(product => product.IsUsingInventory);

			builder.Property(product => product.CurrentAmount);

			builder.Property(product => product.MaxAmount);

			builder.Property(product => product.MinAmount);

			builder.Property(product => product.Entrys);

			builder.Property(product => product.Devolutions);

			builder.Property(product => product.Egresses);

			builder.Property(product => product.AmountAdjustments);

			builder.Property(product => product.PriceAdjustments);

			builder
				.Property(product => product.BuyPrice)
				.HasPrecision(6, 2);

			builder
				.Property(product => product.PercentageOfDiscount)
				.HasPrecision(6, 2);

			builder
				.Property(product => product.PercentageOfProfit)
				.HasPrecision(6, 2);

			builder
				.Property(product => product.SalePriceWithDiscount)
				.HasPrecision(6, 2);

			builder
				.Property(product => product.SalePriceWithoutDiscount)
				.HasPrecision(6, 2);

			builder
				.Property(product => product.ProfitWithoutDiscount)
				.HasPrecision(6, 2);

			builder
				.Property(product => product.ProfitWithDiscount)
				.HasPrecision(6, 2);

			builder
				.Property(product => product.Category)
				.HasMaxLength(50)
				.IsUnicode();

			builder
				.Property(product => product.DebugCode)
				.HasMaxLength(30)
				.IsUnicode();

			builder
				.Property(product => product.Container)
				.HasMaxLength(60)
				.IsUnicode();

			builder
				.Property(product => product.FullDescription)
				.HasComputedColumnSql("[Id] + ' - ' + [OldManufacturer] + ', ' + [Enrollment] + ', ' + [ShortDescription] + ', ' + [OldMountingTechnology] + ', ' + [OldEncapsulationType]")
				.IsUnicode();

			builder
				.Property(product => product.ShortDescription)
				.HasMaxLength(200)
				.IsUnicode();

			builder
				.Property(product => product.Rack)
				.HasMaxLength(10)
				.IsUnicode();

			builder
				.Property(product => product.OldEncapsulationType)
				.HasMaxLength(20)
				.IsUnicode();

			builder
				.Property(product => product.Status)
				.HasMaxLength(10)
				.IsUnicode();

			builder
				.Property(product => product.Enrollment)
				.HasMaxLength(60)
				.IsUnicode();

			builder
				.Property(product => product.Memo)
				.HasMaxLength(70)
				.IsUnicode();

			builder
				.Property(product => product.PartNumber)
				.HasMaxLength(30)
				.IsUnicode();

			builder
				.Property(product => product.OldManufacturer)
				.HasMaxLength(50)
				.IsUnicode();

			builder
				.Property(product => product.Shelf)
				.HasMaxLength(10)
				.IsUnicode();

			builder
				.Property(product => product.BranchOffice)
				.HasMaxLength(10)
				.IsUnicode();

			builder
				.Property(product => product.OldMountingTechnology)
				.HasMaxLength(16)
				.IsUnicode();

			builder
				.Property(product => product.TypeOfStock)
				.HasMaxLength(20)
				.IsUnicode();

			builder
				.Property(product => product.Location)
				.HasMaxLength(40)
				.IsUnicode();

			builder
				.Property(product => product.OldUnitType)
				.HasMaxLength(10)
				.IsUnicode();
		}
	}
}
