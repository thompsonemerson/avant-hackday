using Avant.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avant.Repository.Configuration
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.Description)
                .HasMaxLength(5000);

            this.Property(t => t.Price)
                .IsRequired();

            this.Property(t => t.PhotoUrl)
                .IsRequired()
                .HasMaxLength(800);

            // Table & Column Mappings
            this.ToTable("Product");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Category).HasColumnName("Category");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.PromitionalPrice).HasColumnName("PromitionalPrice");
            this.Property(t => t.Highlight).HasColumnName("Highlight");
            this.Property(t => t.PhotoUrl).HasColumnName("PhotoUrl");
            this.Property(t => t.Stock).HasColumnName("Stock");

        }
    }
}
