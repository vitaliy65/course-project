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

        // Вход пользователя
        private void button1_Click(object sender, EventArgs e)
        {
            string gmail = textBox1.Text;
            string password = textBox2.Text;
            Customer? verifyCustomer = customerController.Find(g => (g.gmail == gmail) && hasher.VerifyPassword(g.password, password));

            if (textBox1.Text == "admin_main" && password == "Posvistak")
            {
                OpenAdminForm();
            }
            else if (verifyCustomer != null)
            {
                RegistredCustomer.CurrentCustomer = verifyCustomer;
                if (checkBox1.Checked)
                {
                    // Обновляем флаг RememberMe при необходимости
                    verifyCustomer.RememberMeFlag = true;
                    customerController.Change(verifyCustomer);
                    RegistredCustomer.SaveUserData();
                }
                OpenMainForm();
            }
            else
            {
                MessageBox.Show("Your email address or password is incorrect, please try again.!");
                panel1.BackColor = Color.Red;
                panel2.BackColor = Color.Red;
            }
        }

        void OpenAdminForm()
        {
            Admin_form form = new Admin_form();
            form.Location = Location;
            form.Show();
            Hide();
        }

        void OpenMainForm()
        {
            Form_main_menu main_Menu = new Form_main_menu();
            main_Menu.Location = Location;
            main_Menu.Show();
            Hide();
        }
    }
}
