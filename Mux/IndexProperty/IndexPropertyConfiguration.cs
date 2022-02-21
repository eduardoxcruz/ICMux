using Microsoft.EntityFrameworkCore;

namespace Mux.IndexProperty
{
	internal interface IndexPropertyConfiguration
	{
		void Configure(ref ModelBuilder modelBuilder);
	}
}
