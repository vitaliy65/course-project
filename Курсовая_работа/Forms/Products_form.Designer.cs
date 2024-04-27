namespace Курсовая_работа.Forms
{
    partial class Products_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products_form));
            panel1 = new Panel();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            Label4 = new LinkLabel();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            button4 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.new_Form_food;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(Label4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1024, 768);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Location = new Point(88, 354);
            panel2.Name = "panel2";
            panel2.Size = new Size(860, 380);
            panel2.TabIndex = 38;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(860, 380);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // Label4
            // 
            Label4.ActiveLinkColor = Color.FromArgb(255, 128, 0);
            Label4.AutoSize = true;
            Label4.BackColor = Color.Transparent;
            Label4.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Label4.LinkColor = Color.FromArgb(64, 0, 0);
            Label4.Location = new Point(455, 18);
            Label4.Name = "Label4";
            Label4.Size = new Size(123, 25);
            Label4.TabIndex = 37;
            Label4.TabStop = true;
            Label4.Text = "Registration";
            Label4.VisitedLinkColor = Color.FromArgb(128, 128, 255);
            Label4.LinkClicked += Label4_LinkClicked;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.ForeColor = Color.DarkGray;
            textBox1.Location = new Point(39, 216);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(956, 81);
            textBox1.TabIndex = 35;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(45, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 54);
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(73, 148);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 16;
            label2.Text = "Time";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(39, 106);
            label1.Name = "label1";
            label1.Size = new Size(84, 33);
            label1.TabIndex = 15;
            label1.Text = "Name";
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(965, 10);
            button4.Name = "button4";
            button4.Size = new Size(48, 48);
            button4.TabIndex = 14;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Products_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 768);
            Controls.Add(panel1);
            Name = "Products_form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button button4;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private LinkLabel Label4;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}