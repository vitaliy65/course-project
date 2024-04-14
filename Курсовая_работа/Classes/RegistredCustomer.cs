using Курсовая_работа.model;

namespace Курсовая_работа.Classes
{
    static class RegistredCustomer
    {
        static private Customer? _CurrentCustomer { get; set; }

        static private List<Product>? _Cart { get; set; } = new List<Product> { };

        static public Customer? CurrentCustomer
        {
            get => _CurrentCustomer;
            set => _CurrentCustomer = value;
        }

        static public List<Product>? Cart
        {
            get => _Cart;
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
    }
}
