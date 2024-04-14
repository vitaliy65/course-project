using image_description_button;
using System.Windows.Forms;
using Курсовая_работа.Classes;
using Курсовая_работа.model;

namespace Курсовая_работа.Forms
{
    public partial class Customer_form : Form
    {
        public Customer_form()
        {
            InitializeComponent();
            InitializeCart();
            InitializeCustomer();
            FormClosing += ButtonInteraction.FormClosing;
        }

        private void InitializeCustomer()
        {
            label1.Text = RegistredCustomer.CurrentCustomer.gmail;
            label2.Text = RegistredCustomer.CurrentCustomer.phone;
            label3.Text = $"{RegistredCustomer.CurrentCustomer.Latitude} / {RegistredCustomer.CurrentCustomer.Longitude}";
        }

        private void InitializeCart()
        {
            flowLayoutPanel1.Controls.Clear(); // Очищаем все элементы из FlowLayoutPanel
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.WrapContents = true;

            if (RegistredCustomer.cartCount() != 0)
            {
                foreach (var product in RegistredCustomer.Cart)
                {
                    // Создаем новый экземпляр listItemBanner
                    listItemBanner listItem = new listItemBanner();
                    // Настраиваем его свойства на основе данных продукта
                    listItem.Productimage = new Bitmap($"{Application.StartupPath}\\{product.FilePathimage}");
                    // Добавляем listItemBanner в FlowLayoutPanel
                    flowLayoutPanel1.Controls.Add(listItem);
                }
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.BackgroundImage = new Bitmap($"{Application.StartupPath}\\Resources\\buttons\\button_back_clicked.png");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form_main_menu form = new Form_main_menu();
            form.Show();
            form.Location = Location;
            Hide();
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            button2.BackgroundImage = new Bitmap($"{Application.StartupPath}\\Resources\\buttons\\button_buy_clicked.png");
        }
        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            button2.BackgroundImage = new Bitmap($"{Application.StartupPath}\\Resources\\buttons\\button_buy.png");
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            button3.BackgroundImage = new Bitmap($"{Application.StartupPath}\\Resources\\buttons\\button_clear_clicked.png");
        }
        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            button3.BackgroundImage = new Bitmap($"{Application.StartupPath}\\Resources\\buttons\\button_clear.png");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            RegistredCustomer.ClearCart();
            flowLayoutPanel1.Controls.Clear();
        }
    }
}
