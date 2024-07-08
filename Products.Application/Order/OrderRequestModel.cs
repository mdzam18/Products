namespace Products.Application.Order
{
    public class OrderRequestModel
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public int ToTalAmount { get; set; }
    }
}
