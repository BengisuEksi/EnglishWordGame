using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LearnEnglish
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HPJO022;Initial Catalog=EnglishWordGame;Integrated Security=True");

        private void rules_bttn_Click(object sender, EventArgs e)
        {
            Rules fr = new Rules();
            fr.ShowDialog();
        }

        private void exit_bttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int id;
        private void signin_bttn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Players where Name=@p1 and Password=@p2", conn);
            cmd.Parameters.AddWithValue("@p1",name_txtbox.Text);
            cmd.Parameters.AddWithValue("@p2", password_txtbox.Text);
            SqlDataReader da = cmd.ExecuteReader();
            if(da.Read())
            {
                id = da.GetByte(0);
                Game fr = new Game();
                fr.name = name_txtbox.Text;
                fr.id = id;
                this.Hide();
                fr.Show();
            }
            else
            {
                MessageBox.Show("Invalid name or password.", "Failed entry.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void newaccount_bttn_Click(object sender, EventArgs e)
        {
            NewAccount fr = new NewAccount();
            fr.ShowDialog();
        }
    }
}
