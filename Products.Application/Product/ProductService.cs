using Products.Application.Exceptions;

namespace Products.Application.Product
{
    public class ProductService : IProductService
    {

        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<ProductResponseModel> Get(CancellationToken cancellationToken, int id)
        {
            var result = await _repository.GetByIdAsync(cancellationToken, id);

            if (result == null)
                throw new ProductNotFoundException(id.ToString());
            else
                return result.Adapt<ProductResponseModel>();
        }

        public async Task<List<ProductResponseModel>> GetAll(CancellationToken cancellationToken)
        {
            var result = await _repository.GetAllAsync(cancellationToken);

            return result.Adapt<List<ProductResponseModel>>();
        }
    }
}