﻿using image_description_button;
using Microsoft.Web.WebView2.Core;
using System.Diagnostics;
using System.Windows.Forms;
using Курсовая_работа.Classes;
using Курсовая_работа.Controller;
using Курсовая_работа.Forms;
using Курсовая_работа.model;

namespace Курсовая_работа
{
    public partial class Form_main_menu_tester : Form
    {
        RestaurantController controller;

        public Form_main_menu_tester()
        {
            InitializeComponent();
            controller = new RestaurantController();
            button1.MouseEnter += ButtonInteraction.UpScale_button;
            button1.MouseLeave += ButtonInteraction.DownScale_button;
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
                            Products_form_tester products_Form = new Products_form_tester(restaurant);
                            products_Form.Show();
                            Hide();
                            return;
                        }
                    }
                }
            }
        }

        private void All_menu_Click(object sender, EventArgs e)
        {
            allMenuForm_tester form = new allMenuForm_tester();
            form.Show();
            Hide();
        }
    }
}
