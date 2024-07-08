using Products.Domain;

namespace Products.Application.Order
{
    public interface IOrderRepository
    {
        Task CreateAsync(CancellationToken cancellationToken, OrderEntity order);
        Task<OrderEntity> GetByIdAsync(CancellationToken cancellationToken,int id);
    }
}
