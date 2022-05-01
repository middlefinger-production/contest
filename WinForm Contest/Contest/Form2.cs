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
        private glowna gl = new glowna();
        private onasuser onasu = new onasuser();
        private glosowaniauser glosuser = new glosowaniauser();
        private konkursyuser konkuser = new konkursyuser();
        public Form2()
        {
            InitializeComponent();
        }
        private void glownabutton_Click(object sender, EventArgs e)
        {
            clearpanel();
            panel.Controls.Add(gl);
            gl.BringToFront();
            gl.Show();
        }

        private void onasbutton_Click(object sender, EventArgs e)
        { 
            clearpanel();
            panel.Controls.Add(onasu);
            onasu.BringToFront();
            onasu.Show();
        }

        private void konkursybutton_Click(object sender, EventArgs e)
        {
            clearpanel();
            panel.Controls.Add(konkuser);
            konkuser.BringToFront();
            konkuser.Show();
        }

        private void glosowaniabutton_Click(object sender, EventArgs e)
        {
            clearpanel();
            panel.Controls.Add(glosuser);
            glosuser.BringToFront();
            glosuser.Show();
        }

        public void clearpanel()
        {
            panel.Controls.Clear();
        }
    }
}
