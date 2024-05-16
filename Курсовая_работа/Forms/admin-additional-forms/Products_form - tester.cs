using image_description_button;
using System.Windows.Forms;
using Курсовая_работа.Controller;
using Курсовая_работа.model;

namespace Курсовая_работа.Forms
{
    internal partial class Products_form_tester : Form
    {
        ProductController products;

        public Products_form_tester(Restaurant restaurant)
        {
            InitializeComponent();
            products = new ProductController();

            try
            {
                pictureBox1.BackgroundImage = new Bitmap($"{Application.StartupPath}\\{restaurant.FilePathimage}");
            } catch (Exception ex) { }

            label1.Text = restaurant.Name;
            label2.Text = restaurant.timeForCustomer;
            textBox1.Text = restaurant.Description;
            Label4.Text = "Le-Peta";

            InstantiateProducts(restaurant);
        }

        void InstantiateProducts(Restaurant restaurant)
        {
            flowLayoutPanel1.WrapContents = true;

            foreach (var product in products.GetElements())
            {
                if (restaurant.Id == product.RestaurantId)
                {
                    ProductBanner banner = new ProductBanner();
                    // Настраиваем его свойства на основе данных продукта
                    try
                    {
                        banner.Productimage = new Bitmap($"{Application.StartupPath}\\{product.FilePathimage}");
                    } catch (Exception ex) { }

                    banner.label_Name  = product.Name;
                    banner.label_Price = product.Price.ToString();
                    banner.Tag         = product.Id;
                    banner.ProductBannerAction += ProductBanner_click;

                    // Добавляем listItemBanner в FlowLayoutPanel
                    flowLayoutPanel1.Controls.Add(banner);
                }
            }
        }

        void ProductBanner_click(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                // Получаем родительский контрол PictureBox, который должен быть экземпляром RestaurantBanner
                var productBanner = pictureBox.Parent.Parent.Parent as ProductBanner;

                // Проверяем, является ли родительский контрол PictureBox экземпляром RestaurantBanner
                if (productBanner != null)
                {
                    foreach (var product in products.GetElements())
                    {
                        if (product.Id == int.Parse(productBanner.Tag.ToString()))
                        {
                            buy_product_form buy_product_Form = new buy_product_form(product);
                            buy_product_Form.Show();
                            return;
                        }
                    }
                }
            }
        }

        private void Label4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_main_menu_tester form_Main_Menu = new Form_main_menu_tester();
            form_Main_Menu.Show();
            Hide();
        }
    }
}
