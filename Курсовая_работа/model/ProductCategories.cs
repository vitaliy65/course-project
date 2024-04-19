using Курсовая_работа.Enum;

namespace Курсовая_работа.model
{
    public class ProductCategories
    {
        public int Id { get; set; }
        public ProductCategory category { get; set; }

        public int ProductId { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
