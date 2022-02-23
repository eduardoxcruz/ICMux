using System.Collections.Generic;

namespace Mux.Model
{
	public class Category
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public ICollection<Product> Products { get; set; }
		public List<ProductCategories> ProductCategories { get; set; }

		public Category()
		{
			Id = 0;
			Name = "";
			Products = new List<Product>();
		}
	}
}
