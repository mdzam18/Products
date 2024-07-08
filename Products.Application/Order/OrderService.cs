using Products.Application.Exceptions;
using Products.Domain;

namespace Products.Application.Order
{
    public class OrderService : IOrderService
    {

        private readonly IOrderRepository _repository;

        public OrderService(IOrderRepository repository)
        {
            _repository = repository;
        }

        public async Task CreateAsync(CancellationToken cancellationToken, OrderRequestModel order)
        {
            var orderToInsert = order.Adapt<OrderEntity>();

            await _repository.CreateAsync(cancellationToken, orderToInsert);
        }

        public async Task<OrderResponseModel> Get(CancellationToken cancellationToken, int id)
        {
            var result = await _repository.GetByIdAsync(cancellationToken, id);

            if (result == null)
                throw new OrderNotFoundException(id.ToString());
            else
                return result.Adapt<OrderResponseModel>();
        }
    }
}