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

namespace TestDatabase
{
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-2TV9723;Initial Catalog=UserDB;Integrated Security=True");
        public LoginForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm rf = new RegisterForm();
            this.Hide();
            rf.ShowDialog();
            this.Close();
        }

        public void loginBtn_Click_1(object sender, EventArgs e)
        {
            string email, pass;
            email = emailTxtBox.Text;
            pass = passTxtBox.Text;
            try
            {
                string querry = "SELECT email, userpass FROM Information WHERE email = '" + emailTxtBox.Text + "' AND userpass = '" + passTxtBox.Text + "'";
                SqlDataAdapter ada = new SqlDataAdapter(querry, con);

                DataTable dtable = new DataTable();
                ada.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    email = emailTxtBox.Text;
                    pass = passTxtBox.Text;

                    MainMenuForm mm = new MainMenuForm();
                    this.Hide();
                    mm.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    emailTxtBox.Clear();
                    passTxtBox.Clear();

                    emailTxtBox.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }        
    }
}
