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
    public partial class konkursyuser : UserControl
    {
        public konkursyuser()
        {
            InitializeComponent();
        }

        private void konkursyuser_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(getstring());
            conn.Open();

            
        }

        public string getstring()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=contest;";
            return connectionString;
        }
    }
}
