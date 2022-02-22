using System.Collections.Generic;

namespace Mux.Model
{
	public class Employee
	{
#pragma warning disable 8632
		public int Id { get; set; }
		public string Type { get; set; }
		public string FullName { get; set; }
		public string Password { get; set; }
		public List<ProductToBuy> ShoppingCart { get; set; }
		public List<ProductRequest> ProductRequests { get; set; }
		public List<ProductChangelog> ProductChangelogs { get; set; }
#pragma warning restore 8632
		
		public Employee()
		{
			Id = 0;
			Type = "";
			FullName = "";
			Password = "";
		}
	}
}
