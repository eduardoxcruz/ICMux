using System.Collections.Generic;

namespace Mux.Model
{
	public class Product
	{
#pragma warning disable 8632
		public int Id { get; set; }
		public string? DebugCode { get; set; }
		public string Status { get; set; }
		public string Enrollment { get; set; }
		public string OldMountingTechnology { get; set; }
		public string OldEncapsulationType { get; set; }
		public string ShortDescription { get; set; }
		public string Category { get; set; }
		public bool IsUsingInventory { get; set; }
		public int CurrentAmount { get; set; }
		public int MinAmount { get; set; }
		public int MaxAmount { get; set; }
		public string? Container { get; set; }
		public string? Location { get; set; }
		public string? BranchOffice { get; set; }
		public string? Rack { get; set; }
		public string? Shelf { get; set; }
		public decimal BuyPrice { get; set; }
		public string OldUnitType { get; set; }
		public string? OldManufacturer { get; set; }
		public string? PartNumber { get; set; }
		public string TypeOfStock { get; set; }
		public bool IsManualProfit { get; set; }
		public decimal? PercentageOfProfit { get; set; }
		public decimal? PercentageOfDiscount { get; set; }
		public decimal? SalePriceWithoutDiscount { get; set; }
		public decimal? SalePriceWithDiscount { get; set; }
		public decimal? ProfitWithoutDiscount { get; set; }
		public decimal? ProfitWithDiscount { get; set; }
		public string FullDescription { get; set; }
		public string? Memo { get; set; }
		public int Entrys { get; set; }
		public int Devolutions { get; set; }
		public int Egresses { get; set; }
		public int AmountAdjustments { get; set; }
		public int PriceAdjustments { get; set; }
#pragma warning restore 8632
		public int? EncapsulationTypeId { get; set; }
		public EncapsulationType EncapsulationType { get; set; }
		public int? MountingTechnologyId { get; set; }
		public MountingTechnology MountingTechnology { get; set; }
		public int? ManufacturerId { get; set; }
		public Manufacturer Manufacturer { get; set; }
		public int? UnitTypeId { get; set; }
		public UnitType UnitType { get; set; }
		public List<ProductToBuy> ShoppingCart { get; set; }
		public List<ProductRequest> ProductRequests { get; set; }
		public List<ProductChangelog> ProductChangeLogs { get; set; }
		public List<Category> Categories { get; set; }

		public Product()
		{
			Id = 0;
			Status = "ACTIVO";
			Enrollment = "";
			OldMountingTechnology = "";
			OldEncapsulationType = "";
			ShortDescription = "";
			Category = "";
			IsUsingInventory = false;
			CurrentAmount = 0;
			MinAmount = 0;
			MaxAmount = 0;
			BuyPrice = 0.0M;
			OldUnitType = "";
			TypeOfStock = "Stock";
			IsManualProfit = true;
			FullDescription = "";
			Entrys = 0;
			Devolutions = 0;
			Egresses = 0;
			AmountAdjustments = 0;
			PriceAdjustments = 0;
			ShoppingCart = new List<ProductToBuy>();
			ProductRequests = new List<ProductRequest>();
			ProductChangeLogs = new List<ProductChangelog>();
			Categories = new List<Category>();
		}
	}
}
