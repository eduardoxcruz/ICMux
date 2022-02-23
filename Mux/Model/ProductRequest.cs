using System;

#nullable enable

namespace Mux.Model
{
	public class ProductRequest
	{
		public int Id { get; set; }
		public DateTime Date { get; set; }
		public int Amount { get; set; }
		public string Type { get; set; }
		public string Status { get; set; }
		public Employee? Employee { get; set; }
		public int? EmployeeId { get; set; }
		public Product? Product { get; set; }
		public int? ProductId { get; set; }
		
		public ProductRequest()
		{
			Id = 0;
			Date = DateTime.Now;
			Amount = 0;
			Type = "";
			Status = "";
		}
	}
}
