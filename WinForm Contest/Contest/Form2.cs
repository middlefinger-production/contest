using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contest
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Ukrycie();
            stronaglownabox.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ukrycie();
            onasbox.Visible = true;
        }


        public void Ukrycie()
        {
            foreach(Control c in this.Controls)
            {
                if(c is GroupBox)
                {
                    c.Visible = false;
                }
            }
        }

        
    }
}
