using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Contest
{
    public partial class Form1 : Form
    {
        string connection_string = "user id=root2;server=localhost;database=contest;password=123";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(connection_string);
            
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand("select login from login where id = 1;", myConnection);
            myCommand.ExecuteNonQuery();
            try
            {
                SqlDataReader myReader = null;
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    //Console.WriteLine(myReader["Column1"].ToString());
                    //Console.WriteLine(myReader["Column2"].ToString());
                    logintxt.Text = myReader["Column1"].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
