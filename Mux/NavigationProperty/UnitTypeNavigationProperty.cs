using Microsoft.EntityFrameworkCore;
using Mux.Model;

namespace Mux.NavigationProperty;

internal class UnitTypeNavigationProperty : NavigationPropertyConfiguration
{
	public void Configure(ref ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<UnitType>()
			.Navigation(unitType => unitType.Products)
			.UsePropertyAccessMode(PropertyAccessMode.Property);
	}
}
