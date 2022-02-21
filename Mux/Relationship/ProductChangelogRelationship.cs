using Microsoft.EntityFrameworkCore;
using Mux.Model;

namespace Mux.Relationship
{
	internal class ProductChangelogRelationship : RelationshipConfiguration
	{
		public void Configure(ref ModelBuilder modelBuilder)
		{
			modelBuilder
				.Entity<ProductChangelog>()
				.HasOne(recordOfProductMovement => recordOfProductMovement.Product)
				.WithMany(product => product.ProductChangeLogs)
				.HasForeignKey(recordOfProductMovement => recordOfProductMovement.ProductId)
				.OnDelete(DeleteBehavior.Cascade);

			modelBuilder
				.Entity<ProductChangelog>()
				.HasOne(recordOfProductMovement => recordOfProductMovement.Employee)
				.WithMany(employee => employee.ProductChangelogs)
				.HasForeignKey(recordOfProductMovement => recordOfProductMovement.EmployeeId)
				.OnDelete(DeleteBehavior.SetNull);
		}
	}
}
