using Microsoft.EntityFrameworkCore;
using Mux.Model;

namespace Mux.NavigationProperty;

internal class ManufacturerNavigationProperty : NavigationPropertyConfiguration
{
	public void Configure(ref ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Manufacturer>()
			.Navigation(manufacturer => manufacturer.Products)
			.UsePropertyAccessMode(PropertyAccessMode.Property);
	}
}
