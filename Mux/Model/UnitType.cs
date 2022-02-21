using System.Collections.Generic;

namespace Mux.Model;

public class UnitType
{
	public int Id { get; set; }
	public string Name { get; set; }
	public List<Product> Products { get; set; }

	public UnitType()
	{
		Id = 0;
		Name = "";
	}
}
