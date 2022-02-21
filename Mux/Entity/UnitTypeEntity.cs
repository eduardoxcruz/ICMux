using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mux.Model;

namespace Mux.Entity;

internal class UnitTypeEntity : IEntityTypeConfiguration<UnitType>
{
	public void Configure(EntityTypeBuilder<UnitType> builder)
	{
		builder.HasIndex(unitType => unitType.Id);

		builder.Property(unitType => unitType.Id).ValueGeneratedOnAdd();

		builder.Property(unitType => unitType.Name).HasMaxLength(30).IsUnicode();
	}
}
