using image_description_button;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Курсовая_работа.Controller;
using Курсовая_работа.model;

namespace Курсовая_работа.Forms
{
    public partial class allMenuForm_tester : Form
    {
        ProductController products;
        IEnumerable<Product> productsList;
        ProductCategoryController categories;
        List<ProductBanner> banners = new List<ProductBanner>();
        List<ProductCategoryEnum> checkedCategories;

        public allMenuForm_tester()
        {
            InitializeComponent();
            products = new ProductController();
            categories = new ProductCategoryController();
            checkedCategories = new List<ProductCategoryEnum>();
            productsList = products.GetElements();

            back_button.MouseEnter += ButtonInteraction.UpScale_button;
            back_button.MouseLeave += ButtonInteraction.DownScale_button;
        }

        private void allMenuForm_Load(object sender, EventArgs e)
        {
            // Предварительно загрузить категории
            foreach (var item in Enum.GetValues(typeof(ProductCategoryEnum)))
            {
                checkedListBox1.Items.Add(item);
            }

            // Предварительно создать банеры
            // Предварительно добавить все банеры на flowLayoutPanel1
            foreach (var product in productsList)
            {
                ProductBanner banner = CreateBanner(product);
                banners.Add(banner);
                flowLayoutPanel1.Controls.Add(banner);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.ToLower();

            foreach (var banner in banners)
            {
                bool isVisible = banner.label_Name.ToLower().Contains(searchText);
                banner.Visible = isVisible;
            }
        }

        private ProductBanner CreateBanner(Product product)
        {
            ProductBanner banner = new ProductBanner();
            // Настраиваем его свойства на основе данных продукта
            try
            {
                banner.Productimage = new Bitmap($"{Application.StartupPath}\\{product.FilePathimage}");
            }
            catch (Exception ex) { }

            banner.label_Name = product.Name;
            banner.label_Price = product.Price.ToString();
            banner.Tag = product.Id;
            banner.ProductBannerAction += ProductBanner_click;

            foreach (var category in categories.GetElements())
            {
                if (category.ProductId == product.Id)
                {
                    banner.categories.Add(category.category);
                }
            }

            return banner;
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
                            buy_product_Form.Location = new Point(Location.X + 256, Location.Y);
                            return;
                        }
                    }
                }
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                checkedCategories.Add((ProductCategoryEnum)e.Index);
            else
                checkedCategories.Remove((ProductCategoryEnum)e.Index);

            foreach (var banner in banners)
            {
                bool isVisible = checkedCategories.All(category => banner.categories.Contains(category));
                banner.Visible = isVisible;
            }
        }

        private void back_button_MouseClick(object sender, MouseEventArgs e)
        {
            Form_main_menu_tester form = new Form_main_menu_tester();
            form.Show();
            Hide();
        }

        private void back_button_MouseDown(object sender, MouseEventArgs e)
        {
            back_button.BackgroundImage = new Bitmap($"{Application.StartupPath}\\Resources\\buttons\\back_button_clicked.png");
        }
    }
}
