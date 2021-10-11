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
            String constring = "jeff";
            //MySqlConnection cnn = new MySqlConnection(constring);
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
