using Products.Application.Order;
using Products.Domain;
using Products.Persistence.Context;

namespace Products.Infrastructure.Order
{
    public class OrderRepository : BaseRepository<OrderEntity>, IOrderRepository
    {

        public OrderRepository(ProductsContext context) : base(context)
        {

        }

        public async Task CreateAsync(CancellationToken cancellationToken, OrderEntity order)
        {
            await base.AddAsync(cancellationToken, order);
        }

        async Task<OrderEntity> IOrderRepository.GetByIdAsync(CancellationToken cancellationToken, int id)
        {
            return await base.GetAsync(cancellationToken, id);
        }

    }
}
