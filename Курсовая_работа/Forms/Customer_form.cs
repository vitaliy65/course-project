using image_description_button;
using System.Windows.Forms;
using Курсовая_работа.Classes;
using Курсовая_работа.model;

namespace Курсовая_работа.Forms
{
    public partial class Customer_form : Form
    {
        float total_price = 0;
        public Customer_form()
        {
            InitializeComponent();
            label4.Text = "0 грн";
            InitializeCart();
            InitializeCustomer();
            FormClosing += ButtonInteraction.FormClosing;
            button1.MouseEnter += ButtonInteraction.UpScale_button;
            button1.MouseLeave += ButtonInteraction.DownScale_button;
            button2.MouseEnter += ButtonInteraction.UpScale_button;
            button2.MouseLeave += ButtonInteraction.DownScale_button;
            button3.MouseEnter += ButtonInteraction.UpScale_button;
            button3.MouseLeave += ButtonInteraction.DownScale_button;
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
                    listItem.label_Name = "\""+ product.Name + "\"";
                    listItem.label_Price = product.Price.ToString() + " грн";
                    total_price += product.Price;
                    // Добавляем listItemBanner в FlowLayoutPanel
                    flowLayoutPanel1.Controls.Add(listItem);
                }
            }

            label4.Text = Math.Round(total_price, 2).ToString() + " грн";
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
            label4.Text = "0 грн";
        }
    }
}
