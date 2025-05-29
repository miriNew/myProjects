using BlApi;
using BO;
using System.Windows.Forms;

namespace UI
{
    public partial class SaleMenu : Form
    {
        private static IBl _bl = BlApi.Factory.Get();
        public SaleMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void addSale_Click(object sender, EventArgs e)
        {

        }

        private void yes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void price_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addSaleBtn_Click(object sender, EventArgs e)
        {
            int prodId;
            if (!int.TryParse(productIdL.Text, out prodId)) { prodId = 0; }
            Sale sale = new Sale()
            {
                ProductId = prodId,
                MinQuantity = (int)minQuantityN.Value,
                Price = (double)priceN.Value,
                InClab = yes.Checked,
                BeginSale = beginSaleDate.Value,
                EndSale = endSaleDate.Value,
            };
            _bl.Sale.Create(sale);

        }

        private void updateSaleBtn_Click(object sender, EventArgs e)
        {
            int prodId, saleCode;
            if (!int.TryParse(productIdU.Text, out prodId)) { prodId = 0; }
            if (!int.TryParse(saleIdTB.Text, out saleCode)) { saleCode = 0; }
            Sale sale = new Sale()
            {
                Code = saleCode,
                ProductId = prodId,
                MinQuantity = (int)minQuantityU.Value,
                Price = (double)priceU.Value,
                InClab = yesU.Checked,
                BeginSale = beginSaleU.Value,
                EndSale = endSaleU.Value,


            };
            _bl.Sale.Update(sale);

        }

        private void deleteSaleBtn_Click(object sender, EventArgs e)
        {
            _bl.Sale.Delete(int.Parse(saleId.Text));
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == readAllSales)
            {
                List<Sale> allSales = _bl.Sale.ReadAll();
                dataGridView1.DataSource = allSales;
            }
        }

        private void saleDeatails_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == readAllSales)
            {
                if (int.TryParse(saleIdInput.Text, out int id))
                {
                    try
                    {
                        Sale sale = _bl.Sale.Read(id);
                        dataGridView1.DataSource = new List<Sale> { sale };
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
    }
}
