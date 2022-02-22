using System.Collections.Generic;

namespace Mux.Model;

public class MountingTechnology
{
	public int Id { get; set; }
	public string Name { get; set; }
	public List<Product> Products { get; set; }

	public MountingTechnology()
	{
		Id = 0;
		Name = "";
		Products = new List<Product>();
	}
}
