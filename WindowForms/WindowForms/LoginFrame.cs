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

        public event EventHandler LoginSuccessful;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = cd.DatabaseConnect())
            {
                try
                {
                    string enteredloginId = txtboxAccountID.Text;

                    if (string.IsNullOrWhiteSpace(enteredloginId))
                    {
                        MessageBox.Show("Please enter your Login Id.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; 
                    }

                    con.Open();

                    string query = "SELECT COUNT(*) FROM BookInfo WHERE loginID = @loginID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@loginID", enteredloginId);

                    int bilang = (int)cmd.ExecuteScalar();

                    if (bilang > 0)
                    {
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Tag = enteredloginId;

                        LoginSuccessful?.Invoke(this, EventArgs.Empty);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login ID. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error! Please try again. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
