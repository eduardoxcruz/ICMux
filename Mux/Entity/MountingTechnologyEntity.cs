using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mux.Model;

namespace Mux.Entity;

internal class MountingTechnologyEntity : IEntityTypeConfiguration<MountingTechnology>
{
	public void Configure(EntityTypeBuilder<MountingTechnology> builder)
	{
		builder.HasKey(mountingTechnology => mountingTechnology.Id);

		builder.Property(mountingTechnology => mountingTechnology.Id).ValueGeneratedOnAdd();

		builder.Property(m => m.Name).HasMaxLength(30).IsUnicode();
	}
}
