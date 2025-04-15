using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Management
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void lblqty_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtMName.Text != "" && txtDiscription.Text != "" && txtunit.Text != "" && txtQty.Text != "" && txtprice.Text != "" && dateTimePicker1.Text != "")
            {
                String MN = txtMName.Text;
                String D = txtDiscription.Text;
                String U = txtunit.Text;
                Int64 QTY = Int64.Parse(txtQty.Text);
                Int64 P = Int64.Parse(txtprice.Text);
                String Da = dateTimePicker1.Text;



                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-19UJ0FN\\SQLEXPRESS; database = Store_Management;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into Add_Material (Material_Name,Discription,Unit,QTY,Price,Date) values('"+MN+"','" + D + "','" + U + "'," + QTY + ",'" + P + "', '"+Da+"')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Emty Feild Not Allowed", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            txtMName.Clear();
            txtDiscription.Clear();
            txtunit.Clear();
            txtQty.Clear();
            txtprice.Clear();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Your window closed.", "Are you Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                this.Close();
        }
    }
}
