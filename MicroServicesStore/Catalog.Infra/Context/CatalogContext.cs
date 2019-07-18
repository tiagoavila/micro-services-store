using Catalog.Domain;
using Catalog.Infra.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Infra.Context
{
    public class CatalogContext : DbContext
    {
        public CatalogContext(DbContextOptions<CatalogContext> options) : base(options)
        {

        }

        public CatalogContext()
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
