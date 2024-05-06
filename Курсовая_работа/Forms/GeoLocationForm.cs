using System.Text;
using Курсовая_работа.Classes;

namespace Курсовая_работа.Forms
{
    public partial class GeoLocationForm : Form
    {
        private int animationStep = 6; // Шаг анимации
        private int animationDirection = 1; // Направление анимации (1 - вверх, -1 - вниз)

        public GeoLocationForm()
        {
            InitializeComponent();
            btnSearch.MouseEnter += ButtonInteraction.UpScale_button;
            btnSearch.MouseLeave += ButtonInteraction.DownScale_button;
            button_no.MouseEnter += ButtonInteraction.UpScale_button;
            button_no.MouseLeave += ButtonInteraction.DownScale_button;
            button_yes.MouseEnter += ButtonInteraction.UpScale_button;
            button_yes.MouseLeave += ButtonInteraction.DownScale_button;
            back_button.MouseEnter += ButtonInteraction.UpScale_button;
            back_button.MouseLeave += ButtonInteraction.DownScale_button;
            timer1.Interval = 1; // Установите интервал таймера
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string street = txtStreet.Text;
            string city = txtCity.Text;
            string state = txtState.Text;
            string zip = txtZip.Text;

            StringBuilder queryAddress = new StringBuilder();
            queryAddress.Append("http://google.com/maps?q=");

            if (street != string.Empty)
            {
                queryAddress.Append($"{street},+");
                RegistredCustomer.CurrentCustomer.street = street;
            }
            if (city != string.Empty)
            {
                queryAddress.Append($"{city},+");
                RegistredCustomer.CurrentCustomer.city = city;
            }
            if (state != string.Empty)
            {
                queryAddress.Append($"{state},+");
                RegistredCustomer.CurrentCustomer.regionName = state;
            }
            if (zip != string.Empty) queryAddress.Append($"{zip},+");

            // Запустить анимацию подъема панели
            if (panel1.Top < ClientSize.Height) animationDirection = 0;
            else animationDirection = -1;
            timer1.Start();

            webView21.Source = new Uri(queryAddress.ToString());
        }
        private void btnSearch_MouseDown(object sender, MouseEventArgs e)
        {
            btnSearch.BackgroundImage = new Bitmap($"{Application.StartupPath}\\Resources\\buttons\\submitLocationButton_clicked.png");
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            // Изменить свойство Top панели в зависимости от направления анимации
            if (animationDirection != 0) panel1.Top += animationStep * animationDirection;

            // Остановить анимацию, если панель достигла определенной позиции
            if (panel1.Top >= ClientSize.Height && animationDirection == 1)
            {
                timer1.Stop();
                animationDirection = 0;
            }
            else if (panel1.Bottom <= ClientSize.Height && animationDirection == -1)
            {
                timer1.Stop();
                animationDirection = 0;
            }
        }


        private void button_yes_Click(object sender, EventArgs e)
        {
            // Запустить анимацию опускания панели
            animationDirection = 1;
            timer1.Start();
            Form_main_menu form_Main_Menu = new Form_main_menu();
            form_Main_Menu.Show();
            Hide();
        }
        private void button_no_Click(object sender, EventArgs e)
        {
            // Запустить анимацию опускания панели
            animationDirection = 1;
            timer1.Start();
            RegistredCustomer.CurrentCustomer.street = "none";
            RegistredCustomer.CurrentCustomer.city = "none";
            RegistredCustomer.CurrentCustomer.regionName = "none";
        }


        private void back_button_Click(object sender, EventArgs e)
        {
            Form_main_menu form_Main_Menu = new Form_main_menu();
            form_Main_Menu.Show();
            Hide();
        }
    }
}
