using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hotel_management_system.receptionist;
using System.Threading;
using hotel_management_system.accountant;
namespace hotel_management_system
{
    public partial class login : Form
    {
        Thread tr; 
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            tr = new Thread(openform);
            tr.SetApartmentState(ApartmentState.STA);
            tr.Start() ;
            
            
        }
        public void openform (Object obj)
        {
            Application.Run(new receptionist.mian_page_for_receptionist());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            tr = new Thread(openform1);
            tr.SetApartmentState(ApartmentState.STA);
            tr.Start();
        }
        public void openform1(Object obj)
        {
            Application.Run(new accountant.main_page_for_accountant());
        }

    }
}
