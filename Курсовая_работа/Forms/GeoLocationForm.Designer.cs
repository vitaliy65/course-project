namespace Курсовая_работа.Forms
{
    partial class GeoLocationForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeoLocationForm));
            splitContainer1 = new SplitContainer();
            back_button = new Button();
            panel1 = new Panel();
            button_no = new Button();
            button_yes = new Button();
            btnSearch = new Button();
            txtZip = new TextBox();
            txtState = new TextBox();
            txtCity = new TextBox();
            txtStreet = new TextBox();
            pictureBox1 = new PictureBox();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(255, 255, 236);
            splitContainer1.Panel1.Controls.Add(back_button);
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Controls.Add(btnSearch);
            splitContainer1.Panel1.Controls.Add(txtZip);
            splitContainer1.Panel1.Controls.Add(txtState);
            splitContainer1.Panel1.Controls.Add(txtCity);
            splitContainer1.Panel1.Controls.Add(txtStreet);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(webView21);
            splitContainer1.Size = new Size(1064, 768);
            splitContainer1.SplitterDistance = 282;
            splitContainer1.TabIndex = 0;
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
            back_button.Location = new Point(111, 440);
            back_button.Name = "back_button";
            back_button.Size = new Size(48, 48);
            back_button.TabIndex = 42;
            back_button.UseVisualStyleBackColor = false;
            back_button.Click += back_button_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 236);
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(button_no);
            panel1.Controls.Add(button_yes);
            panel1.Location = new Point(16, 774);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 150);
            panel1.TabIndex = 1;
            // 
            // button_no
            // 
            button_no.BackColor = Color.Transparent;
            button_no.BackgroundImage = (Image)resources.GetObject("button_no.BackgroundImage");
            button_no.BackgroundImageLayout = ImageLayout.Zoom;
            button_no.FlatAppearance.BorderSize = 0;
            button_no.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_no.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_no.FlatStyle = FlatStyle.Flat;
            button_no.Location = new Point(49, 95);
            button_no.Name = "button_no";
            button_no.Size = new Size(153, 30);
            button_no.TabIndex = 3;
            button_no.UseVisualStyleBackColor = false;
            button_no.Click += button_no_Click;
            // 
            // button_yes
            // 
            button_yes.BackColor = Color.Transparent;
            button_yes.BackgroundImage = (Image)resources.GetObject("button_yes.BackgroundImage");
            button_yes.BackgroundImageLayout = ImageLayout.Zoom;
            button_yes.FlatAppearance.BorderSize = 0;
            button_yes.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_yes.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_yes.FlatStyle = FlatStyle.Flat;
            button_yes.Location = new Point(49, 54);
            button_yes.Name = "button_yes";
            button_yes.Size = new Size(153, 30);
            button_yes.TabIndex = 2;
            button_yes.UseVisualStyleBackColor = false;
            button_yes.Click += button_yes_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackgroundImage = (Image)resources.GetObject("btnSearch.BackgroundImage");
            btnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(16, 362);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(251, 51);
            btnSearch.TabIndex = 5;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            btnSearch.MouseDown += btnSearch_MouseDown;
            // 
            // txtZip
            // 
            txtZip.BackColor = Color.White;
            txtZip.BorderStyle = BorderStyle.None;
            txtZip.Font = new Font("Tahoma", 12F);
            txtZip.Location = new Point(22, 285);
            txtZip.Multiline = true;
            txtZip.Name = "txtZip";
            txtZip.Size = new Size(238, 23);
            txtZip.TabIndex = 4;
            // 
            // txtState
            // 
            txtState.BackColor = Color.White;
            txtState.BorderStyle = BorderStyle.None;
            txtState.Font = new Font("Tahoma", 12F);
            txtState.Location = new Point(22, 203);
            txtState.Multiline = true;
            txtState.Name = "txtState";
            txtState.Size = new Size(238, 23);
            txtState.TabIndex = 3;
            // 
            // txtCity
            // 
            txtCity.BackColor = Color.White;
            txtCity.BorderStyle = BorderStyle.None;
            txtCity.Font = new Font("Tahoma", 12F);
            txtCity.Location = new Point(22, 120);
            txtCity.Multiline = true;
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(238, 23);
            txtCity.TabIndex = 2;
            // 
            // txtStreet
            // 
            txtStreet.BackColor = Color.White;
            txtStreet.BorderStyle = BorderStyle.None;
            txtStreet.Font = new Font("Tahoma", 12F);
            txtStreet.Location = new Point(22, 43);
            txtStreet.Multiline = true;
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(238, 23);
            txtStreet.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(16, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 310);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // webView21
            // 
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Dock = DockStyle.Fill;
            webView21.Location = new Point(0, 0);
            webView21.Name = "webView21";
            webView21.Size = new Size(778, 768);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // GeoLocationForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(255, 255, 236);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1064, 768);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "GeoLocationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GeoLocationForm";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private PictureBox pictureBox1;
        private TextBox txtZip;
        private TextBox txtState;
        private TextBox txtCity;
        private TextBox txtStreet;
        private Button btnSearch;
        private Panel panel1;
        private Button button_yes;
        private Button button_no;
        private System.Windows.Forms.Timer timer1;
        private Button back_button;
    }
}