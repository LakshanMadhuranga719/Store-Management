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
    public partial class Store_Keeper : Form
    {
        public Store_Keeper()
        {
            InitializeComponent();
        }

        private void Admin_Click(object sender, EventArgs e)
        {

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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Store_Keeper_Load(object sender, EventArgs e)
        {

        }

        private void addABookToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Form2  AM = new Form2();
            AM.Show();
        }

        private void viewAllMatirialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 VM = new Form3();
            VM.Show();
        }

        private void viewAllSuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Suppliers AS = new Add_Suppliers();
            AS.Show();
        }

        private void viewAllSuppliersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            View_All_Suppliers_SK_ VAS = new View_All_Suppliers_SK_();
            VAS.Show();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Emp E = new Add_Emp();
            E.Show();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewAllEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_Emp_sk_ VE = new View_Emp_sk_();
            VE.Show();
        }

        private void handOverToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void handOverSummeryToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void handOverSummeryToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Hand_Over_Summery HOS = new Hand_Over_Summery();
            HOS.Show();
        }

        private void handOverMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hand_over HV = new hand_over();
            HV.Show();
        }
    }
}
