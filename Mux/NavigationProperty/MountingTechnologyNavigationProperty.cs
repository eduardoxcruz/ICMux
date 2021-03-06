using Microsoft.EntityFrameworkCore;
using Mux.Model;

namespace Mux.NavigationProperty;

internal class MountingTechnologyNavigationProperty : NavigationPropertyConfiguration
{
	public void Configure(ref ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<MountingTechnology>()
			.Navigation(mountingTechnology => mountingTechnology.Products)
			.UsePropertyAccessMode(PropertyAccessMode.Property);
	}
}
