using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace projectPractice2
{
    public partial class frmHomepage : Form
    {
        public frmHomepage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var frm = new frmLogin();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string conString = "server=ws265660ProjectPractice.remote.ac;user = Admin;database = WS265660_ProjectPractice;password =Ja6g8j9;CharSet=utf8;";
        }
    }
}
