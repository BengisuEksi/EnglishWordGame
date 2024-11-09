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
    public partial class NewAccount : Form
    {
        public NewAccount()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HPJO022;Initial Catalog=EnglishWordGame;Integrated Security=True");
        private void save_bttn_Click(object sender, EventArgs e)
        {
            if(name_txtbox.Text != null && password_txtbox.Text != null && repeatpass_txtbox.Text != null)
            {
                if(password_txtbox.Text == repeatpass_txtbox.Text)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Tbl_Players (Name,Password) values (@p1,@p2)", conn);
                    cmd.Parameters.AddWithValue("@p1", name_txtbox.Text);
                    cmd.Parameters.AddWithValue("@p2", password_txtbox.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Your account is created!","",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Entered passwords are different.","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Fill all the blank spaces.","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            this.Close();
        }

        private void exit_bttn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to log out?", "", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
