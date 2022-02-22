using System;

namespace Mux.Model
{
	public class ProductToBuy
	{
#pragma warning disable 8632
		public int? Id { get; set; }
		public string? Status { get; set; }
		public int? ProviderId { get; set; }
		public string? OldProvider { get; set; }
		public string? OrderReference { get; set; }
		public DateTime? LocationDate { get; set; }
		public int? SellerId { get; set; }
		public DateTime? ArrivalDate { get; set; }
		public DateTime? RequestDate { get; set; }
		public int? RequestedAmount { get; set; }
#pragma warning restore 8632
		public Provider Provider { get; set; }
		public int? ProductId { get; set; }
		public Product Product { get; set; }
		public Employee Seller { get; set; }

		public ProductToBuy()
		{
			Id = 0;
			OldProvider = "";
			RequestDate = DateTime.Now;
			Status = "";
			RequestedAmount = 0;
		}
	}
}
