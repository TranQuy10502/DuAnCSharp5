using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DuAnCSharp5.Models;

namespace DuAnCSharp5.Configurations
{
    public class MaterialConfiguration : IEntityTypeConfiguration<Material>
    {
        public void Configure(EntityTypeBuilder<Material> builder)
        {
            builder.ToTable("tb_Material");
            builder.HasKey(p => p.MaterialId);
        }
    }
}
