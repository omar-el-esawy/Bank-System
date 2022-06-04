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

    public partial class login : Form
    {

        static public string AdminSsn;
        static public string EmpSSN;
        static public string CusSSN;


        string ConnectionString = @"Data Source=DESKTOP-MGHD0AJ\ESAWY;Initial Catalog=wholeproject;Integrated Security=True";
        public login()
        {
            InitializeComponent();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            chosse obj = new chosse();
            obj.Show();
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(ConnectionString);
            string query1 = "select * from admin where username = '" + txt_username.Text.Trim() + "' and password = '" + txt_password.Text.Trim()+ "'" ;
            string query2 = "select * from customer where username = '" + txt_username.Text.Trim() + "' and password = '" + txt_password.Text.Trim()+ "'" ;
            string query3 = "select * from Employee where username = '" + txt_username.Text.Trim() + "' and password = '" + txt_password.Text.Trim()+ "'" ;
            SqlDataAdapter adapter = new SqlDataAdapter(query1,sqlcon);
            DataTable dtb1 = new DataTable();
            adapter.Fill(dtb1);
            if (dtb1.Rows.Count == 1){
                foreach (DataRow row in dtb1.Rows)
                {
                    AdminSsn = row["SSN"].ToString();                  
                }
                this.Hide();
                AdminHomePage obj = new AdminHomePage();
                obj.Show();
            }else {
                SqlDataAdapter adapter2 = new SqlDataAdapter(query2, sqlcon);
                DataTable dtb2 = new DataTable();
                adapter2.Fill(dtb2);
                if (dtb2.Rows.Count == 1)
                {
                    foreach (DataRow row in dtb2.Rows)
                    {
                        CusSSN = row["SSN"].ToString();
                    }
                    this.Hide();
                    LoanRequest obj = new LoanRequest();
                    obj.Show();
                }else{
                    SqlDataAdapter adapter3 = new SqlDataAdapter(query3, sqlcon);
                    DataTable dtb3 = new DataTable();
                    adapter3.Fill(dtb3);
                    if (dtb3.Rows.Count == 1)
                    {
                        foreach (DataRow row in dtb3.Rows)
                        {
                            EmpSSN = row["SSN"].ToString();
                        }
                        this.Hide();
                        EmployeeHomePage obj = new EmployeeHomePage();
                        obj.Show();
                    }
                    else
                    {
                        txt_password.Text = txt_username.Text = "";
                        MessageBox.Show("Your usernmae or password are wrong try again!");
                    }
                }
            }


        }
    }
}
