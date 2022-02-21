using Microsoft.EntityFrameworkCore;
using Mux.Model;

namespace Mux.NavigationProperty
{
	internal class EncapsulationTypeNavigationProperty : NavigationPropertyConfiguration
	{
		public void Configure(ref ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<EncapsulationType>()
				.Navigation(encapsulationType => encapsulationType.Products)
				.UsePropertyAccessMode(PropertyAccessMode.Property);
		}
	}
}
