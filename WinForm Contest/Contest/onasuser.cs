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

namespace Contest
{
    public partial class onasuser : UserControl
    {
        SmtpClient client = new SmtpClient();
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
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = new NetworkCredential("testsmtpwinform@gmail.com", "testtest123!@");
            client.EnableSsl = true;
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(emailtxt.Text.Trim());
            mail.To.Add("testsmtpwinform@gmail.com");
            mail.Subject = emailtxt.Text.Trim();
            mail.Body = "test";
            mail.IsBodyHtml = true;
            client.Send(mail);

        }
    }
}
