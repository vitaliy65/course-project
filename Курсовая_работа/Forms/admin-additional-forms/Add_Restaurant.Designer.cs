namespace Курсовая_работа.Forms.admin_additional_forms
{
    partial class Add_Restaurant
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
            button1 = new Button();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightGreen;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(111, 295);
            button1.Name = "button1";
            button1.Size = new Size(150, 35);
            button1.TabIndex = 23;
            button1.Text = "Додати";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Tahoma", 12F);
            textBox4.Location = new Point(12, 214);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(360, 27);
            textBox4.TabIndex = 21;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Tahoma", 12F);
            textBox2.Location = new Point(12, 120);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(360, 27);
            textBox2.TabIndex = 20;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Tahoma", 12F);
            textBox3.Location = new Point(12, 167);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(360, 27);
            textBox3.TabIndex = 19;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Tahoma", 12F);
            textBox1.Location = new Point(12, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(360, 27);
            textBox1.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F);
            label5.ForeColor = SystemColors.WindowFrame;
            label5.Location = new Point(12, 244);
            label5.Name = "label5";
            label5.Size = new Size(36, 14);
            label5.TabIndex = 16;
            label5.Text = "Опис";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F);
            label4.ForeColor = SystemColors.WindowFrame;
            label4.Location = new Point(12, 150);
            label4.Name = "label4";
            label4.Size = new Size(38, 14);
            label4.TabIndex = 15;
            label4.Text = "Назва";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F);
            label3.ForeColor = SystemColors.WindowFrame;
            label3.Location = new Point(12, 197);
            label3.Name = "label3";
            label3.Size = new Size(277, 14);
            label3.TabIndex = 14;
            label3.Text = "Час очікування в хвилинах (наприклад: 10 min)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F);
            label2.ForeColor = SystemColors.WindowFrame;
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(197, 14);
            label2.TabIndex = 13;
            label2.Text = "Logo ресторану (шлях до файлу)";
            // 
            // Add_Restaurant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(384, 561);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Add_Restaurant";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_Restaurant";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}