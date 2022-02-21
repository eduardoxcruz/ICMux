﻿namespace Mux.Model
{
	public class Category
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public List<Product> Products { get; set; }

		public Category()
		{
			Id = 0;
			Name = "";
		}
	}
}
