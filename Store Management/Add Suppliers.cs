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
    public partial class Add_Suppliers : Form
    {
        public Add_Suppliers()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            if (txtSName.Text != "" && txtAddrass.Text != "" && txtCname.Text != "" && txtPNum.Text != "" && txtemail.Text != "")
            {
                String SM = txtSName.Text;
                String A = txtAddrass.Text;
                String CN = txtCname.Text;
                Int64 P = Int64.Parse(txtPNum.Text);
                String E = txtemail.Text;
                String Da = dateTimePicker1.Text;



                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-19UJ0FN\\SQLEXPRESS; database = Store_Management;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into Add_Suppliers (Supplier_Name,Address,Company_Name,phone_Number,E_mail,Date) values('" + SM + "','" + A + "','" + CN + "'," + P + ",'" + E + "','"+Da+"')";
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
            txtSName.Clear();
            txtAddrass.Clear();
            txtCname.Clear();
            txtPNum.Clear();
            txtemail.Clear();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Your window closed.", "Are you Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                this.Close();
        }

        private void Add_Suppliers_Load(object sender, EventArgs e)
        {

        }
    }
    
}
