using System.Collections.Generic;

namespace Mux.Model
{
	public class EncapsulationType
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string BodyWidth { get; set; }
		public string FullDescription { get; set; }
		public List<Product> Products { get; set; }

		public EncapsulationType()
		{
			Id = 0;
			Name = "";
			BodyWidth = "";
			FullDescription = "";
		}
	}
}
