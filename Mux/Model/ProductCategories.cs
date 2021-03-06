namespace Mux.Model;

#nullable enable

public class ProductCategories
{
	public int? ProductId { get; set; }
	public Product? Product { get; set; }
	public int? CategoryId { get; set; }
	public Category? Category { get; set; }
}
