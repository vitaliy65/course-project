namespace image_description_button
{
    partial class ProductBanner
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 115);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseEnter += forMouseEnter;
            pictureBox1.MouseLeave += forMouseLeave;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F);
            label1.ForeColor = SystemColors.InfoText;
            label1.Location = new Point(5, 6);
            label1.Name = "label1";
            label1.Size = new Size(34, 16);
            label1.TabIndex = 0;
            label1.Text = "label";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 152, 0);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 115);
            panel2.Name = "panel2";
            panel2.Size = new Size(205, 50);
            panel2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AllowDrop = true;
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F);
            label3.ForeColor = SystemColors.InfoText;
            label3.Location = new Point(45, 29);
            label3.Name = "label3";
            label3.Size = new Size(26, 16);
            label3.TabIndex = 1;
            label3.Text = "грн";
            // 
            // label2
            // 
            label2.AllowDrop = true;
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F);
            label2.ForeColor = SystemColors.InfoText;
            label2.Location = new Point(5, 29);
            label2.Name = "label2";
            label2.Size = new Size(34, 16);
            label2.TabIndex = 0;
            label2.Text = "label";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(205, 165);
            panel1.TabIndex = 2;
            panel1.Paint += RestaurantBanner_Paint;
            // 
            // ProductBanner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ProductBanner";
            Size = new Size(205, 165);
            Load += ProductBanner_Load;
            Paint += RestaurantBanner_Paint;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Panel panel1;
        private Label label2;
        private Label label3;
    }
}
