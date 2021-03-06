using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mux.Model;

namespace Mux.Entity
{
	internal class ProductChangelogEntity : IEntityTypeConfiguration<ProductChangelog>
	{
		public void Configure(EntityTypeBuilder<ProductChangelog> builder)
		{
			builder.HasKey(recordOfProductMovement => recordOfProductMovement.Id);

			builder
				.Property(recordOfProductMovement => recordOfProductMovement.Id)
				.ValueGeneratedOnAdd();

			builder.Property(recordOfProductMovement => recordOfProductMovement.Amount);

			builder.Property(recordOfProductMovement => recordOfProductMovement.PreviousAmount);

			builder.Property(recordOfProductMovement => recordOfProductMovement.NewAmount);

			builder.Property(recordOfProductMovement => recordOfProductMovement.Date);

			builder
				.Property(recordOfProductMovement => recordOfProductMovement.PurchasePrice)
				.HasPrecision(6, 2);

			builder.Property(recordOfProductMovement => recordOfProductMovement.OldProvider)
				.HasMaxLength(50)
				.IsUnicode(false);

			builder.Property(recordOfProductMovement => recordOfProductMovement.Type)
				.HasMaxLength(10)
				.IsUnicode();
		}
	}
}
