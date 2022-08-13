using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_management_system.accountant
{
    public partial class Edit : Form
    {
        connection con = new connection(); 

        public Edit()
        {
            InitializeComponent();
            getpic();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void  getpic()
        {
            string name = "1";
            try
            {
                byte[] image; 
                DataSet ds;
                ds = con.getdata("select * from employe where 1");
                MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0][9]);
                pictureBox1.Image = new Bitmap(ms);


            }
            catch(Exception en )
            {
                MessageBox.Show(en.Message); 
            }
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
            Image img = (Image)converter.ConvertFrom(byteArrayIn);

            return img;
        }

        private void Edit_Load(object sender, EventArgs e)
        {

        }
    }
}
