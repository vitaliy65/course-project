using image_description_button;
using Курсовая_работа.Controller;
using Курсовая_работа.Forms;
using Курсовая_работа.model;

namespace Курсовая_работа
{
    public partial class Form_main_menu : Form
    {
        RestaurantController controller;

        public Form_main_menu()
        {
            InitializeComponent();
            FormClosing += ButtonInteraction.FormClosing;
            controller = new RestaurantController();
            RestaurantBanner[] restaurantBanners = { restaurantBanner1, restaurantBanner2, restaurantBanner3, restaurantBanner4, restaurantBanner5, restaurantBanner6, restaurantBanner7, restaurantBanner8 };
            InstantiateAllUserControls(restaurantBanners);
        }

        void InstantiateAllUserControls(RestaurantBanner[] restaurantBanners)
        {
            int i = 0;
            var restaurants = controller.GetElements().ToArray();
            for (i = 0; i < restaurants.Count(); i++)
            {
                restaurantBanners[i].Enabled = true;
                restaurantBanners[i].Visible = true;
                restaurantBanners[i].Tag = restaurants[i].Id;
                restaurantBanners[i].label_description = restaurants[i].Name;
                restaurantBanners[i].bannerAction += RestaurantBanner_click;

                // Получение изображения из файла и присвоение его переменной image
                try
                {
                    string imagePath = restaurants[i].FilePathimage;
                    restaurantBanners[i].image = new Bitmap($"{Application.StartupPath}\\{imagePath}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); // Пример
                }
            }

            for (; i < restaurantBanners.Count(); i++)
            {
                restaurantBanners[i].Enabled = false;
                restaurantBanners[i].Visible = false;
            }
        }

        void RestaurantBanner_click(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                // Получаем родительский контрол PictureBox, который должен быть экземпляром RestaurantBanner
                var restaurantBanner = pictureBox.Parent.Parent as RestaurantBanner;

                // Проверяем, является ли родительский контрол PictureBox экземпляром RestaurantBanner
                if (restaurantBanner != null)
                {
                    foreach (var restaurant in controller.GetElements())
                    {
                        if (restaurant.Id == int.Parse(restaurantBanner.Tag.ToString()))
                        {
                            Products_form products_Form = new Products_form(restaurant);
                            products_Form.Show();
                            products_Form.Location = Location;
                            Hide();
                            return;
                        }
                    }
                }
            }
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
