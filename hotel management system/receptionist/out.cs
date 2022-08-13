using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_management_system.receptionist
{
    public partial class @out : Form
    {
        connection con = new connection();
        string  ldate = DateTime.UtcNow.ToString("dd-MM-yyyy");
        long natid;
        TimeSpan daynum;// for number of dayes 
        DateTime td2;
        DateTime td;
        bill l = new receptionist.bill();
        public @out()
        {

            InitializeComponent();
            filltable();
            tp.Enabled = false;   // to timepicker be disable whene you open the window 
            dataGridView1.ReadOnly = true;
             
        }
        public void filltable ()
        {
            string  date = DateTime.UtcNow.ToString("yyyy-MM-dd");
            DataSet ds;
            try
            {
                ds = con.getdata("select * from guest_info  where leavingdate = '"+date+"' ");
                dataGridView1.DataSource = ds.Tables[0]; 
            }
            catch(Exception en )
            {
                MessageBox.Show("eroor in " + en.Message);
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            try
            {
                if (e.ColumnIndex == 4)
                {

                    tp.Enabled = true;

                }

                else
                {
                    tp.Enabled = false;
                }
                ///////////////// to calculate number of dasy if the quest want to stay more time ////////////////////
                         td = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                         td2 = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                        daynum = td2 - td;

                ///////////////////**************** done by : (: w.s :) luxor unviversty *****************/////////////////////////

                dataGridView1.Rows[e.RowIndex].Cells[4].Value = tp.Text; // this to print new date in the datagridview 
                dataGridView1.Rows[e.RowIndex].Cells[5].Value = daynum.Days.ToString(); 
                ldate = tp.Text;  // and this to save the new date in the database 
                natid = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells[1].Value); // natid this is premiray key in DP 
         
                
                
                ////////////////// this part for bill or generate bill button /////////////////
                l.name_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                l.natid_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                l.phone_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                l.daysnumber_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                l.date_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

                long price;
                DataSet ds;
                ds = con.getdata("select price from addroom where id = " + Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells[6].Value) + " ");
                price = Convert.ToInt64(ds.Tables[0].Rows[0][0]);
                l.cash_txt.Text = (price * Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells[5].Value)).ToString();
            }
            catch (Exception en)
            {
                MessageBox.Show("error in " + en.Message);
            }
    


        }

        private void out_Load(object sender, EventArgs e)
        {

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                daynum = td2 - td;
                bool status = false;
                status = con.setdata("update guest_info set leavingdate = '"+ldate+"' , nodays = "+daynum.Days+" where natid = "+natid+" ");
                if (status)

                {
                    MessageBox.Show("update successfully " );
                    filltable();

                }
                else
                    MessageBox.Show("update failed ");
                 

            }
            catch(Exception en )
            {

                MessageBox.Show("error in " + en.Message);
            }

        } // menu strip  when i click right click 

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)  // make update whene you press enter 
            {
                try
                {
                    daynum = td2 - td; // for number of dayes 
                    bool status = false;
                    status = con.setdata("update guest_info set leavingdate = '" + ldate + "' , nodays = "+daynum.Days+" where natid = " + natid + " ");
                    if (status)
                    {
                        MessageBox.Show("update successfully " );
                        filltable();
                    }
                    else
                        MessageBox.Show("update failed ");


                }
                catch (Exception en)
                {

                    MessageBox.Show("error in " + en.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void generateBillToolStripMenuItem_Click(object sender, EventArgs e)
        {

            l.Show(); // to show bill form 

        }
    }
}
