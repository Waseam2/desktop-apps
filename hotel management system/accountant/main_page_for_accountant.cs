using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_management_system.accountant
{
    public partial class main_page_for_accountant : Form
    {
        public main_page_for_accountant()
        {
            InitializeComponent();
        }

        private void main_page_for_accountant_Load(object sender, EventArgs e)
        {

        }

        private void addemployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addemployee l = new addemployee();
            l.Show(); 
        }

        private void editInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit d = new Edit();
            d.Show(); 
        }
    }
}
