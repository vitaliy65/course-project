using Курсовая_работа.Controller;
using Курсовая_работа.model;

namespace Курсовая_работа.Forms.admin_additional_forms
{
    public partial class Add_Restaurant : Form
    {
        RestaurantController restaurantController;

        public Add_Restaurant()
        {
            InitializeComponent();
            restaurantController = new RestaurantController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Restaurant restaurant = new Restaurant();

            try
            {
                restaurant.FilePathimage = textBox1.Text;
                restaurant.Name = textBox2.Text;
                restaurant.timeForCustomer = textBox3.Text;
                restaurant.Description = textBox4.Text;

                restaurantController.Add(restaurant);
                Close();
            }
            catch (Exception xp)
            {
                MessageBox.Show(xp.Message);
            }
        }
    }
}
