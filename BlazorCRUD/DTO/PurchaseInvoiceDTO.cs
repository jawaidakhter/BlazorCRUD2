using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace BlazorCRUD.DTO
{
	public class PurchaseInvoiceDTO
	{
		public PurchaseInvoiceDTO()
		{
			InvoiceDetails = new List<PurchaseInvoiceDetailDTO>();
		}
		public int Id { get; set; }
		public string Vendoer { get; set; }
		public int? VendorId { get; set; }
		public DateTime? InvoiceDate { get; set; }
		public List<PurchaseInvoiceDetailDTO> InvoiceDetails { get; set; }
		public double TotalAmount { get { return InvoiceDetails.Sum(c => c.Amount); } }
	}


	public class PurchaseInvoiceDetailDTO
	{
		public int Id { get; set; }
		public string Product { get; set; }
		public int PurchaseInvoiceId { get; set; }
		public int? ProductId { get; set; }
		public int Quantity { get; set; }
		public double Rate { get; set; }
		public double Amount	{ get { return Quantity * Rate; } }
	}
}
