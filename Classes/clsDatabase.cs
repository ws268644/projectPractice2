using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace projectPractice2.Classes
{
    class clsDatabase
    {
        private const string conString = "server=ws265660ProjectPractice.remote.ac;user = WS265660_Admin;database = WS265660_ProjectPractice;password =?Ja6g8j9;CharSet=utf8;SslMode=none;";

        public MySqlConnection GetConnection() //Commented code and actual code would do the same thing.
        {
            //MySqlConnection cnn = new MySqlConnection(conString);
            //return cnn;

            return new MySqlConnection(conString);
        }
        public DataTable getDataTable(string sCommand)
        {
            MySqlConnection cnn = GetConnection();
            MySqlDataAdapter dataAdap = new MySqlDataAdapter(sCommand, cnn);
            DataTable dt = new DataTable();

            try
            {
                cnn.Open();

                dataAdap.Fill(dt);

                cnn.Close();
            }
            catch (Exception ex)
            {
                
            }
            return dt;
        }
        public void Update(String sCommand) {
            MySqlConnection cnn = GetConnection();
            MySqlCommand myCom = new MySqlCommand(sCommand, cnn);

            try {
                cnn.Open();
                myCom.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("It worked :>")
            }
            catch (Exception ex){ }
        }
        public string GetFirstUsersName() {
            string fname = "";
            clsDatabase objDatabase = new clsDatabase();
            MySqlConnection cnn = objDatabase.GetConnection();
            string usernameCommand = "SELECT `fname` FROM `t_users`WHERE `ID` = 1";
            MySqlCommand myCom = new MySqlCommand(usernameCommand, cnn);
            try
            {
                cnn.Open();
                fname = myCom.ExecuteScalar().ToString();
                cnn.Close();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return fname;
        }
    }
}
