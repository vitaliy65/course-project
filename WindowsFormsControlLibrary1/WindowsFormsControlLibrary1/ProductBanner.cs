﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace image_description_button
{
    public partial class ProductBanner : UserControl
    {
        [Browsable(true)]
        [Category("Custom Properties")]
        public Image Productimage { get; set; }

        [Browsable(true)]
        [Category("Custom Properties")]
        public string label_Name { get; set; }

        [Browsable(true)]
        [Category("Custom Properties")]
        public string label_Price { get; set; }

        public EventHandler ProductBannerAction;
        public List<ProductCategoryEnum> categories { get; set; }

        public ProductBanner()
        {
            InitializeComponent();
            categories = new List<ProductCategoryEnum>();
        }

        private void ProductBanner_Load(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Productimage;
            label1.Text = label_Name;
            label2.Text = label_Price;
            pictureBox1.Click += ProductBannerAction;
        }

        private void forMouseEnter(object sender, EventArgs e)
        {
            int increaseAmount = (int)(pictureBox1.Width * 0.03); // Вычисление увеличения на 3% для каждой стороны

            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize; // Установка размера pictureBox1 в соответствии с размером изображения
            pictureBox1.Left -= increaseAmount; // Сдвиг pictureBox1 влево
            pictureBox1.Top -= increaseAmount; // Сдвиг pictureBox1 вверх
            pictureBox1.Width += 2 * increaseAmount; // Увеличение ширины pictureBox1
            pictureBox1.Height += 2 * increaseAmount; // Увеличение высоты pictureBox1
            Invalidate();
        }

        private void forMouseLeave(object sender, EventArgs e)
        {
            int decreaseAmount = (int)(pictureBox1.Width * 0.03); // Вычисление уменьшения на 3% для каждой стороны

            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize; // Установка размера pictureBox1 в соответствии с размером изображения
            pictureBox1.Left += decreaseAmount; // Сдвиг pictureBox1 вправо
            pictureBox1.Top += decreaseAmount; // Сдвиг pictureBox1 вниз
            pictureBox1.Width -= 2 * decreaseAmount; // Уменьшение ширины pictureBox1
            pictureBox1.Height -= 2 * decreaseAmount; // Уменьшение высоты pictureBox1
            Invalidate();
        }
    }
}
