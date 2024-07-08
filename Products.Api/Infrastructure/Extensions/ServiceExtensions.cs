using Products.Application.Order;
using Products.Application.Product;
using Products.Infrastructure.Order;
using Products.Infrastructure.Product;

namespace Products.Api.Infrastructure.Extensions
{
    public static class ServiceExtensions
    {

        public static void AddService(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IOrderService, OrderService>();
        }

        public static void AddRepository(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
        }

    }
}

