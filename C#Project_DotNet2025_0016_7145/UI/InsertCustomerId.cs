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
    public partial class InsertCustomerId : Form
    {
        public InsertCustomerId()
        {
            InitializeComponent();
        }

        private void send_Click(object sender, EventArgs e)
        {
            OrderMenu menu = new OrderMenu();
            menu.Show();
        }
    }
}
