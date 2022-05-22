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
using System.Security.Cryptography;
namespace Contest
{
    public partial class Form1 : Form
    {
        private string login, haslo;
        public static string id = "";
        public string connstring = "datasource=127.0.0.1;port=3306;username=root;password=;database=contest;";
        public Form1()
        {
            InitializeComponent();
        }
        private string hash(string haslo)
        {
            Console.WriteLine(haslo);
            var haslobytes = Encoding.ASCII.GetBytes(haslo);
            haslo = "";
            SHA256 sha = new SHA256Managed();
            var hash = sha.ComputeHash(haslobytes);
            foreach (byte b in hash)
            {
                haslo += b.ToString("X2");
            }
            return haslo.ToLower();
            
        }

        public string gethash(string haslo)
        {
            return hash(haslo);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            login = logintxt.Text;
            haslo = textBox2.Text;
            string query = "select haslo,id from login where login= '"+login+"';";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                if(hash(haslo) == dr.GetString(0))
                {
                    logintxt.Text = dr.GetString(0);
                    id = dr.GetString(1);
                    this.Hide();
                    Form2 fr2 = new Form2();
                    fr2.Closed += (s, args) => this.Close();
                    fr2.Show();
                    

                }
                else
                {
                    label4.Visible = true;
                    logintxt.Text = null;
                    textBox2.Text = null;
                }
            }
            else
            {
                label4.Visible = true;
                logintxt.Text = null;
                textBox2.Text = null;
            }

            

        }
    }

   
}
