using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentChoiceProject
{
    public partial class Leaderboard : Form
    {
        public Leaderboard()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        } 
        
        public static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public void DataToView()
        {
            string sql = "select * from Leaderboard Order By Score Desc";
            SQLiteConnection connection = new SQLiteConnection(LoadConnectionString());
            SQLiteDataAdapter dataadapter = new SQLiteDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Leaderboard");
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Leaderboard";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Leaderboard_Load(object sender, EventArgs e)
        {
            DataToView();
        }
    }
}
