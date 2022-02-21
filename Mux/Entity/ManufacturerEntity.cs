using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mux.Model;

namespace Mux.Entity;

internal class ManufacturerEntity : IEntityTypeConfiguration<Manufacturer>
{
	public void Configure(EntityTypeBuilder<Manufacturer> builder)
	{
		builder.HasIndex(manufacturer => manufacturer.Id);

		builder.Property(m => m.Id).ValueGeneratedOnAdd();

		builder.Property(m => m.BusinessName).HasMaxLength(50).IsUnicode();
	}
}
