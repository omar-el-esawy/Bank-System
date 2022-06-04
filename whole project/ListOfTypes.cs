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
    public partial class ListOfTypes : Form
    {
        public ListOfTypes()
        {
            InitializeComponent();
        }

        private void ListOfTypes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wholeprojectDataSet1.loan' table. You can move, or remove it, as needed.
            this.loanTableAdapter.Fill(this.wholeprojectDataSet1.loan);

        }
    }
}
