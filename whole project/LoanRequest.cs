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
    public partial class LoanRequest : Form
    {
        public LoanRequest()
        {
            InitializeComponent();
        }
        string ConnectionString = @"Data Source=DESKTOP-MGHD0AJ\ESAWY;Initial Catalog=wholeproject;Integrated Security=True";


        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_loanID.Text == "" || txt_loanType.Text == "" || txt_amount.Text == "")
            {
                MessageBox.Show("please enter madatory feilds");
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(ConnectionString))
                {
                    sqlcon.Open();
                    SqlCommand sqlcmd = new SqlCommand("loanRequestgood", sqlcon);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue("@loanID", txt_loanID.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@loanType", txt_loanType.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@amount", txt_amount.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@cusSSN", login.CusSSN.Trim());
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("Bank added successfully");
                    txt_loanID.Text = txt_loanType.Text = txt_amount.Text = "";

                }

            }
        }
    }
}
