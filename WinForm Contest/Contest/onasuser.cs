using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using MySql.Data.MySqlClient;

namespace Contest
{
    public partial class onasuser : UserControl
    {
        SmtpClient client = new SmtpClient();
        Form1 form1 = new Form1();
        private MySqlConnection conn;
        public onasuser()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("file:///C:/Users/micha/Documents/GitHub/contest/www/index.html");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection(form1.connectionString);
            try
            {
                client.Credentials = new NetworkCredential("testsmtpwinform@gmail.com", "79b7c73d692d1d3c47d43a5a69c9af73ae127943c69f1b649bc6e4d53301645d");
                client.EnableSsl = true;
                client.Port = 587;
                conn.Open();
                string query = "select adres,haslo from email where id = 1";
                MySqlCommand com = new MySqlCommand(query, conn);
                MySqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    client.Host = "smtp.gmail.com";
                    conn = new MySqlConnection(form1.connectionString);
                    client.Credentials = new NetworkCredential(dr.GetString(0),dr.GetString(1));
                    client.EnableSsl = true;
                    client.Port = 587;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress(emailtxt.Text.Trim());
                    mail.To.Add(dr.GetString(0));
                    mail.Subject = imietxt.Text.Trim();
                    mail.Body = emailtxt.Text.Trim() + "<br>" + wiadomosctxt.Text.Trim();
                    mail.IsBodyHtml = true;
                    client.Send(mail);
                    conn.Close();
                    client.Dispose();
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        {
                            MessageBox.Show("Cannot connect to server");
                            conn.Close();
                            client.Dispose();
                            break;
                        }
                    case 1045:
                        {
                            MessageBox.Show("Invalid username or password");
                            conn.Close();
                            client.Dispose();
                            break;
                        }
                }

            }
        }
    }
}