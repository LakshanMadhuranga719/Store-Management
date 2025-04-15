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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Store_Management
{
    public partial class Add_Account : Form
    {
        public Add_Account()
        {
            InitializeComponent();
        }

        public string Username { get; private set; }
        public string User_ID { get; private set; }
        public string E_mail { get; private set; }
        public string Phone_NO { get; private set; }
        public string Password { get; private set; }
        public string Usernamme { get; private set; }

        private void Add_Account_Load(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtAddress.Text != "" && txtemail.Text != "" && txtPhoneNO.Text != "" && txtpw.Text != "")
            {
                String UName = txtUsername.Text;
                String Address = txtAddress.Text;
                String Email = txtemail.Text;
                Int64 PhoneNO = Int64.Parse(txtPhoneNO.Text);
                String pw = txtpw.Text;


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-19UJ0FN\\SQLEXPRESS; database = Store_Management;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into logintable_admin (Username,Address,E_mail,Phone_NO,Password) values('" + UName + "','" + Address + "','" + Email + "'," + PhoneNO + ",'"+pw+"')";
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
            txtUsername.Clear();
            txtAddress.Clear();
            txtemail.Clear();
            txtPhoneNO.Clear();
            txtpw.Clear();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Your window closed.", "Are you Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                this.Close();
        }
    }
    }

