namespace Mux.Model
{
	public class ProductRequest
	{
#pragma warning disable 8632
		public int? Id { get; set; }
		public DateTime? Date { get; set; }
		public int? Amount { get; set; }
		public string? EmployeeName { get; set; }
		public string? Type { get; set; }
		public string? Status { get; set; }
		public Employee Employee { get; set; }
		public int? EmployeeId { get; set; }
		public Product Product { get; set; }
		public int? ProductId { get; set; }
#pragma warning restore 8632
		
		public ProductRequest()
		{
			Id = 0;
			Date = DateTime.Now;
			Amount = 0;
			EmployeeName = null;
			Type = "";
			Status = "";
		}
	}
}
