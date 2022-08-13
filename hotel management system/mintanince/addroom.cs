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
using MySql.Data.MySqlClient;

namespace hotel_management_system.mintanince
{
    public partial class addroom : Form
    {
        connection con = new connection(); 
        public addroom()
        {
            
            InitializeComponent();
            fillroomtable();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addroom_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mian_page_for_receptionist l = new mian_page_for_receptionist();
            l.Show();
            this.Close(); 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (idfound(Convert.ToInt32(room_num.Text)))
                {
                    string query; bool status = false;
                    int room_nm , type1; long phon;  string avilable1;
                    room_nm = Convert.ToInt16(room_num.Text);
                    phon = Convert.ToInt64(phone.Text);
                    type1 = type.SelectedIndex + 1;
                    avilable1 = Convert.ToString(avilable.SelectedItem);
                    query = "insert into addroom (id , phone , type , avilable , price ) values (" + room_nm + " , " + phon + " , " + type1 + " , '" + avilable1 + "' , " + Convert.ToInt32(price_txt.Text) + ")";
                    status = con.setdata(query);
                    if (status)
                    {
                        MessageBox.Show("add sucessful");
                        fillroomtable();  // to show the new add in the table 
                        clear(); //////// to clear the data from the text boxs after save
                    }

                    else
                        MessageBox.Show("add failed ");
                    fillroomtable();
                }
                else
                {
                    MessageBox.Show("room number already exist ");
                }
            }
            catch(Exception en)
            {
                MessageBox.Show("error in " + en.Message  , "Error ", MessageBoxButtons.OK , MessageBoxIcon.Error );
            }



        }
        public void fillroomtable()
        {
            DataSet ds;
            ds = con.getdata("select * from addroom  ");
            roomlistview.DataSource = ds.Tables[0]; 
        }

        private void roomlistview_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void roomlistview_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void roomlistview_CellClick(object sender, DataGridViewCellEventArgs e)
        {

                DataSet ds;
            try
            {
                ds = con.getdata("select * from addroom limit " + e.RowIndex + ",1");
                if (ds.Tables[0].Rows.Count != 0)
                {
                    room_num.Text = ds.Tables[0].Rows[0][0].ToString();
                    phone.Text = ds.Tables[0].Rows[0][1].ToString();
                    type.SelectedIndex = Convert.ToInt16(ds.Tables[0].Rows[0][2]) - 1;  /// for room type 
                    avilable.SelectedItem = ds.Tables[0].Rows[0][3];
                    price_txt.Text = ds.Tables[0].Rows[0][4].ToString(); 


                }
            }
            catch(Exception en )
            {
                Console.Write("error in " +en.Message); 
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                bool status = false;
                status = con.setdata("update addroom set   phone = "+Convert.ToInt32(phone.Text)+" , type ="+ Convert.ToInt16(type.SelectedIndex+ 1 )  + " , avilable = '"+avilable.SelectedItem+"' where id = " + Convert.ToInt32(room_num.Text) + "");
                if (status)
                {
                    MessageBox.Show("update successful ", "info ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    fillroomtable();
                    clear();
                }
                else
                {
                    MessageBox.Show("update  successful ", "info ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch (Exception en)
            {
                MessageBox.Show("error in " + en.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                bool status = false;
                status = con.setdata("delete from addroom where id = "+Convert.ToInt32(room_num.Text)+"");
                if(status)
                {
                    MessageBox.Show("delete successful " , "info ", MessageBoxButtons.OK , MessageBoxIcon.Hand);
                    fillroomtable();
                    clear(); 
                }
                else
                {
                    MessageBox.Show("delete successful ", "info ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch (Exception en )
            {
                MessageBox.Show("error in " + en.Message);
            }
        }
        public void clear() // to clerar all data input after save or update or delete date 
        {
            room_num.Text = "";
            phone.Text = "";
            type.SelectedIndex = -1;
            avilable.SelectedIndex = -1;
            price_txt.Text = "";
        }

        private void roomlistview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void update_price_Click(object sender, EventArgs e)
        {
            update_price l = new receptionist.update_price();
            l.Show();
        }

        private void room_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void price_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        bool idfound(int id) // if id is aleardy found in database 
        {
            try
            {
                
                if (Convert.ToInt32(con.getdata("select id  from addroom where id = " + id + "").Tables[0].Rows[0][0]) == id)
                {
                   
                    return false; 

                }
                
            }
            catch (Exception en)
            {
                
            }


            return true; 

        }

        private void avilable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
