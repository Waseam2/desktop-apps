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
    public partial class check_in : Form
    {
        connection con = new connection(); 
        public check_in()
        {
            InitializeComponent();
            filltable();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            this.Close(); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        public void filltable () // this function to fill information in the datagridview from DP show the avilable room 
        {
            DataSet ds;
            ds = con.getdata("select id,phone,type from addroom where avilable = 'yes'"); 
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (leavingdate_txt.Value <= bookingdate_txt.Value)
            {
                MessageBox.Show("Error the leaving date is wrong ");
            }
                bool status = false;
            try
            {
                status = con.setdata("insert into guest_info (name , natid,phone , bookingdate , leavingdate , nodays , noperson , roomid , email ) values ('" + name_txt.Text + "' , " + Convert.ToInt64(natid_txt.Text) + " , " + Convert.ToInt64(phone_txt.Text) + " , '" + bookingdate_txt.Text + "' , '"+ leavingdate_txt.Text +"' , " + Convert.ToInt16(nodays_txt.Text) + " , " + Convert.ToInt16(noofperson_txt.Text) + " ," + Convert.ToInt16(roomid_txt.Text) + " , '"+email_txt.Text+"')");

                if (status)
                {
                    MessageBox.Show("booking succssful ");
                    con.setdata("update addroom set avilable = 'no' where id = '"+Convert.ToInt32(roomid_txt.Text)+"'");
                    filltable();
                    clear();
                }
                else
                    MessageBox.Show("booking fail ");
                 
            }
            catch(Exception en)
            {
                MessageBox.Show("error in "+ en.Message);
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)

        {
            int id;
            DataSet ds;
            try
            {

                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                ds = con.getdata("select * from addroom where id = "+id+" " );
                 roomid_txt.Text = ds.Tables[0].Rows[0][0].ToString();        
            }
            catch (Exception en)
            {
                MessageBox.Show("error in " + en.Message);
            }
        }
        //validatrion compare to date to prevent bokking date start after leaving date 
        private void leavingdate_txt_ValueChanged(object sender, EventArgs e)
        {

            if (leavingdate_txt.Value < bookingdate_txt.Value)
            {
                MessageBox.Show("Error the leaving date is wrong ");
                leavingdate_txt.Value = bookingdate_txt.Value;
                            
            }
            ///////////////// to caluculate the number of date the guest will stay in the hotel . 
            DateTime td = bookingdate_txt.Value; 
            DateTime td2 = leavingdate_txt.Value;
            TimeSpan daynum = td2 - td  ;
            nodays_txt.Text = (daynum.Days+1).ToString();
        }
      
        bool validation ()
        {
            bool status = false;




            return status; 
        }

        private void natid_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// //////////////////////*********** validation ********************//////////////////////////
        private void phone_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void noofperson_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) )
            {
                e.Handled = true; 
            }
        }

        private void name_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (! char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !(e.KeyChar == (char) Keys.Space) )
            {
                e.Handled = true; 
            }
        }
        void clear()
        {
            name_txt.Text = "";
            natid_txt.Text = "";
            phone_txt.Text = "";
            email_txt.Text = "";
            nodays_txt.Text = "";
            noofperson_txt.Text = "";
            roomid_txt.Text = "";
        }

        private void check_in_Load(object sender, EventArgs e)
        {

        }
    }
}
