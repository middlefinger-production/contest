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
        glowna gl = new glowna();
        onasuser onasu = new onasuser();
        public Form2()
        {
            InitializeComponent();
        }
        private void glownabutton_Click(object sender, EventArgs e)
        {
            panel.Controls.Add(gl);
            gl.BringToFront();
            gl.Show();
        }

        private void onasbutton_Click(object sender, EventArgs e)
        {
            panel.Controls.Add(onasu);
            onasu.BringToFront();
            onasu.Show();
        }
    }
}
