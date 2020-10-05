using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD.Model
{
	public class PurchaseInvoice
	{
		public int Id { get; set; }
		public int VendorId { get; set; }
		public virtual Vendor Vendor { get; set; }
		public DateTime InvoiceDate { get; set; }
		public virtual List<PurchaseInvoiceDetail> PurchaseInvoiceDetails { get; set; }
		#region Audit Log
		public DateTime CreatedDate { get; set; }
		public string CreatedBy { get; set; }
		public DateTime? ModifiedDate { get; set; }
		public string ModifiedBy { get; set; }
		#endregion
	}
}
