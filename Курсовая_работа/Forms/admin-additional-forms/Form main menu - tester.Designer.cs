namespace Курсовая_работа
{
    partial class Form_main_menu_tester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main_menu_tester));
            button1 = new Button();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel3 = new Panel();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
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
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(webView21);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(panel2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1024, 768);
            panel3.TabIndex = 46;
            // 
            // webView21
            // 
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(-16, -9);
            webView21.Name = "webView21";
            webView21.Size = new Size(0, 0);
            webView21.TabIndex = 46;
            webView21.ZoomFactor = 1D;
            // 
            // Form_main_menu_tester
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1024, 768);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form_main_menu_tester";
            StartPosition = FormStartPosition.CenterScreen;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Panel panel3;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}