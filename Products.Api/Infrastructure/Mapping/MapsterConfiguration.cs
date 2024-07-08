using Mapster;
using Products.Application.Order;
using Products.Application.Product;
using Products.Domain;

namespace Products.Api.Infrastructure.Mapping
{
    public static class MapsterConfiguration
    {
        public static void RegisterMaps(this IServiceCollection services)
        {
            TypeAdapterConfig<ProductRequestModel, ProductEntity>
            .NewConfig()
            .TwoWays();

            TypeAdapterConfig<ProductRequestModel, ProductResponseModel>
            .NewConfig()
            .TwoWays();

            TypeAdapterConfig<OrderRequestModel, OrderEntity>
            .NewConfig()
            .TwoWays();

            TypeAdapterConfig<OrderRequestModel, OrderResponseModel>
            .NewConfig()
            .TwoWays();
        }
    }
}
