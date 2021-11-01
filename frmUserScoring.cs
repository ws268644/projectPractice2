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
    public partial class frmUserScoring : Form
    {
        public frmUserScoring()
        {
            InitializeComponent();
        }

        private void frmUserScoring_Load(object sender, EventArgs e)
        {
            clsDatabase objDatabase = new clsDatabase();
            string sCommand = "SELECT * FROM t_Scores";
            //MySqlCommand myCom = new MySqlCommand(sCommand, cnn);

            DataTable dt = objDatabase.getDataTable(sCommand);

            foreach (DataRow dr in dt.Rows)
            {
                int iId = Convert.ToInt32(dr[0]);
                string sName = Convert.ToString(dr[1]);
                int iScore = Convert.ToInt32(dr[2]);

                cboNames.Items.Add(sName);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = cboNames.SelectedIndex;
            int score = Convert.ToInt32(nudRating.Value);
            clsDatabase objDatabase = new clsDatabase();
            string sCommand = "UPDATE t_Scores SET Score = '"+score+"' WHERE UID = '"+id+"'";
            objDatabase.Update(sCommand);
        }
    }
}
