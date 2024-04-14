namespace Курсовая_работа.model
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string FilePathimage { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? timeForCustomer { get; set; }
        public string Description { get; set; } = null!;
        public ICollection<Product> Products { get; set; } = null!;
    }
}