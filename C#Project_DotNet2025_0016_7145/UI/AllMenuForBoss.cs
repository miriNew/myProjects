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
    public partial class AllMenuForBoss : Form
    {
        public AllMenuForBoss()
        {
            InitializeComponent();
        }

        private void forProducts_Click(object sender, EventArgs e)
        {
            ProductMenu productMenu = new ProductMenu();
            productMenu.Show();

        }

        private void forCustomers_Click(object sender, EventArgs e)
        {
            CustomerMenu customerMenu = new CustomerMenu();
            customerMenu.Show();

        }

        private void forSales_Click(object sender, EventArgs e)
        {
            SaleMenu saleMenu = new SaleMenu();
            saleMenu.Show();
        }
    }
}
