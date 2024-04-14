using image_description_button;
using System.Windows.Forms;
using Курсовая_работа.Controller;
using Курсовая_работа.model;

namespace Курсовая_работа.Forms
{
    internal partial class Products_form : Form
    {
        ProductController controller;
        ProductBanner[] productBanners;

        public Products_form(Restaurant restaurant)
        {
            InitializeComponent();
            controller = new ProductController();
            FormClosing += ButtonInteraction.FormClosing;
            label1.Text = restaurant.Name;
            label2.Text = restaurant.timeForCustomer;
            textBox1.Text = restaurant.Description;
            Label4.Text = "Le-Peta";

            // Получение всех элементов ProductBanner на форме
            productBanners = panel1.Controls.OfType<ProductBanner>().ToArray();

            InstantiateProducts(restaurant);
        }

        void InstantiateProducts(Restaurant restaurant)
        {
            int i = 0;
            foreach (var product in controller.GetElements())
            {
                if (restaurant.Id == product.RestaurantId)
                {
                    productBanners[i].Enabled = true;
                    productBanners[i].Visible = true;
                    productBanners[i].label_Name = product.Name;
                    productBanners[i].label_Price = product.Price.ToString();
                    productBanners[i].Tag = product.ProductId;
                    productBanners[i].ProductBannerAction += ProductBanner_click;

                    try
                    {
                        string imagePath = product.FilePathimage;
                        productBanners[i].Productimage = new Bitmap($"{Application.StartupPath}\\{imagePath}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message); // Пример
                    }
                    i++;
                }
            }

            for (; i < productBanners.Count(); i++)
            {
                productBanners[i].Enabled = false;
                productBanners[i].Visible = false;
            }
        }

        void ProductBanner_click(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                // Получаем родительский контрол PictureBox, который должен быть экземпляром RestaurantBanner
                var productBanner = pictureBox.Parent.Parent as ProductBanner;

                // Проверяем, является ли родительский контрол PictureBox экземпляром RestaurantBanner
                if (productBanner != null)
                {
                    foreach (var product in controller.GetElements())
                    {
                        if (product.ProductId == int.Parse(productBanner.Tag.ToString()))
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
