using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace image_description_button
{
    public partial class RestaurantBanner : UserControl
    {
        [Browsable(true)]
        [Category("Custom Properties")]
        public Image image { get; set; }

        [Browsable(true)]
        [Category("Custom Properties")]
        public string label_description { get; set; }

        public EventHandler bannerAction;

        public RestaurantBanner()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = image;
            pictureBox2.BackgroundImage = image;

            label1.Text = label_description;

            pictureBox2.Click += bannerAction;
        }

        private void forMouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            pictureBox2.Visible = false;
            pictureBox2.Enabled = true;
            pictureBox2.Visible = true;
        }

        private void forMouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Enabled = true;
            pictureBox2.Visible = true;
            pictureBox2.Enabled = false;
            pictureBox2.Visible = false;
        }
    }
}
