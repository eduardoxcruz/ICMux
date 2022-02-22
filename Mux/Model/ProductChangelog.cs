using System;

#nullable enable

namespace Mux.Model
{
	public class ProductChangelog
	{
		public int Id { get; set; }
		public DateTime Date { get; set; }
		public string Type { get; set; }
		public int? Amount { get; set; }
		public int? PreviousAmount { get; set; }
		public int? NewAmount { get; set; }
		public decimal? PurchasePrice { get; set; }
		public string OldProvider { get; set; }
		public int? EmployeeId { get; set; }
		public Employee Employee { get; set; }
		public int? ProductId { get; set; }
		public Product Product { get; set; }
		public int? ProviderId { get; set; }
		public Provider Provider { get; set; }
		
		public ProductChangelog()
		{
			Id = 0;
			Date = DateTime.Now;
			Type = "";
			OldProvider = "";
		}
	}
}
