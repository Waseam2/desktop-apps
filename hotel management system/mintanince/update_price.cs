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
    public partial class update_price : Form
    {
        connection con = new connection(); 
        public update_price()
        {
            InitializeComponent();
            filltable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (oneroom.Checked)
                {
                    bool status = false;
                    status = con.setdata("update addroom set price = " + Convert.ToInt32(price_txt.Text) + " where id = " + Convert.ToInt64(id_txt.Text) + "");
                    if (status)
                    {
                        MessageBox.Show("update successful ");
                        filltable();

                    }
                    else
                        MessageBox.Show("update failed");
                }
                else
                {
                    bool status = false;
                    status = con.setdata("update addroom set price = " + Convert.ToInt32(price_txt.Text) + " where type = " + Convert.ToInt32(type_txt.Text) + "");
                    if (status)
                    {
                        MessageBox.Show("update successful ");
                        filltable();

                    }
                    else
                        MessageBox.Show("update failed");
                }
            }
            catch(Exception en )
            {
                MessageBox.Show("please select the room first ");
            }
        }
        public void filltable()
        {
            try
            {
                DataSet ds;
                ds = con.getdata("select id, type , price from addroom ");
                dataGridView1.DataSource = ds.Tables[0]; 
            }
            catch(Exception en )
            {
                MessageBox.Show("Error in " + en.Message);
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                price_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                type_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                id_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch(Exception en )
            {
                MessageBox.Show("Error in " + en.Message);
            }
        }

        private void update_price_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void price_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void price_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
     
    }
}
