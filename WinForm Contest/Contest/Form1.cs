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

namespace Contest
{
    public partial class Form1 : Form
    {
        string login, haslo;
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=contest;";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            login = logintxt.Text;
            haslo = textBox2.Text;
            string query = "select haslo from login where login= '"+login+"';";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                if(haslo == dr.GetString(0))
                {
                    logintxt.Text = dr.GetString(0);
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
