namespace Курсовая_работа.model
{
    public class Product
    {
        public int ProductId { get; set; } // Перейменував змінну, оскільки за замовчуванням Entity Framework очікує поля з назвою Id
        public int RestaurantId { get; set; } // Додав поле для зовнішнього ключа
        public string FilePathimage { get; set; } = null!;
        public float Price { get; set; } = 0; // Перейменував змінну для відповідності стилю коду
        public string Name { get; set; } = null!; // Перейменував змінну для відповідності стилю коду
        public string? Description { get; set; }

        public Restaurant Restaurant { get; set; } // Додав зв'язок з батьківською моделлю

        // Якщо Product може мати лише одного батька, ви можете використовувати наступне:
        // public Restaurant Restaurant { get; set; }
    }
}