using Products.Domain;

namespace Products.Application.Product
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductEntity>> GetAllAsync(CancellationToken cancellationToken);
        Task<ProductEntity> GetByIdAsync(CancellationToken cancellationToken, int id);
    }
}