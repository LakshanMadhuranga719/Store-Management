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
    public partial class Maneger : Form
    {
        public Maneger()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you Sure you want to Exit?", "Conform", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you Sure you want to Exit?", "Conform", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Maneger_Load(object sender, EventArgs e)
        {

        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addABookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_material VA = new view_material();
            VA.Show();
        }

        private void viewAllSuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_Suppliers Vs = new view_Suppliers();
            Vs.Show();
        }

        private void summeryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hand_Over_Summery HOS = new Hand_Over_Summery();
            HOS.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
