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
    public partial class avilable_room : Form
    {
        connection con = new connection();
        public avilable_room() 
        {
            InitializeComponent();
            fillroomtable();
            dataGridView1.ReadOnly = true; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            this.Close(); 
        }
        public void fillroomtable()
        {
            DataSet ds;
            ds = con.getdata("select * from addroom  ");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            DataSet ds;
            ds = con.getdata("select * from addroom where avilable = 'no'");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void all_radio_CheckedChanged(object sender, EventArgs e)
        {
            DataSet ds;
            ds = con.getdata("select * from addroom");
            dataGridView1.DataSource = ds.Tables[0]; 
        }

        private void avilable_radio_CheckedChanged(object sender, EventArgs e)
        {
            DataSet ds;
            ds = con.getdata("select * from addroom where avilable = 'yes'");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                DataSet ds;
                ds = con.getdata("select * from addroom where id = " + Convert.ToInt32(search.Text) + "");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch(Exception en )
            {
                Console.WriteLine("error in " + en.Message);
            }
        }

        private void avilable_room_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
    }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            int id; string state;
            DataSet ds;
            try
            {
                ///////this function discuss if i press into the room is avilable we will go to the booking page and if it not avilable 
                //we go to the information of the guest in this room and have avilablilty to check out immeditly 
                //to get id from data grid view .
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                ds = con.getdata("select * from addroom where id = '" + id + "'");
                state = ds.Tables[0].Rows[0][3].ToString();
                if (state == "yes")
                {
                    check_in cn = new check_in();
                    cn.dataGridView1.DataSource = ds.Tables[0];
                    cn.roomid_txt.Text = id.ToString();
                    cn.roomid_txt.Enabled = false;
                    cn.Show();

                }
                else
                {
                    ds = con.getdata("select * from guest_info where roomid = " + id + "");
                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        checkout cn = new checkout();
                        cn.name_txt.Text = ds.Tables[0].Rows[0][0].ToString();
                        cn.natid_txt.Text = ds.Tables[0].Rows[0][1].ToString();
                        cn.phone_txt.Text = ds.Tables[0].Rows[0][2].ToString();
                        cn.bdate.Text = ds.Tables[0].Rows[0][3].ToString();
                        cn.ldate.Text = ds.Tables[0].Rows[0][4].ToString();
                        cn.numday_txt.Text = ds.Tables[0].Rows[0][5].ToString();
                        cn.numperson.Text = ds.Tables[0].Rows[0][6].ToString();
                        cn.room_number.Text = ds.Tables[0].Rows[0][7].ToString();
                        cn.Show();


                    }
                }

            }
            catch (Exception en)
            {
                MessageBox.Show("error in " + en.Message);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
