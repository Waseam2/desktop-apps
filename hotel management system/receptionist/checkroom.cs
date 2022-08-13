using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace hotel_management_system.receptionist
{
    public partial class checkroom : Form
    {
        connection con = new connection();
        public checkroom()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        /*
        1- show room number 
        2- avilable or not 
        3- status single , double .....
        4- if clicked on the room is not avilable go to check in this room or go to booking this room 
        5- if clicked on the romm is avilable go to information about the guest in the room  
         
         */
    }
}
