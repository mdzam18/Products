using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain;

namespace Products.Persistence.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<OrderEntity>
    {
        public void Configure(EntityTypeBuilder<OrderEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.TotalAmount).IsRequired();

            builder.Property(x => x.OrderDate).HasColumnType("datetime").IsRequired();
        }
    }
}
