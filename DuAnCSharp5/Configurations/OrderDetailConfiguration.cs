using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DuAnCSharp5.Models;

namespace DuAnCSharp5.Configurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("tb_OrderDetail");
            builder.HasKey(p => p.OrderId);
            builder.HasOne(p => p.Product)
                .WithMany(p => p.orderDetails)
                .HasForeignKey(p => p.OrderDetailId);
            builder.HasOne(p => p.Order)
                .WithMany(p => p.orderDetails)
                .HasForeignKey(p => p.OrderDetailId);
        }
    }
}
