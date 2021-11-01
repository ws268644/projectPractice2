using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projectPractice2.Classes;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace projectPractice2
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
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

        private void btnGetDataTable_Click(object sender, EventArgs e)
        {
            const string conString = "server=ws265660ProjectPractice.remote.ac;user = WS265660_Admin;database = WS265660_ProjectPractice;password =?Ja6g8j9;CharSet=utf8;SslMode=none;";

            MySqlConnection cnn = new MySqlConnection(conString);

            string sCommand = "SELECT * FROM t_Scores";
            //MySqlCommand myCom = new MySqlCommand(sCommand, cnn);
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
                MessageBox.Show(ex.ToString());
            }

            dataGridView1.DataSource = dt;

            string sName = "";
            int iScore = 0;
            double dAverage = 0;

            foreach (DataRow dr in dt.Rows)
            {
                string name = dr[1].ToString();
                int score = Convert.ToInt32(dr[2]);
                if (score > iScore) {
                    iScore = score;
                    sName = name;
                }
                dAverage += Convert.ToDouble(score);
                
            }
            dAverage /= dt.Rows.Count;
            lblAverageResult.Text = dAverage.ToString();
            lblHighestResult.Text = iScore.ToString();
            lblNameResult.Text = sName;

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnReader_Click(object sender, EventArgs e)
        {
            const string conString = "server=ws265660ProjectPractice.remote.ac;user = WS265660_Admin;database = WS265660_ProjectPractice;password =?Ja6g8j9;CharSet=utf8;SslMode=none;";

            MySqlConnection cnn = new MySqlConnection(conString);

            string sCommand = "SELECT * FROM t_Scores";
            MySqlCommand myCom = new MySqlCommand(sCommand, cnn);
            //MySqlDataAdapter dataAdap = new MySqlDataAdapter(sCommand, cnn);
            //DataTable dt = new DataTable();
            string sName = "";
            int iScore = 0;
            double dAverage = 0;
            int iCounter = 0;
            try
            {
                

                cnn.Open();

                MySqlDataReader rdr = myCom.ExecuteReader();

                while (rdr.Read())
                {
                    if (rdr.GetInt32(2) > iScore)
                    {
                        iScore = rdr.GetInt32(2);
                        sName = rdr.GetString(1);
                    }
                    dAverage += Convert.ToDouble(rdr.GetInt32(2));
                    iCounter++;
                }

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            dAverage /= Convert.ToDouble(iCounter);
            lblAverageResult.Text = dAverage.ToString();
            lblHighestResult.Text = iScore.ToString();
            lblNameResult.Text = sName;
        }
    }
    }
