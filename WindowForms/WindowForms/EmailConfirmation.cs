using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowForms
{
    public partial class EmailConfirmation : Form
    {
        ConnectDatabase cd = new ConnectDatabase();
        public EmailConfirmation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection conn = cd.DatabaseConnect();
            conn.Open();
            SqlCommand emailinfo = new SqlCommand("SELECT firstname, lastname, email, phone, checkin, checkout FROM BookInfo WHERE loginID = @loginID");

             
        }
    }
}
