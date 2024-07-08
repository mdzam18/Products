using Microsoft.AspNetCore.Mvc;
using Products.Application.Product;

namespace Products.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<List<ProductResponseModel>> GetAll(CancellationToken cancellationToken)
        {
            return await _productService.GetAll(cancellationToken);
        }

        [HttpGet("{id}")]
        public async Task<ProductResponseModel> Get(CancellationToken cancellationToken, int id)
        {
            return await _productService.Get(cancellationToken, id);
        }
    }
}