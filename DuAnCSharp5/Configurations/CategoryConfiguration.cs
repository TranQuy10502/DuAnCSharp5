using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DuAnCSharp5.Models;

namespace DuAnCSharp5.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("tb_Category");
            builder.HasKey(p => p.CategoryId);
        }
    }
}
