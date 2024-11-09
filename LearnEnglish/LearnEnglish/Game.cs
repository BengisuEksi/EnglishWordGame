using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnEnglish
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }
        public string name;
        public int id;
        int timer = 90;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HPJO022;Initial Catalog=EnglishWordGame;Integrated Security=True");

        private void exit_bttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            name_lbl.Text = name.ToString();

        }
        int correct_ans = 0, wrong_ans = 0, empty_ans = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer > 0)
            {
                timer--;
                time_lbl.Text = timer.ToString() + " s";
            }
            else
            {
                timer1.Stop();
                turkish_txtbox.Enabled = false;
                next_bttn.Enabled = false;
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("Update Tbl_Players set CorrectAnswer=@p1,WrongAnswer=@p2,Unanswered=@p3 where ID=@p4", conn);
                cmd1.Parameters.AddWithValue("@p1", correct_ans);
                cmd1.Parameters.AddWithValue("@p2", wrong_ans);
                cmd1.Parameters.AddWithValue("@p3", empty_ans);
                cmd1.Parameters.AddWithValue("@p4", id);
                cmd1.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Your time is up!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        Random rndm = new Random(DateTime.Now.Millisecond);
        int word_no = 1;
        void bring()
        {
            int no = rndm.Next(1, 101);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Words where ID=@p1", conn);
            cmd.Parameters.AddWithValue("@p1", no);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                english_txtbox.Text = dr[1].ToString();
                correct_answer.Text = dr[2].ToString();
            }
            conn.Close();
        }
        private void start_bttn_Click(object sender, EventArgs e)
        {
            word_no_lbl.Text = word_no.ToString();
            timer1.Start();
            bring();            
        }
        private void results_bttn_Click(object sender, EventArgs e)
        {
            string correct=null, wrong=null, empty=null;
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Players where ID=@p1", conn);
            cmd.Parameters.AddWithValue("@p1", id);
            SqlDataReader da = cmd.ExecuteReader();
            if (da.Read())
            {
                correct = da["CorrectAnswer"].ToString();
                wrong = da["WrongAnswer"].ToString();
                empty = da["Unanswered"].ToString();
            }
            else
            {
                MessageBox.Show("");
            }
            conn.Close();
            string message = "***** Your Results *****" + Environment.NewLine + "Correct Answers: " + correct + Environment.NewLine + "Wrong Answers: " + wrong + Environment.NewLine + "Empty Answers: " + empty;
            MessageBox.Show(message, "Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void next_bttn_Click(object sender, EventArgs e)
        {
            word_no++;
            if (turkish_txtbox.Text == "")
            {
                empty_ans++;
            }
            else
            {
                if (turkish_txtbox.Text == correct_answer.Text)
                {
                    correct_ans++;
                }
                else
                {
                    wrong_ans++;
                }
            }
            bring();
            word_no_lbl.Text = word_no.ToString();
            turkish_txtbox.Text = "";
        }
    }
}
