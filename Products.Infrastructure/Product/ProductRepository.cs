using Products.Application.Product;
using Products.Domain;
using Products.Persistence.Context;

namespace Products.Infrastructure.Product
{
    public class ProductRepository : BaseRepository<ProductEntity>, IProductRepository
    {

        public ProductRepository(ProductsContext context) : base(context)
        {

        }

        public async Task<ProductEntity> GetByIdAsync(CancellationToken cancellationToken, int id)
        {
            return await base.GetAsync(cancellationToken, id);
        }

        async Task<IEnumerable<ProductEntity>> IProductRepository.GetAllAsync(CancellationToken cancellationToken)
        {
            return await base.GetAllAsync(cancellationToken);
        }

    }
}
