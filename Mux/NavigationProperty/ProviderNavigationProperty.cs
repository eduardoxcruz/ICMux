using Microsoft.EntityFrameworkCore;
using Mux.Model;

namespace Mux.NavigationProperty;

public class ProviderNavigationProperty : NavigationPropertyConfiguration
{
	public void Configure(ref ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Provider>()
			.Navigation(provider => provider.ProductChangelogs)
			.UsePropertyAccessMode(PropertyAccessMode.Property);
		
		modelBuilder.Entity<Provider>()
			.Navigation(provider => provider.ShoppingCart)
			.UsePropertyAccessMode(PropertyAccessMode.Property);
	}
}
