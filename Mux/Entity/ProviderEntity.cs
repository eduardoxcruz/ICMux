using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mux.Model;

namespace Mux.Entity;

internal class ProviderEntity : IEntityTypeConfiguration<Provider>
{
	public void Configure(EntityTypeBuilder<Provider> builder)
	{
		builder.HasIndex(provider => provider.Id);

		builder.Property(provider => provider.Id).ValueGeneratedOnAdd();

		builder.Property(provider => provider.BusinessName).HasMaxLength(50).IsUnicode();
	}
}
