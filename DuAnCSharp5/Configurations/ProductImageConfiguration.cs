using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DuAnCSharp5.Models;

namespace DuAnCSharp5.Configurations
{
    public class ProductImageConfiguration : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.ToTable("tb_ProductImage");
            builder.HasKey(p => p.ProductImageId);
            builder.HasOne(p => p.Product)
                .WithMany(p => p.productImages)
                .HasForeignKey(p => p.ProductImageId);
        }
    }
}
