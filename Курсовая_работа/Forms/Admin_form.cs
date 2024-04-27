using Курсовая_работа.Controller;
using Курсовая_работа.EnumCategory;
using Курсовая_работа.Forms.admin_additional_forms;
using Курсовая_работа.model;

namespace Курсовая_работа.Forms
{
    public partial class Admin_form : Form
    {
        ProductController productController;
        ProductCategoryController categoryController;
        RestaurantController restaurantController;

        public Admin_form()
        {
            InitializeComponent();
            InitializationList();
            productController = new ProductController();
            restaurantController = new RestaurantController();
            categoryController = new ProductCategoryController();

            FormClosing += ButtonInteraction.FormClosing;

            UpdateData(dataGridView1, restaurantController.GetElements());
        }

        void InitializationList()
        {
            foreach (var item in Enum.GetValues(typeof(ProductCategoryEnum)))
            {
                checkedListBox1.Items.Add(item);
            }
        }

        private void SelectedData_dataFridView1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0] != null)
            {
                DataGridViewRow data = dataGridView1.SelectedRows[0];
                int restaurantId = Convert.ToInt32(data.Cells["Id"].Value);
                UpdateData(dataGridView2, productController.GetElements().Where(p => p.RestaurantId == restaurantId));
            }
        }

        private void add_product_Click(object sender, EventArgs e)
        {
            new Add_Product().Show();
        }

        private void add_restaurant_Click(object sender, EventArgs e)
        {
            new Add_Restaurant().Show();
        }

        private void Delete_chosen_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0 && dataGridView2.SelectedRows[0] != null)
            {
                int productId = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["Id"].Value);
                productController.RemoveById(productId);
                UpdateData(dataGridView2, productController.GetElements());
            }
            else if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0] != null)
            {
                int restaurantId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                restaurantController.RemoveById(restaurantId);
                UpdateData(dataGridView1, restaurantController.GetElements());
            }
        }

        private void Refresh_data_Click(object sender, EventArgs e)
        {
            UpdateData(dataGridView1, restaurantController.GetElements());
            UpdateData(dataGridView2, productController.GetElements());
        }

        private void change_chosen_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;

            if (dataGridView2.SelectedRows.Count > 0 && dataGridView2.SelectedRows[0] != null)
            {
                PopulateTextBoxes(dataGridView2.SelectedRows[0], true);
            }
            else if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0] != null)
            {
                PopulateTextBoxes(dataGridView1.SelectedRows[0], false);
            }
        }

        private void PopulateTextBoxes(DataGridViewRow row, bool isProduct)
        {
            checkedListBox1.Visible = false;
            checkedListBox1.Enabled = false;
            textBox1.Text = isProduct ? row.Cells["RestaurantId"].Value.ToString() : row.Cells["FilePathImage"].Value.ToString();
            textBox2.Text = row.Cells["Name"].Value.ToString();
            textBox3.Text = isProduct ? row.Cells["Price"].Value.ToString() : row.Cells["timeForCustomer"].Value.ToString();
            textBox4.Text = row.Cells["Description"].Value.ToString();
            textBox5.Text = isProduct ? row.Cells["FilePathimage"].Value.ToString() : "";

            if (isProduct)
            {
                checkedListBox1.Visible = true;
                checkedListBox1.Enabled = true;
                Product product = ExtractProductFromSelectedRow(dataGridView2.SelectedRows[0]);
                
                // Снимаем все галочки в CheckedListBox
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }

                foreach (var productCategory in categoryController.FindAll(c => c.ProductId == product.Id))
                {
                    for (int i = 0; i < checkedListBox1.Items.Count; i++)
                    {
                        if (productCategory.category == Enum.Parse<ProductCategoryEnum>(checkedListBox1.Items[i].ToString()))
                        {
                            checkedListBox1.SetItemChecked(i, true);
                            break;
                        }
                    }
                }
            }
        }

        private void change_save_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;

            try
            {
                if (dataGridView2.SelectedRows.Count > 0 && dataGridView2.SelectedRows[0] != null)
                {
                    Product product = ExtractProductFromSelectedRow(dataGridView2.SelectedRows[0]);
                    productController.Change(product);

                    categoryController.Remove(p => p.ProductId == product.Id);

                    foreach (ProductCategoryEnum item in checkedListBox1.CheckedItems)
                    {
                        ProductCategory productCategory = new();
                        productCategory.ProductId = product.Id;
                        productCategory.category = item;
                        categoryController.Add(productCategory);
                    }
                }
                else if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0] != null)
                {
                    Restaurant restaurant = ExtractRestaurantFromSelectedRow(dataGridView1.SelectedRows[0]);
                    restaurantController.Change(restaurant);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ClearTextBoxes();
        }

        private Product ExtractProductFromSelectedRow(DataGridViewRow row)
        {
            return new Product
            {
                Id = int.Parse(row.Cells["Id"].Value.ToString()),
                RestaurantId = int.Parse(textBox1.Text),
                Name = textBox2.Text,
                Price = float.Parse(textBox3.Text),
                Description = textBox4.Text,
                FilePathimage = textBox5.Text
            };
        }

        private Restaurant ExtractRestaurantFromSelectedRow(DataGridViewRow row)
        {
            return new Restaurant
            {
                Id = int.Parse(row.Cells["Id"].Value.ToString()),
                FilePathimage = textBox1.Text,
                Name = textBox2.Text,
                timeForCustomer = textBox3.Text,
                Description = textBox4.Text
            };
        }

        private void ClearTextBoxes()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void change_cancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            ClearTextBoxes();
        }

        void UpdateData<T>(DataGridView dataGrid, IEnumerable<T> elements)
        {
            dataGrid.DataSource = elements.ToList();
        }
    }
}
