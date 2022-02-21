using Microsoft.EntityFrameworkCore;
using Mux.Model;

namespace Mux.NavigationProperty
{
	internal class EmployeeNavigationProperty : NavigationPropertyConfiguration
	{
		public void Configure(ref ModelBuilder modelBuilder)
		{
			modelBuilder
				.Entity<Employee>()
				.Navigation(employee => employee.ShoppingCart)
				.UsePropertyAccessMode(PropertyAccessMode.Property);

			modelBuilder
				.Entity<Employee>()
				.Navigation(employee => employee.ProductRequests)
				.UsePropertyAccessMode(PropertyAccessMode.Property);
			
			modelBuilder
				.Entity<Employee>()
				.Navigation(employee => employee.ProductChangelogs)
				.UsePropertyAccessMode(PropertyAccessMode.Property);
		}
	}
}
