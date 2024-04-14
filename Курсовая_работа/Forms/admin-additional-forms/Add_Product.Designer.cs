namespace Курсовая_работа.Forms.admin_additional_forms
{
    partial class Add_Product
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(12, 61);
            label1.Name = "label1";
            label1.Size = new Size(197, 14);
            label1.TabIndex = 0;
            label1.Text = "Id ресторану (вибрати у таблиці)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F);
            label2.ForeColor = SystemColors.WindowFrame;
            label2.Location = new Point(12, 113);
            label2.Name = "label2";
            label2.Size = new Size(193, 14);
            label2.TabIndex = 1;
            label2.Text = "Фото продукту (шлях до файлу)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F);
            label3.ForeColor = SystemColors.WindowFrame;
            label3.Location = new Point(12, 165);
            label3.Name = "label3";
            label3.Size = new Size(86, 14);
            label3.TabIndex = 2;
            label3.Text = "Ціна продукту";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F);
            label4.ForeColor = SystemColors.WindowFrame;
            label4.Location = new Point(12, 217);
            label4.Name = "label4";
            label4.Size = new Size(38, 14);
            label4.TabIndex = 3;
            label4.Text = "Назва";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F);
            label5.ForeColor = SystemColors.WindowFrame;
            label5.Location = new Point(12, 269);
            label5.Name = "label5";
            label5.Size = new Size(36, 14);
            label5.TabIndex = 4;
            label5.Text = "Опис";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Tahoma", 12F);
            textBox1.Location = new Point(12, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(360, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Tahoma", 12F);
            textBox2.Location = new Point(12, 83);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(360, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Tahoma", 12F);
            textBox3.Location = new Point(12, 135);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(360, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Tahoma", 12F);
            textBox4.Location = new Point(12, 187);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(360, 27);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Tahoma", 12F);
            textBox5.Location = new Point(12, 239);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(360, 27);
            textBox5.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(423, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 518);
            dataGridView1.TabIndex = 10;
            dataGridView1.CurrentCellChanged += dataGridView1_SelectionChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGreen;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(111, 305);
            button1.Name = "button1";
            button1.Size = new Size(150, 35);
            button1.TabIndex = 11;
            button1.Text = "Додати";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Add_Product
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(674, 561);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Add_Product";
            Text = "add_Product";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private DataGridView dataGridView1;
        private Button button1;
    }
}