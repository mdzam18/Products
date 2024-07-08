using Microsoft.EntityFrameworkCore;
using Products.Domain;

namespace Products.Persistence.Context
{
    public class ProductsContext : DbContext
    {

        public ProductsContext(DbContextOptions<ProductsContext> options) : base(options) { }

        public DbSet<ProductEntity> Users { get; set; }
        public DbSet<OrderEntity> Topics { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                return base.SaveChangesAsync(cancellationToken);
            }
            catch (Exception)
            {
                var entities = ChangeTracker
                    .Entries()
                    .Where(e => e.Entity != null &&
                    (e.State == EntityState.Modified ||
                    e.State == EntityState.Added ||
                    e.State == EntityState.Deleted))
                    .ToList();


                foreach (var entity in entities)
                {
                    entity.State = entity.State switch
                    {
                        EntityState.Added => EntityState.Modified,
                        _ => EntityState.Unchanged,
                    };
                }
                throw;
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductsContext).Assembly);
        }

    }
}