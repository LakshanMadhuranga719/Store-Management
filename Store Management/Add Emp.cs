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
    public partial class Add_Emp : Form
    {
        public Add_Emp()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtemp.Text != "" && txtA.Text != "" && txtemail.Text != "" && txtpnum.Text != "" && dateTimePicker1.Text != "")
            {
                String EM = txtemp.Text;
                String N = txtno.Text;
                String A = txtA.Text;
                String E = txtemail.Text;
                Int64 p = Int64.Parse(txtpnum.Text);
                String Da = dateTimePicker1.Text;



                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-19UJ0FN\\SQLEXPRESS; database = Store_Management;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into Add_Employee (Employee_name,Emp_No,Address,E_mail,Phone_NO,Date) values('" + EM + "','"+N+"','" + A + "','" + E + "'," + p + ", '" + Da + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Emty Feild Not Allowed", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Add_Emp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtemp.Clear();
            txtno.Clear();
            txtA.Clear();
            txtemail.Clear();
            txtpnum.Clear();
           
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Your window closed.", "Are you Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblbook_Click(object sender, EventArgs e)
        {

        }
    }
}
