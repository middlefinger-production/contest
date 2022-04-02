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
    public partial class Contest : Form
    {
        public Contest()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.BackColor = Color.FromArgb(50, 170, 206);
            logbutton.Location = new Point(this.Width /2 - logbutton.Width/2, this.Height/2 + logbutton.Height);
            logtxt.Location = new Point(this.Width/2 - logtxt.Width/2, this.Height/5 + logtxt.Height);
            passtxt.Location = new Point(this.Width / 2 - passtxt.Width / 2, this.Height / 2 - passtxt.Height);
        }

        private void Contest_Load(object sender, EventArgs e)
        {

        }
    }
}
