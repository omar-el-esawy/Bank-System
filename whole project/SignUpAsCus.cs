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

namespace whole_project
{
    public partial class SignUpAsCus : Form
    {
        string ConnectionString = @"Data Source=DESKTOP-MGHD0AJ\ESAWY;Initial Catalog=wholeproject;Integrated Security=True";
        public SignUpAsCus()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_password.Text == ""||txt_password.Text == ""||  txtssn.Text == "")
            {
                MessageBox.Show("please enter madatory feilds");
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(ConnectionString))
                {
                    sqlcon.Open();
                    SqlCommand sqlcmd = new SqlCommand("userAdd", sqlcon);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue("@SSN", txtssn.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@username", txt_userName.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@name", txt_name.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@address", txt_address.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@phone", txt_phone.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@password", txt_password.Text.Trim());
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("registration has been done successfully");
                    txt_name.Text = txt_address.Text = txt_password.Text = txtssn.Text = txt_address.Text = txt_phone.Text = txt_userName.Text= "";

                }

            }
        }
    }
}
