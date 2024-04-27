namespace Курсовая_работа
{
    partial class Form_main_menu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main_menu));
            Location_button = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button4 = new Button();
            panel3 = new Panel();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // Location_button
            // 
            Location_button.BackColor = Color.Transparent;
            Location_button.BackgroundImage = (Image)resources.GetObject("Location_button.BackgroundImage");
            Location_button.BackgroundImageLayout = ImageLayout.Zoom;
            Location_button.Cursor = Cursors.Hand;
            Location_button.FlatAppearance.BorderSize = 0;
            Location_button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Location_button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Location_button.FlatStyle = FlatStyle.Flat;
            Location_button.Location = new Point(641, 90);
            Location_button.Name = "Location_button";
            Location_button.Size = new Size(153, 153);
            Location_button.TabIndex = 45;
            Location_button.UseVisualStyleBackColor = false;
            Location_button.Click += Location_button_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(436, 90);
            button2.Name = "button2";
            button2.Size = new Size(153, 153);
            button2.TabIndex = 44;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.menu_button__food_2;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(230, 90);
            button1.Name = "button1";
            button1.Size = new Size(153, 153);
            button1.TabIndex = 43;
            button1.UseVisualStyleBackColor = false;
            button1.Click += All_menu_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Location = new Point(54, 300);
            panel2.Name = "panel2";
            panel2.Size = new Size(960, 430);
            panel2.TabIndex = 39;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(960, 430);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button4.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(964, 12);
            button4.Name = "button4";
            button4.Size = new Size(48, 48);
            button4.TabIndex = 13;
            button4.UseVisualStyleBackColor = false;
            button4.Click += Profile_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(Location_button);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(panel2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1024, 768);
            panel3.TabIndex = 46;
            // 
            // Form_main_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1024, 768);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form_main_menu";
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button button4;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button Location_button;
        private Button button2;
        private Panel panel3;
    }
}