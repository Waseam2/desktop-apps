using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;

namespace hotel_management_system
 
{
    class connection
    {
        public MySqlConnection connect()
        {
            MySqlConnection con = null ;
            try
            {
                 con = new MySqlConnection("server = localhost ; user = root ; password = ; database = hotel_management_system;");
                con.Open();
                return con; ; 
            }
            catch(MySqlException ex)
            {
                Console.WriteLine("error in " + ex.Message);
                return null; 
            }



           
        }
        public bool setdata (string query )
        {
            bool status = false;
            MySqlConnection con;
            con = this.connect();
            MySqlCommand cmd; 
            try
            {
                cmd = new  MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                status = true; 

            }
            catch(MySqlException ms )
            {
                Console.WriteLine("error in"+  ms.Message);
                status = false; 
            }




            return status;
        }
        public bool setdata(string query , Byte[] img , string im ) // for insert image into database ; 
        {
            bool status = false;
            MySqlConnection con;
            con = this.connect();
            MySqlCommand cmd;
            try
            {
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add(new MySqlParameter (im , img ));
                cmd.ExecuteNonQuery();
                status = true;

            }
            catch (MySqlException ms)
            {
                Console.WriteLine("error in" + ms.Message);
                status = false;
            }




            return status;
        }
        public DataSet getdata(string query )
        {
           
            try
            {
                MySqlConnection con;
                MySqlCommand cmd;
                DataSet ds;
                con = connect();
                cmd = new MySqlCommand(query , con);
                MySqlDataAdapter dd = new MySqlDataAdapter(cmd);
                ds = new DataSet(); 
                dd.Fill(ds);
                return ds; 
            }
            catch (MySqlException m )
            {
                Console.WriteLine("error in "+ m.Message);
                return null ; 
            }
        }
    }
}
