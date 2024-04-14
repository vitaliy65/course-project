using System.ComponentModel;

namespace image_description_button
{
    public partial class listItemBanner : UserControl
    {
        [Browsable(true)]
        [Category("Custom Properties")]
        public Image Productimage { get; set; }

        public listItemBanner()
        {
            InitializeComponent();
        }

        private void ProductBanner_Load(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Productimage;
        }
    }
}
