using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowForms.Properties;
using Microsoft.Data.SqlClient;

namespace WindowForms
{
    public partial class UC_FEEDBACK : UserControl
    {

        

        ConnectDatabase conn = new ConnectDatabase();
        public UC_FEEDBACK()
        {
            InitializeComponent();
            
        }

        int selectedRating = 0;

        private void Star_Click(object sender, EventArgs e)
        {
            PictureBox clickedStar = (PictureBox)sender;


            int starNumber = int.Parse(clickedStar.Name.Replace("picStar", ""));
            selectedRating = starNumber;


            for (int i = 1; i <= 5; i++)
            {

                PictureBox star = (PictureBox)this.Controls.Find($"picStar{i}", true)[0];

                star.Image = i <= starNumber ? Resources.fullStarGif : Resources.fullStar;

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (selectedRating == 0)
            {
                MessageBox.Show("Please select a rating before submitting.");
                return;
            }
            else
            {

                using (SqlConnection con = conn.DatabaseConnect())
                {
                    con.Open();

                    string query = "INSERT INTO tbFeedback (Comments, Date, Rating) VALUES (@Comments, @Date, @Rating)";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@Comments", textBox2.Text);
                        command.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                        command.Parameters.AddWithValue("@Rating", selectedRating);

                        command.ExecuteNonQuery();
                    }
                }

                Feedback_Success_PopUp FSP = new Feedback_Success_PopUp();
                FSP.ShowDialog();

            }

        }



        private void btnCancel_Click(object sender, EventArgs e)
        {

            if (this.ParentForm is MainHomePageFrame mainFrame)
            {
                mainFrame.LoadDefaultUserControls();
            }
            else
            {
                MessageBox.Show("Unable to navigate back to the main page.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }

}
