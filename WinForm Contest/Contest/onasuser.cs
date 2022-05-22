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
        readonly Form1 form1 = new Form1();
        public MySqlConnection conn;
        string query = "";
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
            try
            {
                conn = new MySqlConnection(form1.connstring);
                conn.Open();
                query = "select adres,haslo from email where id = 1";
                MySqlCommand com = new MySqlCommand(query, conn);
                MySqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    client.Host = "smtp.gmail.com";
                    client.Port = 587;
                    client.Credentials = new NetworkCredential(dr.GetString(0),dr.GetString(1));
                    client.EnableSsl = true;
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