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
    public partial class listOFCustomer : Form
    {
        public listOFCustomer()
        {
            InitializeComponent();
        }

        private void listOFCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wholeprojectDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.wholeprojectDataSet.customer);

        }
    }
}
