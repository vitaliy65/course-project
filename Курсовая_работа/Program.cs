using Курсовая_работа.Classes;
using Курсовая_работа.Forms;

namespace Курсовая_работа
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            SignUpForm signUpForm = new ();
            Form_main_menu main_menu = new();

            // Проверяем, нужно ли скрыть форму
            if (RegistredCustomer.CurrentCustomer != null && RegistredCustomer.CurrentCustomer.RememberMeFlag)
            {
                Application.Run(main_menu);
            }
            else
            {
                Application.Run(signUpForm);
            }
        }
    }
}