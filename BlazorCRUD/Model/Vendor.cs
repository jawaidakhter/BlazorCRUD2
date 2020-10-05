using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD.Model
{
	public class Vendor
	{
		public int Id { get; set; }
		public string CompnayName { get; set; }
		public string ContactPerson { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public virtual List<PurchaseInvoice> PurchaseInvoices { get; set; }

		#region Audit Log
		public DateTime CreatedDate { get; set; }
		public string CreatedBy { get; set; }
		public DateTime? ModifiedDate { get; set; }
		public string ModifiedBy { get; set; }
		#endregion

	}
}
