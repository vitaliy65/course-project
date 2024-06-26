﻿using System.Windows.Forms;
using Курсовая_работа.Controller;
using Курсовая_работа.EnumCategory;
using Курсовая_работа.model;

namespace Курсовая_работа.Forms.admin_additional_forms
{
    public partial class Add_Product : Form
    {
        ProductController productController;
        ProductCategoryController categoryController;
        readonly RestaurantController restaurantController;

        public Add_Product()
        {
            InitializeComponent();
            InitializationList();
            productController = new ProductController();
            restaurantController = new RestaurantController();
            categoryController = new ProductCategoryController();
            dataGridView1.DataSource = restaurantController.GetElements().ToList();
        }

        void InitializationList()
        {
            foreach (var item in Enum.GetValues(typeof(ProductCategoryEnum)))
            {
                checkedListBox1.Items.Add(item);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Restaurant restaurant = null;
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0] != null)
            {
                DataGridViewRow data = dataGridView1.SelectedRows[0];
                textBox1.Text = data.Cells["Id"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            try
            {
                product.RestaurantId = Convert.ToInt32(textBox1.Text);
                product.FilePathimage = textBox2.Text;
                product.Price = float.Parse(textBox3.Text);
                product.Name = textBox4.Text;
                product.Description = textBox5.Text;

                productController.Add(product);
                Close();

                foreach (var item in checkedListBox1.CheckedItems)
                {
                    ProductCategory productCategory = new();
                    productCategory.ProductId = product.Id;
                    productCategory.category = Enum.Parse<ProductCategoryEnum>(item.ToString());
                    categoryController.Add(productCategory);
                }
            }
            catch (Exception xp)
            {
                MessageBox.Show(xp.Message);
            }
        }
    }
}
