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
    public partial class addemployee : Form
    {
        connection con = new connection();
        string imagelocattion;
        public addemployee()
        {
            InitializeComponent();

        }

        private void addemployee_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void browesbtn_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (o.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(o.FileName);
                imagelocattion = o.FileName.ToString();
                personalphoto_txt.ImageLocation = imagelocattion; 
               
            }

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            bool found = false; 
            try
            {
                if (lengthtextbox(phone_txt, 11))
                {
                    if (lengthtextbox(natid_txt, 14))  // valid if national id is not equel 14 digits 
                    {
                        if (validnatid(Convert.ToInt64(natid_txt.Text))) /////////// if the national id is duplicated
                        {
                            //////////////// to save image into database 
                            Byte[] image = null;
                            FileStream fstream = new FileStream(imagelocattion, FileMode.Open, FileAccess.Read);
                            BinaryReader br = new BinaryReader(fstream);
                            image = br.ReadBytes((int)fstream.Length);
                            /////////////////////////*************done by (w.s) luxor universty ***************////////////////////////////////////
                            found = con.setdata("insert into employe (name , natid , phone , mail , empdate , birthdate , salary , gender, employeeType , photo , address ) values ('" + name_txt.Text + "' , " + Convert.ToInt64(natid_txt.Text) + " , " + Convert.ToInt64(phone_txt.Text) + " , '" + emial_txt.Text + "' , '" + empdate_txt.Text + "' , '" + birthdate_txt.Text + "' , " + Convert.ToInt32(salary_txt.Text) + " , '" + gender_txt.SelectedItem.ToString() + "', '" + employeeType_txt.SelectedItem.ToString() + "' ,@img , '" + address_txt.Text + "' )", image, "@img");
                            if (found)
                            {
                                MessageBox.Show("saved successful ");

                            }
                            else
                            {
                                MessageBox.Show("saved failed");
                            }
                        }
                    }
                    else
                        MessageBox.Show("the national id is 14 digits ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("phone must be 11 digits " , "ERROR " , MessageBoxButtons.OK , MessageBoxIcon.Warning);
            }
            catch(Exception en )
            {
                MessageBox.Show(en.Message);
            }

           
        }

        private void phone_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void genter_txt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// //////////////////////////validation ////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void name_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !( e.KeyChar == (char)Keys.Space) )
            {
                e.Handled = true; 
            }
        }

        private void natid_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void phone_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && ! char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
        public bool validnatid(long natid) // validation if the national id is alreaady saved 
        {
            try
            {
                if (Convert.ToInt64(con.getdata("select natid from employe where natid = '" + natid.ToString() + "'").Tables[0].Rows[0][0]) != 0)

                {
                    MessageBox.Show("the national id is already exist this can't be duplicated please rewrite the information " , "ERROR" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                    return false ;
                }
               
            }
            catch(Exception en )
            {
               
                return true ; 
            }

            return true ; 
        }

        public bool lengthtextbox(TextBox tt , int n )
        {
            if (Convert.ToInt32(tt.TextLength) == n)
            {
             
                return true;
                
            }
            else
            {
                
                return false; 
            }
             
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
