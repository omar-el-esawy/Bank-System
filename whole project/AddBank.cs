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
    public partial class AddBank : Form
    {
        string ConnectionString = @"Data Source=DESKTOP-MGHD0AJ\ESAWY;Initial Catalog=wholeproject;Integrated Security=True";

        public AddBank()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" || txt_address.Text == "" || txt_code.Text == "")
            {
                MessageBox.Show("please enter madatory feilds");
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(ConnectionString))
                {
                    sqlcon.Open();
                    SqlCommand sqlcmd = new SqlCommand("AddBank", sqlcon);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue("@name", txt_name.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@addrress", txt_address.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@code", txt_code.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@admSSN", login.AdminSsn.Trim());
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("Bank added successfully");
                    txt_name.Text = txt_address.Text = txt_code.Text = "";

                }

            }
        }
    }
}
