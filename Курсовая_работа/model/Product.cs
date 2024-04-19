namespace Курсовая_работа.model
{
    public class Product
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public string FilePathimage { get; set; } = null!;
        public float Price { get; set; } = 0;
        public string Name { get; set; } = null!; 
        public string? Description { get; set; }

        public ICollection<ProductCategory> categories { get; set; } = null!;
        public Restaurant Restaurant { get; set; } // Додав зв'язок з батьківською моделлю
    }
}