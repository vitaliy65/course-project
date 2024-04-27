namespace Курсовая_работа.Forms
{
    partial class Admin_form
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
            panel1 = new Panel();
            panel2 = new Panel();
            button7 = new Button();
            button6 = new Button();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            button5 = new Button();
            button4 = new Button();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            checkedListBox1 = new CheckedListBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PeachPuff;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(dataGridView2);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1541, 768);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Bisque;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(checkedListBox1);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(1152, 244);
            panel2.Name = "panel2";
            panel2.Size = new Size(373, 512);
            panel2.TabIndex = 16;
            panel2.Visible = false;
            // 
            // button7
            // 
            button7.BackColor = Color.Tomato;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button7.Location = new Point(3, 467);
            button7.Name = "button7";
            button7.Size = new Size(367, 35);
            button7.TabIndex = 18;
            button7.Text = "Cancel operation";
            button7.UseVisualStyleBackColor = false;
            button7.Click += change_cancel_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.MediumSeaGreen;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button6.Location = new Point(3, 426);
            button6.Name = "button6";
            button6.Size = new Size(367, 35);
            button6.TabIndex = 17;
            button6.Text = "Save changes";
            button6.UseVisualStyleBackColor = false;
            button6.Click += change_save_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(3, 119);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(367, 23);
            textBox5.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(3, 61);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(367, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(3, 90);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(367, 23);
            textBox4.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 32);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(367, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(367, 23);
            textBox1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F);
            label3.ForeColor = SystemColors.WindowFrame;
            label3.Location = new Point(1188, 197);
            label3.Name = "label3";
            label3.Size = new Size(305, 14);
            label3.TabIndex = 15;
            label3.Text = "натиснути після будь яких маніпуляцій зі вмістом БД";
            // 
            // button5
            // 
            button5.BackColor = Color.SkyBlue;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button5.Location = new Point(1152, 159);
            button5.Name = "button5";
            button5.Size = new Size(373, 35);
            button5.TabIndex = 11;
            button5.Text = "Refresh";
            button5.UseVisualStyleBackColor = false;
            button5.Click += Refresh_data_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.SkyBlue;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button4.Location = new Point(1345, 101);
            button4.Name = "button4";
            button4.Size = new Size(180, 35);
            button4.TabIndex = 10;
            button4.Text = "Change chosen";
            button4.UseVisualStyleBackColor = false;
            button4.Click += change_chosen_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(583, 41);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(535, 715);
            dataGridView2.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(535, 715);
            dataGridView1.TabIndex = 8;
            dataGridView1.SelectionChanged += SelectedData_dataFridView1;
            // 
            // button3
            // 
            button3.BackColor = Color.SkyBlue;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.Location = new Point(1345, 41);
            button3.Name = "button3";
            button3.Size = new Size(180, 35);
            button3.TabIndex = 6;
            button3.Text = "Delete chosen";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Delete_chosen_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SkyBlue;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(1152, 101);
            button2.Name = "button2";
            button2.Size = new Size(180, 35);
            button2.TabIndex = 5;
            button2.Text = "Add Product";
            button2.UseVisualStyleBackColor = false;
            button2.Click += add_product_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SkyBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(1152, 41);
            button1.Name = "button1";
            button1.Size = new Size(180, 35);
            button1.TabIndex = 4;
            button1.Text = "Add Restaurant";
            button1.UseVisualStyleBackColor = false;
            button1.Click += add_restaurant_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(583, 17);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 3;
            label2.Text = "Products";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(92, 21);
            label1.TabIndex = 2;
            label1.Text = "Restaurants";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F);
            label6.ForeColor = SystemColors.WindowFrame;
            label6.Location = new Point(5, 335);
            label6.Name = "label6";
            label6.Size = new Size(55, 14);
            label6.TabIndex = 20;
            label6.Text = "категорії";
            // 
            // checkedListBox1
            // 
            checkedListBox1.Enabled = false;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(3, 148);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.ScrollAlwaysVisible = true;
            checkedListBox1.Size = new Size(367, 184);
            checkedListBox1.TabIndex = 19;
            checkedListBox1.Visible = false;
            // 
            // Admin_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1541, 768);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Admin_form";
            Text = "Admin_form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button button4;
        private Button button5;
        private Label label3;
        private Panel panel2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button7;
        private Button button6;
        private TextBox textBox5;
        private Label label6;
        private CheckedListBox checkedListBox1;
    }
}