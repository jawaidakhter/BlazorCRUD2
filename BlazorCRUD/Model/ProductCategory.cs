using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD.Model
{
	public class ProductCategory
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public virtual List<Product> Products { get; set; }

		#region Audit Log
		public DateTime CreatedDate { get; set; }
		public string CreatedBy { get; set; }
		public DateTime? ModifiedDate { get; set; }
		public string ModifiedBy { get; set; }
		#endregion	
	}
}
