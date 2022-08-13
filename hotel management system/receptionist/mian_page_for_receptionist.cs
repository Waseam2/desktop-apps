using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hotel_management_system.mintanince;


namespace hotel_management_system.receptionist
{
    public partial class mian_page_for_receptionist : Form
    {
       
        @out cn = new @out();
        public mian_page_for_receptionist()
        {
            InitializeComponent();
            cn.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {

            addroom ad = new addroom();
                ad.Show(); 
           
            

        }

        private void checkAvilableRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            avilable_room l = new avilable_room();
                l.Show();
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            checkout ch = new checkout();
            ch.Show();
    
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search sh = new search();
            sh.Show();
            
        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            check_in c = new check_in();
            c.Show();
            
        }

        private void complainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            complain d = new complain();
            d.Show();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addroom l = new addroom();
            l.Show();
            
        }

        private void mian_page_for_receptionist_Load(object sender, EventArgs e)
        {

        }

        private void outToolStripMenuItem_Click(object sender, EventArgs e)
        {
            @out l = new @out();
            l.Show(); 
        }
    }
}
