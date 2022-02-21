using System.Collections.Generic;

namespace Mux.Model;

public class Manufacturer
{
	public int Id { get; set; }
	public string BusinessName { get; set; }
	public List<Product> Products { get; set; }
}
