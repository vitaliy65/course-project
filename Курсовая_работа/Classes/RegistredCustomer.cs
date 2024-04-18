using System.Text.Json;
using Курсовая_работа.model;

namespace Курсовая_работа.Classes
{
    static class RegistredCustomer
    {
        static private string FilePath { get; } = "userData.json";

        static private Customer? _CurrentCustomer { get; set; }
        static public Customer? CurrentCustomer
        {
            get => _CurrentCustomer;
            set => _CurrentCustomer = value;
        }
        static private List<Product>? _Cart { get; set; } = new List<Product> { };
        static public List<Product>? Cart
        {
            get => _Cart;
        }

        static RegistredCustomer()
        {
            // При инициализации класса проверяем наличие сохраненных данных о пользователе
            if (File.Exists(FilePath))
            {
                LoadUserData();
            }
        }

        static public void addProductInCart(Product product)
        {
            Cart?.Add(product);
        }

        static public void deleteProductFormCartByIndex(int index)
        {
            Cart?.RemoveAt(index);
        }

        static public void ClearCart()
        {
            Cart?.Clear();
        }

        static public int cartCount() => Cart?.Count() == null ? 0 : Cart.Count();

        static public void SaveUserData()
        {
            try
            {
                if (_CurrentCustomer != null)
                {
                    string jsonData = JsonSerializer.Serialize(_CurrentCustomer);
                    File.WriteAllText(FilePath, jsonData);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving user data: {ex.Message}");
            }
        }

        static private void LoadUserData()
        {
            try
            {
                string jsonData = File.ReadAllText(FilePath);
                _CurrentCustomer = JsonSerializer.Deserialize<Customer>(jsonData);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading user data: {ex.Message}");
            }
        }
    }
}
