using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DuAnCSharp5.Models;

namespace DuAnCSharp5.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("tb_Order");
            builder.HasKey(x => x.OrderId);
            builder.HasOne(p => p.User)
                .WithMany(p => p.orders)
                .HasForeignKey(p => p.OrderId);
            builder.HasOne(p => p.Customer)
                .WithMany(p => p.orders)
                .HasForeignKey(p => p.OrderId);
        }
    }
}
