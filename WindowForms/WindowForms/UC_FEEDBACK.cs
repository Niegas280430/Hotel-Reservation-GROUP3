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

namespace WindowForms
{
    public partial class UC_FEEDBACK : UserControl
    {
        public UC_FEEDBACK()
        {
            InitializeComponent();
        }
        private void Star_Click(object sender, EventArgs e)
        {
            PictureBox clickedStar = (PictureBox)sender;

            // Reset all stars to the empty image
            picStar1.Image = Resources.fullStar;
            picStar2.Image = Resources.fullStar;
            picStar3.Image = Resources.fullStar;
            picStar4.Image = Resources.fullStar;
            picStar5.Image = Resources.fullStar;

            // Highlight stars up to and including the clicked star
            if (clickedStar.Name == "picStar1")
            {
                picStar1.Image = Resources.fullStarGif;
            }
            else if (clickedStar.Name == "picStar2")
            {
                picStar1.Image = Resources.fullStarGif;
                picStar2.Image = Resources.fullStarGif;
            }
            else if (clickedStar.Name == "picStar3")
            {
                picStar1.Image = Resources.fullStarGif;
                picStar2.Image = Resources.fullStarGif;
                picStar3.Image = Resources.fullStarGif;
            }
            else if (clickedStar.Name == "picStar4")
            {
                picStar1.Image = Resources.fullStarGif;
                picStar2.Image = Resources.fullStarGif;
                picStar3.Image = Resources.fullStarGif;
                picStar4.Image = Resources.fullStarGif;
            }
            else if (clickedStar.Name == "picStar5")
            {
                picStar1.Image = Resources.fullStarGif;
                picStar2.Image = Resources.fullStarGif;
                picStar3.Image = Resources.fullStarGif;
                picStar4.Image = Resources.fullStarGif;
                picStar5.Image = Resources.fullStarGif;
            }
        }
    }
}
