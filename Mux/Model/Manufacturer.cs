using System.Collections.Generic;

namespace Mux.Model;

public class Manufacturer
{
	public int Id { get; set; }
	public string BusinessName { get; set; }
	public List<Product> Products { get; set; }

	public Manufacturer()
	{
		Id = 0;
		BusinessName = "";
		Products = new List<Product>();
	}
}
