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
    public partial class checkout : Form
    {
        connection con = new connection();
        string name; 
        public checkout()
        {
            InitializeComponent();
            filltable();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void checkout_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
               this.Close();
                        
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        public void filltable()
        {
            DataSet ds; 
            try
            {
                ds = con.getdata("select * from guest_info ");
                dataGridView1.DataSource = ds.Tables[0]; 
            }
            catch(Exception en )
            {
                MessageBox.Show("error in " + en.Message);
            }
        }

        private void search_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void search_txt_KeyDown(object sender, KeyEventArgs e) // search about guest by his name or room id 
        {
            DataSet ds; 
            try
            {                
                    ds = con.getdata("select * from guest_info where name like  '%" + search_txt.Text + "%' or roomid like '%"+search_txt.Text+"%' ");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception en)
            {
                MessageBox.Show("error  in " + en.Message);
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataSet ds;  
            try
            {
                      name = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    ds = con.getdata("select * from guest_info where name = '" + name + "'");
                name_txt.Text = ds.Tables[0].Rows[0][0].ToString();
                natid_txt.Text = ds.Tables[0].Rows[0][1].ToString();
                phone_txt.Text = ds.Tables[0].Rows[0][2].ToString();
                bdate.Text = ds.Tables[0].Rows[0][3].ToString();
                ldate.Text = ds.Tables[0].Rows[0][4].ToString();
                numday_txt.Text = ds.Tables[0].Rows[0][5].ToString();
                numperson.Text = ds.Tables[0].Rows[0][6].ToString();
                room_number.Text = ds.Tables[0].Rows[0][7].ToString();

            }
            catch (Exception en)
            {
                MessageBox.Show("error  in " + en.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bill l = new bill();
            l.name_txt.Text = name_txt.Text;
            l.natid_txt.Text = natid_txt.Text;
            l.phone_txt.Text = phone_txt.Text;
            l.daysnumber_txt.Text = numday_txt.Text;
            l.date_txt.Text = room_number.Text;
            ////////////////////////// to calculate cash we take room id and get the room price ; /////////////////////////
            try
            {
                
                long price ;
                DataSet ds;
                 ds = con.getdata("select price from addroom where id = "+Convert.ToInt64(room_number.Text)+" ");
                price = Convert.ToInt64(ds.Tables[0].Rows[0][0]) ;
                l.cash_txt.Text = (price * Convert.ToInt64(numday_txt.Text)).ToString() ;
            }
            catch (Exception en)
            {
                MessageBox.Show("Error in " + en.Message);
            }
            l.Show(); 
        }
    }
}
