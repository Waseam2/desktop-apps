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
    public partial class search : Form
    {
        connection con = new connection();

        public search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
          
        }

        private void search_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataSet ds;
            try
            {
                ds = con.getdata("select *  from guest_info  where name like  '%"+search_txt.Text+ "%' or roomid like '%" + search_txt.Text + "%'   ");
                searchview.DataSource = ds.Tables[0];
            }
            catch (Exception en)
            {
                MessageBox.Show("error in " + en.Message);
            }
        }

        private void search_txt_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_Load(object sender, EventArgs e)
        {

        }
    }
}
