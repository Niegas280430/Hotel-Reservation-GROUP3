using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace WindowForms
{
    public partial class LoginFrame : Form
    {
        ConnectDatabase cd = new ConnectDatabase();
        public LoginFrame()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            GenerateCode gc = new GenerateCode();
            
            if (txtboxAccountID.Text == Convert.ToString(gc.generateCode))
            {
                SqlConnection con = cd.DatabaseConnect();
                con.Open();
                MessageBox.Show("Successfully booked");
            }
        }
    }
}
