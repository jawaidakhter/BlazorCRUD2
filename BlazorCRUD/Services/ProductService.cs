using BlazorCRUD.Data;
using BlazorCRUD.DTO;
using BlazorCRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD.Services
{
	public class ProductDataService 
	{
		private readonly ApplicationDbContext dc;

		public ProductDataService(ApplicationDbContext dc)
		{
			this.dc = dc;
		}

		public Task<ProductDTO> Delete(int Id)
		{
			var q = dc.Products.Find(Id);
			ProductDTO obj;
			if (q != null)
			{
				var relatedRecord = dc.Products.Find(Id).PurchaseInvoiceDetails.Any();
				if (relatedRecord) throw new Exception("One ore more invoices exist on it");
				obj = new ProductDTO
				{
					Id = q.Id,
					Title = q.Title,
					Brand = q.Brand,
					Category = q.ProductCategory.Title,
					CategoryId = q.ProductCategoryId,
					Company = q.Company,
					SKU = q.SKU
				};
				dc.Products.Remove(q);
				dc.SaveChanges();
				return Task.FromResult(obj);
			}
			return null;
		}

		public Task<List<ProductDTO>> GetAll()
		{
			var q = (from aa in dc.Products
						orderby aa.Title
						select new ProductDTO
						{
							Id = aa.Id,
							Title = aa.Title,
							Brand = aa.Brand,
							Category = aa.ProductCategory.Title,
							CategoryId = aa.ProductCategoryId,
							Company = aa.Company,
							SKU = aa.SKU
						}).ToList();
			return Task.FromResult(q);
		}

		public Task<ProductDTO> GetById(int Id)
		{
			var q = (from aa in dc.Products
						where aa.Id == Id
						select new ProductDTO
						{
							Id = aa.Id,
							Title = aa.Title,
							Brand = aa.Brand,
							Category = aa.ProductCategory.Title,
							CategoryId = aa.ProductCategoryId,
							Company = aa.Company,
							SKU = aa.SKU
						}).FirstOrDefault();
			return Task.FromResult(q);
		}

		public Task<ProductDTO> Save(ProductDTO obj, string user)
		{

			var alreadyExist = (from aa in dc.Products
									  where aa.Title == obj.Title
									  && aa.Id != obj.Id
									  select aa).Any();
			if (alreadyExist)
				throw new Exception("record already exist");

			if (obj.Id == 0)
			{
				var cc = new Product
				{
					Title = obj.Title.Trim(),
					SKU = (obj.SKU ?? "").Trim(),
					Company = (obj.Company ?? "").Trim(),
					Brand=(obj.Brand ?? "").Trim(),
					ProductCategoryId=(int)obj.CategoryId,
					CreatedBy = user,
					CreatedDate = DateTime.Now
				};
				dc.Products.Add(cc);
				dc.SaveChanges();
				obj.Id = cc.Id;
				return Task.FromResult(obj);
			}
			else
			{
				var cc = dc.Products.Find(obj.Id);
				cc.Title = obj.Title.Trim();
				cc.SKU = (obj.SKU ?? "").Trim();
				cc.Company = (obj.Company ?? "").Trim();
				cc.Brand = (obj.Brand ?? "").Trim();
				cc.ProductCategoryId = (int)obj.CategoryId;
				cc.ModifiedBy = user;
				cc.ModifiedDate = DateTime.Now;
				dc.SaveChanges();
				return Task.FromResult(obj);
			}
		}

		public Task<List<ProductCategoryDTO>> GetCategories()
		{
			var q = (from aa in dc.ProductCategories
						orderby aa.Title
						select new ProductCategoryDTO
						{
							Id = aa.Id,
							Title = aa.Title
						}).ToList();
			return Task.FromResult(q);
		}
	}
}