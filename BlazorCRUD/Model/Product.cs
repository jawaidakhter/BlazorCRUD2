using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD.Model
{
	public class Product
	{
		public int Id { get; set; }
		public string SKU { get; set; }
		public string Title { get; set; }
		public string Company { get; set; }
		public string Brand { get; set; }
		public int ProductCategoryId { get; set; }
		public virtual ProductCategory ProductCategory { get; set; }
		public virtual List<PurchaseInvoiceDetail> PurchaseInvoiceDetails { get; set; }

		#region Audit Log
		public DateTime CreatedDate { get; set; }
		public string CreatedBy { get; set; }
		public DateTime? ModifiedDate { get; set; }
		public string ModifiedBy { get; set; }
		#endregion

	}
}
