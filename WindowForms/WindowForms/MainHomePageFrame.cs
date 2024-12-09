using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowForms
{
    public partial class MainHomePageFrame : Form
    {
        public MainHomePageFrame()
        {
            InitializeComponent();
            LoadUC_HOME();
        }

        private void LoadUC_HOME()
        {
            var uC_Home = new UC_HOME();
            uC_Home.LearnMoreClicked += UC_Home_LearnMoreClicked;
            add_UControls(uC_Home);
        }

        private void UC_Home_LearnMoreClicked(object sender, EventArgs e)
        {
            add_UControls(new UC_LEARNMORE());
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            cmsAbout.Show(btnAbout, 0, btnAbout.Height);
        }

        private void add_UControls(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            parentPanel.Controls.Clear();
            parentPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            switch (btn.Name)
            {
                case "btnFeedback":
                    add_UControls(new UC_FEEDBACK());
                    break;
                case "btnRooms":
                    add_UControls(new UC_ROOMS());
                    break;
                case "btnStiloLogo":
                    LoadUC_HOME();
                    break;
                case "btnFaq":
                    add_UControls(new UC_FAQ1());
                    break;
                case "btnOffers":
                    add_UControls(new UC_OFFERS());
                    break;
            }
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem)
            {
                switch (menuItem.Name)
                {
                    case "ourStoryToolStripMenuItem":
                        add_UControls(new UC_ABOUT());
                        break;
                    case "termsAndConditionsToolStripMenuItem":
                        add_UControls(new UC_TERMS_CONDITIONS());
                        break;
                }
            }
            else
            {
                MessageBox.Show("Unexpected sender type in MenuItem_Click", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnManageReservations_Click(object sender, EventArgs e)
        {

        }

        private void uC_home1_Load(object sender, EventArgs e)
        {

        }
    }
}
