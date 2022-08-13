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
    public partial class complain : Form
    {
        connection con = new connection();
        public complain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            this.Close(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query; bool status = false ; 
            query = "insert into complain (customername , roomnum , phone , email , complain ) values ('"+customer_name_txt.Text+"' , '"+Convert.ToUInt64(room_number_txt.Text)+"' , '"+Convert.ToUInt64(phone_number_txt.Text)+"' ,'"+email_txt.Text+"' , '"+complain_txt.Text+"' )";
            try
            {
                status = con.setdata(query);
                if (status)
                {
                    MessageBox.Show("submited successfully");
                    reset(); 
                }
                else
                    MessageBox.Show("submitd failed ");
            }
            catch(Exception en)
            {
                MessageBox.Show("error in  " + en.Message );
            }
        }
        public void reset ()
        {
            customer_name_txt.Text = "";
            room_number_txt.Text = "";
            phone_number_txt.Text = "";
            email_txt.Text = "";
            complain_txt.Text = "";
        }
    }
}
