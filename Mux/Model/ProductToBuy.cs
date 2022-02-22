using System;

#nullable enable

namespace Mux.Model
{
	public class ProductToBuy
	{
		public int? Id { get; set; }
		public string? Status { get; set; }
		public int? ProviderId { get; set; }
		public string? OldProvider { get; set; }
		public string? OrderReference { get; set; }
		public DateTime? LocationDate { get; set; }
		public int? SellerId { get; set; }
		public DateTime? ArrivalDate { get; set; }
		public string? Comments { get; set; }
		public DateTime? RequestDate { get; set; }
		public int? PetitionerId { get; set; }
		public int? RequestedAmount { get; set; }
		public Provider Provider { get; set; }
		public int? ProductId { get; set; }
		public Product Product { get; set; }
		public Employee Seller { get; set; }
		public Employee Petitioner { get; set; }

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
