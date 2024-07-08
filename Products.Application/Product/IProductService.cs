namespace Products.Application.Product
{
    public interface IProductService
    {
        Task<List<ProductResponseModel>> GetAll(CancellationToken cancellationToken);
        Task<ProductResponseModel> Get(CancellationToken cancellationToken, int id);
    }
}
