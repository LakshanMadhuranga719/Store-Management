using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Management
{
    public partial class admin_create_account : Form
    {
        public admin_create_account()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Account AC = new Add_Account();
            AC.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            add_account_manager ACM = new add_account_manager();
            ACM.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add_account_SK ACSK = new add_account_SK();
            ACSK.Show();
        }

        private void admin_create_account_Load(object sender, EventArgs e)
        {

        }
    }
}
