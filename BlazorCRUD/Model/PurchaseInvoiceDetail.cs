using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD.Model
{
	public class PurchaseInvoiceDetail
	{
		public int Id { get; set; }
		public int PurchaseInvoiceId { get; set; }
		public virtual PurchaseInvoice PurchaseInvoice { get; set; }
		public int ProductId { get; set; }
		public virtual Product Product { get; set; }
		public int Quantity { get; set; }
		public double Rate { get; set; }

		#region Audit Log
		public DateTime CreatedDate { get; set; }
		public string CreatedBy { get; set; }
		public DateTime? ModifiedDate { get; set; }
		public string ModifiedBy { get; set; }
		#endregion
	}
}
