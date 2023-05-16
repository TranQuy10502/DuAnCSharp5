using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DuAnCSharp5.Models;

namespace DuAnCSharp5.Configurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("tb_Post");
            builder.HasKey(p => p.PostId);
            builder.HasOne(p => p.Category)
                .WithMany(p => p.posts)
                .HasForeignKey(p => p.PostId);
        }
    }
}
