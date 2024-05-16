namespace Курсовая_работа.Forms
{
    partial class allMenuForm_tester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(allMenuForm_tester));
            panel1 = new Panel();
            back_button = new Button();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            checkedListBox1 = new CheckedListBox();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 236);
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(back_button);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(checkedListBox1);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1024, 768);
            panel1.TabIndex = 0;
            // 
            // back_button
            // 
            back_button.BackColor = Color.Transparent;
            back_button.BackgroundImage = (Image)resources.GetObject("back_button.BackgroundImage");
            back_button.BackgroundImageLayout = ImageLayout.Stretch;
            back_button.Cursor = Cursors.Hand;
            back_button.FlatAppearance.BorderSize = 0;
            back_button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            back_button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            back_button.FlatStyle = FlatStyle.Flat;
            back_button.Location = new Point(12, 10);
            back_button.Name = "back_button";
            back_button.Size = new Size(48, 48);
            back_button.TabIndex = 41;
            back_button.UseVisualStyleBackColor = false;
            back_button.MouseClick += back_button_MouseClick;
            back_button.MouseDown += back_button_MouseDown;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 255, 236);
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Location = new Point(274, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(650, 680);
            panel2.TabIndex = 39;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(255, 255, 236);
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(650, 680);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = Color.White;
            checkedListBox1.BorderStyle = BorderStyle.None;
            checkedListBox1.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(12, 77);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(174, 648);
            checkedListBox1.TabIndex = 1;
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(396, 23);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // allMenuForm_tester
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 236);
            ClientSize = new Size(1024, 768);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "allMenuForm_tester";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "allMenuForm";
            Load += allMenuForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private CheckedListBox checkedListBox1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button back_button;
        private Button profile_button;
    }
}