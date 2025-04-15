using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Store_Management
{
    public partial class hand_over : Form
    {
        public hand_over()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtSName_TextChanged(object sender, EventArgs e)
        {

        }

        private void hand_over_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-19UJ0FN\\SQLEXPRESS; database = Store_Management;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("select Material_Name from Add_Material", con);
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    comboBoxBName.Items.Add(sdr.GetString(i));
                    
                }
            }
            sdr.Close();
            con.Close();
        }
        int count;
        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            if (TxtEN.Text != "")
            {
                String EN = TxtEN.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-19UJ0FN\\SQLEXPRESS; database = Store_Management;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from  Add_Employee where Emp_No = '" + EN + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

              
                cmd.CommandText = "select count(Emp_No ) from  Hand_Over where Emp_No = '" + EN + "' ";
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);

                count = int.Parse(ds1.Tables[0].Rows[0][0].ToString());
                

                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtEName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtA.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtE.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtP.Text = ds.Tables[0].Rows[0][5].ToString();
                    
                }
                else
                {
                    txtEName.Clear();
                    txtA.Clear();
                    txtE.Clear();
                    txtP.Clear();
                    
                    MessageBox.Show("Invalid Emplooyee Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHandover_Click(object sender, EventArgs e)
        {
            if (txtEName.Text != "")
            {
                if (comboBoxBName.SelectedIndex != -1 && count <= 100)
                {
                    String EN = TxtEN.Text;
                    String EName = txtEName.Text;
                    String A = txtA.Text;
                    String E = txtE.Text;
                    Int64 P = Int64.Parse(txtP.Text);
                    
                    String MN = comboBoxBName.Text;
                    Int64 Q = Int64.Parse(txtQty.Text);
                    String D = dateTimePicker1.Text;


                    String EmpN = TxtEN.Text;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = DESKTOP-19UJ0FN\\SQLEXPRESS; database = Store_Management;integrated security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();

                    cmd.CommandText = cmd.CommandText = "Insert into Hand_Over (Employee_name,Emp_No,Address,E_mail,Phone_NO,Material_name,Material_QTY,Hand_Over_Date) values ('" + EName + "','" + EN + "','" + A + "','" + E + "'," + P + ",'" + MN + "'," + Q + ",'" + D + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Material Hand overed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Select Material. OR Maximum Quentity of Material has been hand overed", "No Material Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Enter valid Employee no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            TxtEN.Clear();
            txtEName.Clear();
            txtA.Clear();
            txtE.Clear();
            txtP.Clear();
            txtQty.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure?", "conformation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
    
}
