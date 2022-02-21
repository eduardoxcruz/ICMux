namespace Mux.Model
{
	public class ProductChangelog
	{
#pragma warning disable 8632
		public int? Id { get; set; }
		public DateTime? Date { get; set; }
		public string? Type { get; set; }
		public int? Amount { get; set; }
		public int? PreviousAmount { get; set; }
		public int? NewAmount { get; set; }
		public decimal? PurchasePrice { get; set; }
		public string? Provider { get; set; }
		public string? ProductFullDescription { get; set; }
		public string? EmployeeName { get; set; }
		public Employee Employee { get; set; }
		public int? EmployeeId { get; set; }
		public Product Product { get; set; }
		public int? ProductId { get; set; }
#pragma warning restore 8632
		
		public ProductChangelog()
		{
			Id = 0;
			Date = DateTime.Now;
			Type = "";
			Amount = 0;
			PreviousAmount = 0;
			NewAmount = 0;
			PurchasePrice = 0;
			Provider = "";
			ProductFullDescription = "";
			EmployeeName = "";
		}
	}
}
