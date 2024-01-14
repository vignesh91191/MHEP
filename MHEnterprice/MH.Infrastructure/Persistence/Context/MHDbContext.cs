
using Domain.Entities.Product;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Context
{
    public class MHDbContext : DbContext
    {
        public MHDbContext(DbContextOptions<MHDbContext> contextOptions) : base(contextOptions)
        {

        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);
        }

    }
}
