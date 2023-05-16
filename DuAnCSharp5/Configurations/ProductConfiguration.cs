using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DuAnCSharp5.Models;

namespace DuAnCSharp5.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("tb_Product");
            builder.HasKey(p => p.ProductId);
            builder.HasOne(p => p.ProductCategory)
                .WithMany(p => p.products)
                .HasForeignKey(p => p.ProductId);
            builder.HasOne(p => p.Supplier)
                .WithMany(p => p.products)
                .HasForeignKey(p => p.SupplierId);
            builder.HasOne(p => p.Material)
                .WithMany(p => p.products)
                .HasForeignKey(p => p.MaterialId);
        }
    }
}
