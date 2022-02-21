using Microsoft.EntityFrameworkCore;

namespace Mux.NavigationProperty
{
	internal interface NavigationPropertyConfiguration
	{
		void Configure(ref ModelBuilder modelBuilder);
	}
}
