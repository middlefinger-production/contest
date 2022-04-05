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
        string connection_string = "user id=root;server=localhost;database=contest;";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connection_string);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
            

            

            

        }
    }
}
