namespace Products.Application.Order
{
    public interface IOrderService
    {
        Task CreateAsync(CancellationToken cancellationToken, OrderRequestModel order);
        Task<OrderResponseModel> Get(CancellationToken cancellationToken, int id);
    }
}
