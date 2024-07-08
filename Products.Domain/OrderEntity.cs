namespace Products.Domain
{
    public class OrderEntity
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public int ToTalAmount { get; set; }
    }
}
