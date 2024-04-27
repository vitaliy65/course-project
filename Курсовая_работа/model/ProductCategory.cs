namespace Курсовая_работа.model
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public ProductCategoryEnum category { get; set; }

        public Product product { get; set; }
    }
}
