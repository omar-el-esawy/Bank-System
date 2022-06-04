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
    public partial class AdminHomePage : Form
    {
        public AdminHomePage()
        {
            InitializeComponent();
        }

        private void btn_addbank_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddBank obj = new AddBank();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            showing obj = new showing();
            obj.Show();
        }

        private void btn_addbranch_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddBranch obj = new AddBranch();
            obj.Show();
        }

        private void btn_updata_Click(object sender, EventArgs e)
        {
            this.Hide();
            updataAdmin obj = new updataAdmin();
            obj.Show();
        }
    }
}
