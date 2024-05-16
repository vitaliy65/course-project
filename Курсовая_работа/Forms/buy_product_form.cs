using Курсовая_работа.Classes;
using Курсовая_работа.model;

namespace Курсовая_работа.Forms
{
    public partial class buy_product_form : Form
    {
        Product thisProduct = null;

        public buy_product_form(Product product)
        {
            thisProduct = product;
            InitializeComponent();
            InitializeInformation();
            button1.MouseEnter += ButtonInteraction.UpScale_button;
            button1.MouseLeave += ButtonInteraction.DownScale_button;
        }

        private void InitializeInformation()
        {
            if(thisProduct != null)
            {
                label1.Text = $"Ціна: {thisProduct.Price} грн.";
                label2.Text = $"Назва: {thisProduct.Name}";
                textBox1.Text = thisProduct.Description;
                try
                {
                    pictureBox1.BackgroundImage = new Bitmap($"{Application.StartupPath}\\{thisProduct.FilePathimage}");
                }
                catch (Exception exp)
                {
                    MessageBox.Show("невалідна картинка!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            RegistredCustomer.addProductInCart(thisProduct);
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.BackgroundImage = new Bitmap($"{Application.StartupPath}\\Resources\\buttons\\Buy_clicked.png");
        }
    }
}
