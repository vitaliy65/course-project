using image_description_button;
using System.Diagnostics;
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
            button1.MouseEnter += ButtonInteraction.UpScale_button;
            button1.MouseLeave += ButtonInteraction.DownScale_button;
            button2.MouseEnter += ButtonInteraction.UpScale_button;
            button2.MouseLeave += ButtonInteraction.DownScale_button;
            Location_button.MouseEnter += ButtonInteraction.UpScale_button;
            Location_button.MouseLeave += ButtonInteraction.DownScale_button;
            button4.MouseEnter += ButtonInteraction.UpScale_button;
            button4.MouseLeave += ButtonInteraction.DownScale_button;
            InstantiateAllUserControls();
        }

        void InstantiateAllUserControls()
        {
            var restaurants = controller.GetElements().ToArray();
            flowLayoutPanel1.WrapContents = true;

            foreach (var restaurant in restaurants)
            {
                RestaurantBanner banner = new RestaurantBanner();
                // Настраиваем его свойства на основе данных продукта
                try
                {
                    banner.image = new Bitmap($"{Application.StartupPath}\\{restaurant.FilePathimage}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                banner.Tag = restaurant.Id;
                banner.label_description = restaurant.Name;
                banner.bannerAction += RestaurantBanner_click;
                // Добавляем listItemBanner в FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(banner);
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

        private void Profile_Click(object sender, EventArgs e)
        {
            Customer_form form = new Customer_form();
            form.Show();
            form.Location = Location;
            Hide();
        }

        private void All_menu_Click(object sender, EventArgs e)
        {
            allMenuForm form = new allMenuForm();
            form.Show();
            form.Location = Location;
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string channelLink = "https://t.me/MyFirst_KHAI_Bot";

            try
            {
                // Запускаем стандартное приложение браузера с ссылкой на канал
                Process.Start(new ProcessStartInfo
                {
                    FileName = channelLink,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                // В случае ошибки выводим сообщение или обрабатываем исключение
                MessageBox.Show("Ошибка при открытии ссылки: " + ex.Message);
            }
        }

        private void Location_button_Click(object sender, EventArgs e)
        {
            _ = ButtonInteraction.GetLocationAsync();
        }
    }
}
