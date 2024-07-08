namespace Products.Application.Order
{
    public class OrderResponseModel
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public int TotalAmount { get; set; }
    }
}
