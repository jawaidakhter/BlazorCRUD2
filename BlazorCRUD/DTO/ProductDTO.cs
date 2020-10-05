using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD.DTO
{
	public class ProductDTO
	{
		public int Id { get; set; }
		[Required]
		[StringLength(200)]
		public string Title { get; set; }
		[Required]
		[StringLength(20)]
		public string SKU { get; set; }
		[StringLength(20)]
		public string Company { get; set; }
		[StringLength(20)]
		public string Brand { get; set; }
		public string Category { get; set; }
		[Required(ErrorMessage ="Please select Product Category")]
		[Display(Name = "Product Category")]
		public int? CategoryId { get; set; }

	}
}
