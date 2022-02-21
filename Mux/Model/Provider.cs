using System.Collections.Generic;

namespace Mux.Model;

public class Provider
{
	public int Id { get; set; }
	public string BusinessName { get; set; }
	public List<ProductChangelog> ProductChangelogs { get; set; }
	public List<ProductToBuy> ShoppingCart { get; set; }

	public Provider()
	{
		Id = 0;
		BusinessName = "";
	}
}
