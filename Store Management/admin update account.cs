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
    public partial class admin_update_account : Form
    {
        public admin_update_account()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            update_account UA = new update_account();
            UA.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Update_account_manager UAM = new Update_account_manager();
            UAM.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update_account_SK UASK = new Update_account_SK();
            UASK.Show();
        }
    }
}
