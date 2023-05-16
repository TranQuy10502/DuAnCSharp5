using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace DuAnCSharp5.Models
{
    public class CuahangDbContext : DbContext
    {
        public CuahangDbContext() { }
        public CuahangDbContext(DbContextOptions<CuahangDbContext> options) : base(options) { }
        DbSet<User> users { get; set; }
        DbSet<Category> categories { get; set; }
        DbSet<Customer> customers { get; set; } 
        DbSet<News> news { get; set; }
        DbSet<Order> orders { get; set; }
        DbSet<OrderDetail> orderDetails { get; set; }
        DbSet<Post> posts { get; set; }
        DbSet<Product> products { get; set; }
        DbSet<ProductCategory> productCategories { get; set; }
        DbSet<ProductImage> productImages { get; set; }
        DbSet<Supplier> suppliers { get; set; } 
        DbSet<Material> materials { get; set; }
        DbSet<PaymentMethod> paymentMethods { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.
                UseSqlServer("Data Source=LAPTOP-TJU16KH0;Initial Catalog=dalcsharp5;Persist Security Info=True;User ID=hungnqph19112;Password=123456789;")
                );
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
