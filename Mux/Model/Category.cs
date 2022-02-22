using System.Collections.Generic;

namespace Mux.Model
{
	public class Category
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public List<Product> Products { get; set; }

		public Category()
		{
			Id = 0;
			Name = "N/A";
			Products = new List<Product>();
		}
	}
}
