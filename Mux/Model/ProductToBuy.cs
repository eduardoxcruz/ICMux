using System;

#nullable enable

namespace Mux.Model
{
	public class ProductToBuy
	{
		public int Id { get; set; }
		public string Status { get; set; }
		public int? ProviderId { get; set; }
		public Provider Provider { get; set; }
		public string? OrderReference { get; set; }
		public DateTime? LocationDate { get; set; }
		public int? SellerId { get; set; }
		public Employee Seller { get; set; }
		public DateTime? ArrivalDate { get; set; }
		public string? Comments { get; set; }
		public DateTime RequestDate { get; set; }
		public int? PetitionerId { get; set; }
		public Employee Petitioner { get; set; }
		public string InternalReference { get; set; }
		public string ProductDescription { get; set; }
		public int RequestedAmount { get; set; }
		public int? ProductId { get; set; }
		public Product Product { get; set; }
		public string MountingTechnology { get; set; }
		public string EncapsulationType { get; set; }
		public string Priority { get; set; }
		public decimal? OriginalProductPirce { get; set; }
		public bool IvaIncluded { get; set; }
		public string Currency { get; set; }
		public decimal ExtraCost { get; set; }
		public decimal? ProductPriceWithIva { get; set; }
		
		public decimal SubTotal { get; set; }
		public string? ProductUrl { get; set; }
		
		public ProductToBuy()
		{
			Id = 0;
			Status = "";
			RequestDate = DateTime.Now;
			InternalReference = "";
			ProductDescription = "";
			RequestedAmount = 0;
			MountingTechnology = "";
			EncapsulationType = "";
			Priority = "";
			IvaIncluded = false;
			Currency = "MXN";
			ExtraCost = 0.0M;
			SubTotal = 0.0M;
		}
	}
}
