namespace Products.Application.Exceptions
{
    public class ProductNotFoundException : Exception
    {
        public string Code = "ProductNotFound";

        public ProductNotFoundException(string message) : base(message) { }
    }
}
