using Microsoft.AspNetCore.Mvc;
using Products.Application.Order;
using Products.Application.Product;

namespace Products.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("{id}")]
        public async Task<OrderResponseModel> Get(CancellationToken cancellationToken, int id)
        {
            return await _orderService.Get(cancellationToken, id);
        }

        [HttpPost("Register")]
        public async Task Post(CancellationToken cancellationToken, OrderRequestModel request)
        {
            await _orderService.CreateAsync(cancellationToken, request);
        }

    }
}
