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
    public partial class chosse : Form
    {
        public chosse()
        {
            InitializeComponent();
        }

        private void btn_cus_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpAsCus obj = new SignUpAsCus();
            obj.Show();

        }

        private void btn_emp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpAsEmp obj = new SignUpAsEmp();
            obj.Show();
        }

        private void btn_adm_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpAsAdm obj = new SignUpAsAdm();
            obj.Show();
        }
    }
}
