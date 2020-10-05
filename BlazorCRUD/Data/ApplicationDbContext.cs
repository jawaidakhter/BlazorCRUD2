using System;
using System.Collections.Generic;
using System.Text;
using BlazorCRUD.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorCRUD.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			 : base(options)
		{
		}
		// All entity class collection objects came here
		public virtual DbSet<ProductCategory> ProductCategories	{ get; set; }
		public virtual DbSet<Vendor> Vendors { get; set; }
		public virtual DbSet<Product> Products { get; set; }
		public virtual DbSet<PurchaseInvoice> PurchaseInvoices { get; set; }
		public virtual DbSet<PurchaseInvoiceDetail> PurchaseInvoiceDetails { get; set; }

		// Database configuration came here
		protected override void OnModelCreating(ModelBuilder mb)
		{
			base.OnModelCreating(mb);

			// Configure each entities
			mb.Entity<Product>(cc =>
			{
				cc.Property(c => c.Title).HasMaxLength(200).IsUnicode(false).IsRequired(true);
				cc.Property(c => c.SKU).HasMaxLength(20).IsUnicode(false).IsRequired(true);
				cc.Property(c => c.Company).HasMaxLength(200).IsUnicode(false).IsRequired(false);
				cc.Property(c => c.Brand).HasMaxLength(200).IsUnicode(false).IsRequired(false);
				cc.Property(c => c.CreatedBy).HasMaxLength(200).IsUnicode(false).IsRequired(true);
				cc.Property(c => c.ModifiedBy).HasMaxLength(200).IsUnicode(false).IsRequired(false);
				cc.HasOne(c => c.ProductCategory).WithMany(c => c.Products).HasForeignKey(c => c.ProductCategoryId).OnDelete(DeleteBehavior.Restrict);
				cc.HasData(new Product { Id = 1, Brand = "Nokia 123", Company = "Nokia", CreatedBy = "jawaid", CreatedDate = DateTime.Now, ProductCategoryId = 1, SKU = "EP-1-1", Title = "Nokia 123 Prime" });
			});

			mb.Entity<ProductCategory>(cc =>
			{
				cc.Property(c => c.Title).HasMaxLength(200).IsUnicode(false).IsRequired(true);
				cc.Property(c => c.CreatedBy).HasMaxLength(200).IsUnicode(false).IsRequired(true);
				cc.Property(c => c.ModifiedBy).HasMaxLength(200).IsUnicode(false).IsRequired(false);
				cc.HasData(new ProductCategory { Id=1, CreatedBy = "jawaid", CreatedDate = DateTime.Now, Title = "Electronics"});
				cc.HasData(new ProductCategory { Id=2, CreatedBy = "jawaid", CreatedDate = DateTime.Now, Title = "AC/Fridge" });
				cc.HasData(new ProductCategory { Id=3, CreatedBy = "jawaid", CreatedDate = DateTime.Now, Title = "Auto Parts"});

			});

			mb.Entity<Vendor>(cc =>
			{
				cc.Property(c => c.CompnayName).HasMaxLength(200).IsUnicode(false).IsRequired(true);
				cc.Property(c => c.ContactPerson).HasMaxLength(200).IsUnicode(false).IsRequired(true);
				cc.Property(c => c.Phone).HasMaxLength(20).IsUnicode(false).IsRequired(true);
				cc.Property(c => c.Email).HasMaxLength(200).IsUnicode(false).IsRequired(false);
				cc.Property(c => c.CreatedBy).HasMaxLength(200).IsUnicode(false).IsRequired(true);
				cc.Property(c => c.ModifiedBy).HasMaxLength(200).IsUnicode(false).IsRequired(false);
				cc.HasData(new Vendor { Id=1, CompnayName = "Alex", ContactPerson = "Yasir", CreatedBy = "jawaid", CreatedDate = DateTime.Now, Email = "", Phone = "1234" });
				cc.HasData(new Vendor { Id=2, CompnayName = "Galaxy", ContactPerson = "Saleem", CreatedBy = "jawaid", CreatedDate = DateTime.Now, Email = "", Phone = "1234" });
			});

			mb.Entity<PurchaseInvoice>(cc =>
			{
				cc.HasOne(c => c.Vendor).WithMany(c => c.PurchaseInvoices).HasForeignKey(c => c.VendorId).OnDelete(DeleteBehavior.Restrict);
				cc.Property(c => c.CreatedBy).HasMaxLength(200).IsUnicode(false).IsRequired(true);
				cc.Property(c => c.ModifiedBy).HasMaxLength(200).IsUnicode(false).IsRequired(false);
			});

			mb.Entity<PurchaseInvoiceDetail>(cc =>
			{
				cc.HasOne(c => c.PurchaseInvoice).WithMany(c => c.PurchaseInvoiceDetails).HasForeignKey(c => c.PurchaseInvoiceId).OnDelete(DeleteBehavior.Restrict);
				cc.HasOne(c => c.Product).WithMany(c => c.PurchaseInvoiceDetails).HasForeignKey(c => c.ProductId).OnDelete(DeleteBehavior.Restrict);
				
			});
		}

		
	}

}
