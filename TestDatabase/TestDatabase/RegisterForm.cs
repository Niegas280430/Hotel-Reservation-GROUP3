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

namespace TestDatabase
{
    public partial class RegisterForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-2TV9723;Initial Catalog=UserDB;Integrated Security=True");

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = 0;
            con.Open();
            SqlCommand cmdinfo = new SqlCommand("insert into Information(email, userpass) values (@Email, @Password)", con);
  
            cmdinfo.Parameters.AddWithValue("@Email", registeremailTxtBox.Text);
            cmdinfo.Parameters.AddWithValue("@Password", registerpassTxtBox.Text);

            int i = cmdinfo.ExecuteNonQuery();

            if (i != 0)
            {
                MessageBox.Show("Registered Successfully");
                registeremailTxtBox.Clear();
                registerpassTxtBox.Clear();
            }
            else
            {
                MessageBox.Show("Error!");
            }

        }
    }
}
