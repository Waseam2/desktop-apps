using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace hotel_management_system.receptionist
{
    public partial class bill : Form
    {
        
        connection con = new connection();
        public bill()
        {
            InitializeComponent();
            button1.Enabled = false;
            date();
   
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bill_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool status = false;
            bool status1 = false;
            ////////////////////// delete guest from gust table  //////////////////////
            status1 =  con.setdata("update addroom set avilable = 'yes' where id = "+ Convert.ToInt64(date_txt.Text) + "");
            status = con.setdata("delete  from guest_info where natid = " + Convert.ToInt64(natid_txt.Text)+ "");
            if (status && status1)
            {
                MessageBox.Show("Done");

            }
            else
                MessageBox.Show("failed ");
            //////////////////////  save bill in bill table ////////////////////////
            try
            {
                status = con.setdata("insert into bill_info ( id ,  name , natid  , phone , daysnumber , roomid , datel , cash   ) values (  '" + null + "' ,'" + name_txt.Text + "' , '" + Convert.ToUInt64(natid_txt.Text) + "' , " + Convert.ToInt64(phone_txt.Text) + "  , " + Convert.ToInt64(daysnumber_txt.Text) + " , " + Convert.ToInt64(date_txt.Text) + " , '" + date1_txt.Text + "' , " + Convert.ToInt64( cash_txt.Text )+ " )");
               
            }
            catch (Exception en)
            {
                MessageBox.Show(en.Message);
            }

            this.Close(); 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            PrintScreen();
            printPreviewDialog1.ShowDialog();
            button1.Enabled = true;
            button3.Enabled = false;
           
            
        }

        private void phone_txt_Click(object sender, EventArgs e)
        {

        }
        ////// ptint function //////////// 

               [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private Bitmap memoryImage;
        private void PrintScreen()
        {
            Graphics mygraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
           
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        public void date()        {
            string date = DateTime.UtcNow.ToString("yyyy-MM-dd");
            date1_txt.Text = date; 

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
