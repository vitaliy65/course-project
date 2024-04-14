using System.Windows.Forms;
using Курсовая_работа.Classes;
using Курсовая_работа.Controller;
using Курсовая_работа.Forms;
using Курсовая_работа.model;

namespace Курсовая_работа
{
    public partial class SignUpForm : Form
    {
        CustomerController customerController;
        PasswordHasher hasher;

        public SignUpForm()
        {
            InitializeComponent();
            hasher = new PasswordHasher();
            customerController = new CustomerController();
            FormClosing += ButtonInteraction.FormClosing;

            button1.MouseDown += ButtonInteraction.MouseDown;
            button1.MouseUp += ButtonInteraction.MouseUp;
            button1.MouseEnter += ButtonInteraction.UpScale_button;
            button1.MouseLeave += ButtonInteraction.DownScale_button;

            linkLabel1.MouseEnter += ButtonInteraction.Registration_MouseOn;
            linkLabel1.MouseLeave += ButtonInteraction.Registration_MouseOff;
        }

        // Посилання на форму реєстрації
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration_form form = new Registration_form();
            form.Location = Location;
            form.Show();
            Hide();
        }

        // Вхід у програму
        private void button1_Click(object sender, EventArgs e)
        {
            IEnumerable<char> temp = textBox1.Text.TakeLast(10);
            string text1 = "";
            bool verifyCustomer = customerController.TryFind(g => (g.gmail == textBox1.Text) && hasher.VerifyPassword(g.password, textBox2.Text));

            foreach (char c in temp)
            {
                text1 += c;
            }

            if (textBox1.Text == "admin_main" && textBox2.Text == "Posvistak")
            {
                Admin_form form = new Admin_form();
                form.Location = Location;
                form.Show();
                Hide();
            }
            else
            if (verifyCustomer)
            {
                Customer? findedCustomer = customerController.Find(customerController.GetElements().Where(g => (g.gmail == textBox1.Text)).First());
                RegistredCustomer.CurrentCustomer = findedCustomer;
                Form_main_menu main_Menu = new Form_main_menu();
                main_Menu.Location = Location;
                main_Menu.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Your email address or password is incorrect, please try again.!");
                panel1.BackColor = Color.Red;
                panel2.BackColor = Color.Red;
            }
        }
    }
}
