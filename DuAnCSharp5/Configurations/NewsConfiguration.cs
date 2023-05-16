using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DuAnCSharp5.Models;

namespace DuAnCSharp5.Configurations
{
    public class NewsConfiguration : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder.ToTable("tb_News");
            builder.HasKey(x => x.NewsId);
            builder.HasOne(p => p.Category)
                .WithMany(p => p.news)
                .HasForeignKey(p => p.NewsId);

        }
    }
}
