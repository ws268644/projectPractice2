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

            String conString = "server=ws265660ProjectPractice.remote.ac;user = WS265660_Admin;database = WS265660_ProjectPractice;password =?Ja6g8j9;CharSet=utf8;SslMode=none;";
            MySqlConnection cnn = new MySqlConnection(conString);
            try
            {
                cnn.Open();
                Console.WriteLine("Database Connected!");

                cnn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An errot has occured \n" + ex);
            }
            String username = txtUsername.Text;
            String password = txtPassword.Text;

            if (username == "Gamer")
            {
                if (password == "Chad")
                {
                    MessageBox.Show("You have logged in");
                }
                else { MessageBox.Show("Password is incorrect."); }
            }
            else { MessageBox.Show("Login details are incorrect."); }
        }
    }
}
