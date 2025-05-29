using BlApi;
using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ProductMenu : Form
    {
        private static IBl _bl = BlApi.Factory.Get();
        public ProductMenu()
        {
            InitializeComponent();
        }

        private void productIdA_Click(object sender, EventArgs e)
        {

        }

        private void endSaleDate_ValueChanged(object sender, EventArgs e)
        {
        }

        private void beginSaleDate_ValueChanged(object sender, EventArgs e)
        {
        }

        private void no_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void yes_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void priceN_ValueChanged(object sender, EventArgs e)
        {
        }

        private void minQuantityN_ValueChanged(object sender, EventArgs e)
        {
        }

        private void productIdL_TextChanged(object sender, EventArgs e)
        {
        }

        private void endSale_Click(object sender, EventArgs e)
        {
        }

        private void beginSale_Click(object sender, EventArgs e)
        {
        }

        private void price_Click(object sender, EventArgs e)
        {
        }

        private void inClab_Click(object sender, EventArgs e)
        {
        }

        private void minQuantity_Click(object sender, EventArgs e)
        {
        }

        private void addSaleBtn_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            int custId, custPhone;

            Product product = new Product()
            {
                ProductName = productName.Text,
                Category = (Categories)Enum.Parse(typeof(Categories), category.Text),
                Price = (double)priceProduct.Value,
                QuantityInStock = (int)QuantityInStock.Value,

            };
            _bl.Product.Create(product);
        }

        private void deleteProductBtn_Click(object sender, EventArgs e)
        {
            _bl.Product.Delete(int.Parse(productIDd.Text));
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == readAllProducts)
            {
                List<Product> allProducts = _bl.Product.ReadAll();
                dataGridView1.DataSource = allProducts;
            }
        }

        private void customerDeatails_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == readAllProducts)
            {
                if (int.TryParse(productIdInput.Text, out int id))
                {
                    try
                    {
                        Product product = _bl.Product.Read(id);
                        dataGridView1.DataSource = new List<Product> { product };
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("שגיאה: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("אנא הזן מזהה חוקי (מספר)");
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void customerIdInput_TextChanged(object sender, EventArgs e)
        {
        }


    }
}
