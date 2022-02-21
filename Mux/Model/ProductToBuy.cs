using System;

namespace Mux.Model
{
	public class ProductToBuy
	{
#pragma warning disable 8632
		public int? Id { get; set; }
		public string? Provider { get; set; }
		public DateTime? Date { get; set; }
		public string? Status { get; set; }
		public int? RequestedAmount { get; set; }
		public string? EmployeeName { get; set; }
		public Employee Employee { get; set; }
		public int? EmployeeId { get; set; }
		public Product Product { get; set; }
		public int? ProductId { get; set; }
#pragma warning restore 8632
		
		public ProductToBuy()
		{
			Id = 0;
			Provider = "";
			Date = DateTime.Now;
			Status = "";
			RequestedAmount = 0;
			EmployeeName = "";
		}
	}
}
