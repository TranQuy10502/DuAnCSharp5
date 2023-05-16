using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DuAnCSharp5.Models;

namespace DuAnCSharp5.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("tb_Customer");
            builder.HasKey(p => p.CustomerId);
        }
    }
}
