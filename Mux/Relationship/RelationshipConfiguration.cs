using Microsoft.EntityFrameworkCore;

namespace Mux.Relationship
{
	internal interface RelationshipConfiguration
	{
		void Configure(ref ModelBuilder modelBuilder);
	}
}
