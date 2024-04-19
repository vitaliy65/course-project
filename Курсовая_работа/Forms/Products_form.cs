using image_description_button;
using System.Windows.Forms;
using Курсовая_работа.Controller;
using Курсовая_работа.model;

namespace Курсовая_работа.Forms
{
    internal partial class Products_form : Form
    {
        ProductController products;

        public Products_form(Restaurant restaurant)
        {
            InitializeComponent();
            products = new ProductController();
            FormClosing += ButtonInteraction.FormClosing;

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
                            buy_product_Form.Location = Location;
                            return;
                        }
                    }
                }
            }
        }

        private void Label4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_main_menu form_Main_Menu = new Form_main_menu();
            form_Main_Menu.Show();
            form_Main_Menu.Location = Location;
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Customer_form form = new Customer_form();
            form.Show();
            form.Location = Location;
            Hide();
        }
    }
}
