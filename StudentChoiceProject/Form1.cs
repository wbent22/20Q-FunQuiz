using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentChoiceProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtScore.Text = GetScore().ToString() + "%";
            tabPage1.Enabled = false;
            tabPage2.Enabled = false;
            tabPage3.Enabled = false;
            tabPage4.Enabled = false;
            tabPage5.Enabled = false;
            tabPage6.Enabled = false;
            tabPage7.Enabled = false;
            tabPage8.Enabled = false;
            tabPage9.Enabled = false;
            tabPage10.Enabled = false;
            tabPage11.Enabled = false;
            tabPage12.Enabled = false;
            tabPage13.Enabled = false;
            tabPage14.Enabled = false;
            tabPage15.Enabled = false;
            tabPage16.Enabled = false;
            tabPage17.Enabled = false;
            tabPage18.Enabled = false;
            tabPage19.Enabled = false;
            tabPage20.Enabled = false;
            lblAnswers.Visible = true;
            txtAnswers.Visible = true;
            txtName.Enabled = true;
            btnEname.Enabled = true;

        }

        public double GetScore()
        {
            int correct = 0;
            float score;

            if (rbQ1Answer.Checked == true)
            {
                correct++;
            }
            if (rbQ2answer.Checked == true)
            {
                correct++;
            }
            if (rbQ3answer.Checked == true)
            {
                correct++;
            }
            if (rbQ4answer.Checked == true)
            {
                correct++;
            }
            if (rbQ5answer.Checked == true)
            {
                correct++;
            }
            if (rbQ6answer.Checked == true)
            {
                correct++;
            }
            if (rbQ7answer.Checked == true)
            {
                correct++;
            }
            if (rbQ8answer.Checked == true)
            {
                correct++;
            }
            if (rbQ9answer.Checked == true)
            {
                correct++;
            }
            if (rbQ10answer.Checked == true)
            {
                correct++;
            }
            if (rbQ11answer.Checked == true)
            {
                correct++;
            }
            if (rbQ12answer.Checked == true)
            {
                correct++;
            }
            if (rbQ13answer.Checked == true)
            {
                correct++;
            }
            if (rbQ14answer.Checked == true)
            {
                correct++;
            }
            if (rbQ15answer.Checked == true)
            {
                correct++;
            }
            if (rbQ16answer.Checked == true)
            {
                correct++;
            }
            if (rbQ17answer.Checked == true)
            {
                correct++;
            }
            if (rbQ18answer.Checked == true)
            {
                correct++;
            }
            if (rbQ19answer.Checked == true)
            {
                correct++;
            }
            if (rbQ20answer.Checked == true)
            {
                correct++;
            }

            score = (float)(correct / 20.0 * 100.0);
            
            return score;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void btnEname_Click(object sender, EventArgs e)
        {
            PlayerModel p = new PlayerModel();
            p.Score = txtScore.Text;
            p.Name = txtName.Text;
            AddPlayer(p);
            btnEname.Enabled = false;
        }

        private static void AddPlayer(PlayerModel player)
        {
            using (IDbConnection cnn = new SQLiteConnection(Leaderboard.LoadConnectionString()))
            {
                cnn.Execute("insert into Leaderboard (Score, Name) values (@Score, @Name)", player);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Leaderboard lb = new Leaderboard();
            this.Hide();
            lb.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
