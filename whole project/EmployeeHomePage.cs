using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace whole_project
{
    public partial class EmployeeHomePage : Form
    {
        public EmployeeHomePage()
        {
            InitializeComponent();
        }

        private void btn_addCus_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpAsCus obj = new SignUpAsCus();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            showing obj = new showing();
            obj.Show();
        }
    }
}
