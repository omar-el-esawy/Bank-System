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
    public partial class AddBranch : Form
    {
        string ConnectionString = @"Data Source=DESKTOP-MGHD0AJ\ESAWY;Initial Catalog=wholeproject;Integrated Security=True";

        public AddBranch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_branchID.Text == "" || txt_address.Text == "" || txt_code.Text == "")
            {
                MessageBox.Show("please enter madatory feilds");
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(ConnectionString))
                {
                    sqlcon.Open();
                    SqlCommand sqlcmd = new SqlCommand("AddBranch", sqlcon);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue("@branchID", txt_branchID.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@address", txt_address.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@code", txt_code.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@admSSN", login.AdminSsn.Trim());
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("Branch added successfully");
                    txt_branchID.Text = txt_address.Text = txt_code.Text = "";

                }

            }
        }
    }
}
