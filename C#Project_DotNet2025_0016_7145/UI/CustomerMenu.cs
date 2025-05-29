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
    public partial class CustomerMenu : Form
    {
        private static IBl _bl = BlApi.Factory.Get();
        public CustomerMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addCustomer_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            int custId, custPhone;
            if (!int.TryParse(idCustomer.Text, out custId)) { custId = 0; }
            if (!int.TryParse(phoneCustomer.Text, out custPhone)) { custPhone = 0; }
            Customer customer = new Customer()
            {
                Id = custId,
                Name = customerName.Text,
                Address = addressCustomer.Text,
                Phone = custPhone

            };
            _bl.Customer.Create(customer);

        }

        private void updateCustomerBtn_Click(object sender, EventArgs e)
        {
            int custId, custPhone;
            if (!int.TryParse(idCustomer.Text, out custId)) { custId = 0; }
            if (!int.TryParse(phoneCustomer.Text, out custPhone)) { custPhone = 0; }
            Customer customer = new Customer()
            {
                Id = custId,
                Name = customerName.Text,
                Address = addressCustomer.Text,
                Phone = custPhone

            };
            _bl.Customer.Update(customer);
        }

        private void deleteCustomerBtn_Click(object sender, EventArgs e)
        {
            _bl.Customer.Delete(int.Parse(customerId.Text));
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == readAllCustomers)
            {
                List<Customer> allCustomers = _bl.Customer.ReadAll();
                dataGridView1.DataSource = allCustomers;
            }
        }

        private void customerDeatails_Click(object sender, EventArgs e)
        {
                if (tabControl1.SelectedTab == readAllCustomers)
                {
                    if (int.TryParse(customerIdInput.Text, out int id))
                    {
                        try
                        {
                            Customer customer = _bl.Customer.Read(id);
                            dataGridView1.DataSource = new List<Customer> { customer };
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
