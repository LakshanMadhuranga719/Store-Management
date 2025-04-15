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
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login L = new Login();
            L.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login2 L2 = new Login2();
            L2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login3 L3 = new login3();
            L3.Show();
        }

        private void welcome_Load(object sender, EventArgs e)
        {

        }
    }
}
