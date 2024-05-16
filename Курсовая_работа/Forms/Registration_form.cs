using Курсовая_работа.Controller;
using Курсовая_работа.Forms;
using Курсовая_работа.model;

namespace Курсовая_работа
{
    public partial class Registration_form : Form
    {
        CustomerController customerController;
        PasswordHasher hasher;

        public Registration_form()
        {
            InitializeComponent();
            customerController = new CustomerController();
            hasher = new PasswordHasher();

            FormClosing += ButtonInteraction.FormClosing;

            button1.MouseDown += ButtonInteraction.MouseDown;
            button1.MouseUp += ButtonInteraction.MouseUp;
            button1.MouseEnter += ButtonInteraction.UpScale_button;
            button1.MouseLeave += ButtonInteraction.DownScale_button;
        }

        // ============================================= Обработка Кнопок =============================================
        private void button1_Click(object sender, EventArgs e)
        {
            IEnumerable<char> temp = textBox1.Text.TakeLast(10);
            string text1 = "";

            foreach (char c in temp)
            {
                text1 += c;
            }

            if (text1.Contains("@gmail.com") && textBox1.Text.Length > 10 && textBox2.Text.Length > 5 && textBox3.Text.Length == 18)
            {
                Customer customer = new Customer(gmail: textBox1.Text, password: hasher.HashPassword(textBox2.Text), phone: textBox3.Text);
                customerController.Add(customer);

                Hide();
                SignUpForm form = new SignUpForm();
                form.Show();
            }

            panel4.BackColor = text1.Contains("@gmail.com") && textBox1.Text.Length > 10 ? Color.Green : Color.Red;
            panel2.BackColor = textBox2.Text.Length > 5 ? Color.Green : Color.Red;
            panel3.BackColor = textBox3.Text.Length < 18 ? Color.Red : Color.Green;
        }

        // ============================================= Обработка текст боксов =============================================
        // обработка только цифр в номере телефона
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, является ли введенный символ цифрой или клавишей управления (например, Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Если символ не является цифрой и не является клавишей управления, то игнорируем его
                e.Handled = true;
            }
        }
        // Формат записи телефона   
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            // Проверяем, достаточно ли символов введено для отображения всего шаблона
            if (textBox.Text.Length < 3)
            {
                textBox.Text = "+380(" + textBox.Text; // Добавляем "+380(" в начало текста
                textBox.SelectionStart = textBox.Text.Length; // Перемещаем курсор в конец текста
            }
            else if (textBox.Text.Length == 8)
            {
                textBox.Text += ")-"; // Добавляем ")" после трех цифр кода
                textBox.SelectionStart = textBox.Text.Length; // Перемещаем курсор в конец текста
            }
            else if (textBox.Text.Length == 12 || textBox.Text.Length == 15)
            {
                textBox.Text += "-"; // Добавляем "-" после каждого блока из двух цифр
                textBox.SelectionStart = textBox.Text.Length; // Перемещаем курсор в конец текста
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm form = new SignUpForm();
            form.Show();
            Hide();
        }
    }
}
