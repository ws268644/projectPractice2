using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectPractice2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string conString = "server=ws265660ProjectPractice.remote.ac;user = WS265660_Admin;database = WS265660_ProjectPractice;password =?Ja6g8j9;CharSet=utf8;SslMode=none;";
            string result = "";
            MySqlConnection cnn = new MySqlConnection(conString);
            string usernameCommand = "SELECT * FROM `t_users` WHERE `email` = " + txtUsername.Text;
            string passwordCommand = "SELECT * FROM `t_users` WHERE `password` = " + txtPassword.Text;
            MySqlCommand myCom = new MySqlCommand(usernameCommand, cnn);
            try
            {
                cnn.Open();
                Console.WriteLine("Database Connected!");
                result = myCom.ExecuteNonQuery().ToString();
                cnn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An errot has occured. \n" + ex);
            }

            if (result == "-1")
            {
            MessageBox.Show("You have logged in");
            }
            else { MessageBox.Show("Login details are incorrect."); }
        }
    }
}
