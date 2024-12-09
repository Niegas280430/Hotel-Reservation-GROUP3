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
            InitializeLoad();
        }

        private void InitializeLoad()
        {
            LoadUC_ROOMS(new UC_ROOMS());
            LoadUC(new UC_ROOM_AVAILABILITY());
            LoadUC(new UC_OFFERS());
            LoadUC(new UC_HOME());
        }

        private void LoadUC<T>(T userControl) where T : UserControl
        {
            if (userControl is UC_HOME homeControl)
            {
                homeControl.LearnMoreClicked += (sender, e) => LoadUC(new UC_LEARNMORE());
                homeControl.viewRoomsClicked += (sender, e) => LoadUC(new UC_ROOMS());
                homeControl.roomAVAILClicked += (sender, e) => LoadUC(new UC_ROOM_AVAILABILITY());
                homeControl.bookingClicked += (sender, e) => LoadUC(new UC_BOOKING_CONFIRMATION());
            }
            else if (userControl is UC_OFFERS offersControl)
            {
                offersControl.LearnMoreClicked += (sender, e) => LoadUC(new UC_LEARNMORE());
                offersControl.viewRoomsClicked += (sender, e) => LoadUC(new UC_ROOMS());
                offersControl.roomAVAILClicked += (sender, e) => LoadUC(new UC_ROOM_AVAILABILITY());
                offersControl.bookingClicked += (sender, e) => LoadUC(new UC_BOOKING_CONFIRMATION());
            }

            add_UControls(userControl); 
        }

        private void LoadUC_ROOMS<T>(T userControl) where T : UserControl
        {
            if (userControl is UC_ROOMS roomsControl)
            {
                roomsControl.StandardRoomClicked += (sender, e) => LoadUC_ROOMS(new UC_STANDARD_ROOM());
                roomsControl.SingleRoomClicked += (sender, e) => LoadUC_ROOMS(new UC_SINGLE_ROOM());
                roomsControl.TripleRoomClicked += (sender, e) => LoadUC_ROOMS(new UC_TRIPLE_ROOM());
                roomsControl.SuiteRoomClicked += (sender, e) => LoadUC_ROOMS(new UC_SUITE_ROOM());
                roomsControl.DeluxeRoom += (sender, e) => LoadUC_ROOMS(new UC_DELUXE_ROOM());
            }

            if (userControl is UC_STANDARD_ROOM standardRoomControl)
            {
                standardRoomControl.StandardReserveClicked += (sender, e) =>
                {
                    LoadUC(new UC_BOOKING_CONFIRMATION());
                };
            }

            add_UControls(userControl);
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
                    LoadUC_ROOMS(new UC_ROOMS());
                    break;
                case "btnStiloLogo":
                    LoadUC(new UC_HOME());
                    break;
                case "btnFaq":
                    add_UControls(new UC_FAQ1());
                    break;
                case "btnOffers":
                    LoadUC(new UC_OFFERS());
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
    }
}
