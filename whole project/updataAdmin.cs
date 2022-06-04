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
    public partial class updataAdmin : Form
    {
        public updataAdmin()
        {
            InitializeComponent();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=DESKTOP-MGHD0AJ\ESAWY;Initial Catalog=wholeproject;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);    
            con.Open();


        }

        private void bt_updata_Click(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=DESKTOP-MGHD0AJ\ESAWY;Initial Catalog=wholeproject;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            string name = txt_name.Text;
            string username = txt_userName.Text;
            string password = txt_password.Text;
            string address = txt_address.Text;
            string phone = txt_phone.Text;

            string Query = "update [admin] set [name] = '"+ name +"' where ssn = 'jojo'";
        }
    }
}
