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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void boss_Click(object sender, EventArgs e)
        {
            AllMenuForBoss allMenuForBoss = new AllMenuForBoss();
            allMenuForBoss.Show();
            //this.Hide();
        }

        private void shopkipper_Click(object sender, EventArgs e)
        {
            InsertCustomerId insertCustomerId = new InsertCustomerId();
            insertCustomerId.Show();
            //this.Hide();
        }
    }
}
