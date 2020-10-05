using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD.DTO
{
	public class ProductCategoryDTO
	{
		public int Id { get; set; }
		[Required]
		[StringLength(200)]
		public string Title { get; set; }
	}
}
