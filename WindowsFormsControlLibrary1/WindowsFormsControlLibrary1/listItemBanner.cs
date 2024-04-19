using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace image_description_button
{
    public partial class listItemBanner : UserControl
    {
        [Browsable(true)]
        [Category("Custom Properties")]
        public Image Productimage { get; set; }

        [Browsable(true)]
        [Category("Custom Properties")]
        public string label_Name { get; set; }

        [Browsable(true)]
        [Category("Custom Properties")]
        public string label_Price { get; set; }

        public listItemBanner()
        {
            InitializeComponent();
        }

        private void ProductBanner_Load(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Productimage;
            label1.Text = label_Name;
            label2.Text = label_Price;
        }
    }
}
