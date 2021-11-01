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
using projectPractice2.Classes;
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
            clsDatabase objDatabase = new clsDatabase();
            MySqlConnection cnn = objDatabase.GetConnection();
            string fname = objDatabase.GetFirstUsersName();
            string sCommand = "SELECT * FROM `t_users` WHERE `id` = 1";
            MySqlCommand mycom = new MySqlCommand(sCommand, cnn);

            try
            {
                cnn.Open();
                MySqlDataReader rdr = mycom.ExecuteReader();

                while (rdr.Read()) 
                {
                    clsUser.id = rdr.GetInt32(0);
                    clsUser.fname = rdr.GetString(1);
                    clsUser.lname = rdr.GetString(2);
                    clsUser.timestamp = rdr.GetString(5);
                }


                cnn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("It broke :<\n"+ ex.ToString());
            }
            lblFname.Text = clsUser.id.ToString();
            lblLname.Text = clsUser.fname;
            lblEmail.Text = clsUser.lname;
            lblTimestamp.Text = clsUser.timestamp;
        }

        private void frmHomepage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new frmMenu();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new frmUserScoring();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
    }
}
