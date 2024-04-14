namespace Курсовая_работа.model
{
    public class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public DateTime orderPlaced { get; set; }
        public DateTime? orderFulfilled { get; set; }
        public Customer customer { get; set; }
        public Product product { get; set; }
    }
}
