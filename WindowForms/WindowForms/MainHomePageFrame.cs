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
            LoadUC(new UC_HOME());
        }

        private void add_UControls(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            parentPanel.Controls.Clear();
            parentPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        public void LoadUC<T>(T userControl) where T : UserControl
        {
            //MainHomePage
            if (userControl is UC_HOME homeControl)
            {
                homeControl.LearnMoreClicked += (sender, e) => LoadUC(new UC_LEARNMORE());
                homeControl.viewRoomsClicked += (sender, e) => LoadUC(new UC_ROOMS());
                homeControl.roomAVAILClicked += (sender, e) => LoadUC(new UC_ROOM_AVAILABILITY());
                homeControl.bookconfirmClicked += (sender, e) => LoadUC(new UC_BOOKING_CONFIRMATION());
            }
            else if (userControl is UC_OFFERS offersControl)
            {
                offersControl.LearnMoreClicked += (sender, e) => LoadUC(new UC_LEARNMORE());
                offersControl.viewRoomsClicked += (sender, e) => LoadUC(new UC_ROOMS());
                offersControl.roomAVAILClicked += (sender, e) => LoadUC(new UC_ROOM_AVAILABILITY());
            }

            //HomePage search button => UC_ROOM_AVAILABILITY => UC_BOOKING_CONFIRMATION2nd 
            if (userControl is UC_ROOM_AVAILABILITY roomAvailability)
            {
                roomAvailability.Room1Clicked += (sender, e) => LoadUC(new UC_BOOKING_CONFIRMATION2nd());
                roomAvailability.Room2Clicked += (sender, e) => LoadUC(new UC_BOOKING_CONFIRMATION2nd());
                roomAvailability.Room3Clicked += (sender, e) => LoadUC(new UC_BOOKING_CONFIRMATION2nd());
                roomAvailability.Room4Clicked += (sender, e) => LoadUC(new UC_BOOKING_CONFIRMATION2nd());
                roomAvailability.Room5Clicked += (sender, e) => LoadUC(new UC_BOOKING_CONFIRMATION2nd());
            }

            //UC_BOOKING_CONFIRMATION2nd => UC_ROOM_AVAILABILITY
            if (userControl is UC_BOOKING_CONFIRMATION2nd booking2nd)
            {
                booking2nd.arrowClicked += (sender, e) => LoadUC(new UC_ROOM_AVAILABILITY());
            }

            //HomePage => UC_ROOMS
            if (userControl is UC_ROOMS roomsControl)
            {
                roomsControl.roomSearchClicked += (sender, e) => LoadUC(new UC_ROOM_AVAILABILITY());
                roomsControl.StandardRoomClicked += (sender, e) => LoadUC(new UC_STANDARD_ROOM());
                roomsControl.SingleRoomClicked += (sender, e) => LoadUC(new UC_SINGLE_ROOM());
                roomsControl.TripleRoomClicked += (sender, e) => LoadUC(new UC_TRIPLE_ROOM());
                roomsControl.SuiteRoomClicked += (sender, e) => LoadUC(new UC_SUITE_ROOM());
                roomsControl.DeluxeRoom += (sender, e) => LoadUC(new UC_DELUXE_ROOM());
            }

            // Any ROOMS Clicked => UC_BOOKING_CONFIRMATION(
            if (userControl is UC_STANDARD_ROOM standardRoomControl)
            {
                standardRoomControl.StandardReserveClicked += (sender, e) => LoadUC(new UC_BOOKING_CONFIRMATION());
                standardRoomControl.arrowClicked += (sender, e) => LoadUC(new UC_ROOMS());
            }

            if (userControl is UC_SINGLE_ROOM singleRoomControl)
            {
                singleRoomControl.SingleReserveClicked += (sender, e) => LoadUC(new UC_BOOKING_CONFIRMATION());
                singleRoomControl.arrowClicked += (sender, e) => LoadUC(new UC_ROOMS());
            }

            if (userControl is UC_TRIPLE_ROOM tripleRoomControl)
            {
                tripleRoomControl.TripleReserveClicked += (sender, e) => LoadUC(new UC_BOOKING_CONFIRMATION());
                tripleRoomControl.arrowClicked += (sender, e) => LoadUC(new UC_ROOMS());
            }

            if (userControl is UC_SUITE_ROOM suiteRoomControl)
            {
                suiteRoomControl.SuiteReserveClicked += (sender, e) => LoadUC(new UC_BOOKING_CONFIRMATION());
                suiteRoomControl.arrowClicked += (sender, e) => LoadUC(new UC_ROOMS());
            }

            if (userControl is UC_DELUXE_ROOM deluxeRoomControl)
            {
                deluxeRoomControl.DeluxeReserveClicked += (sender, e) => LoadUC(new UC_BOOKING_CONFIRMATION());
                deluxeRoomControl.arrowClicked += (sender, e) => LoadUC(new UC_ROOMS());
            }

            //UC_BOOKING_CONFIRMATION back to => UC_ROOMS
            if (userControl is UC_BOOKING_CONFIRMATION booking1st)
            {
                booking1st.arrowClicked += (sender, e) => LoadUC(new UC_ROOMS());
            }

            //Clicked Manage Reservation && No Reservation =>  UC_NO_RESERVATIONS
            if (userControl is UC_NO_RESERVATIONS searchControl)
            {
                searchControl.searchClicked1 += (sender, e) => LoadUC(new UC_STANDARD_ROOM());
                searchControl.searchClicked2 += (sender, e) => LoadUC(new UC_SINGLE_ROOM());
                searchControl.searchClicked3 += (sender, e) => LoadUC(new UC_TRIPLE_ROOM());
                searchControl.searchClicked4 += (sender, e) => LoadUC(new UC_SUITE_ROOM());
                searchControl.searchClicked5 += (sender, e) => LoadUC(new UC_DELUXE_ROOM());
            }


            //Any ROOMS Cancellation && Login => HomePage
            if (userControl is UC_STANDARDROOM_CANCELLATION standardCancelControl)
            {
                standardCancelControl.arrowClicked += (sender, e) => LoadUC(new UC_HOME());
            }

            if (userControl is UC_SINGLE_ROOM singleCancelControl)
            {
                singleCancelControl.arrowClicked += (sender, e) => LoadUC(new UC_HOME());
            }

            if (userControl is UC_TRIPLE_ROOM tripleCancelControl)
            {
                tripleCancelControl.arrowClicked += (sender, e) => LoadUC(new UC_HOME());
            }

            if (userControl is UC_SUITE_ROOM suiteCancelControl)
            {
                suiteCancelControl.arrowClicked += (sender, e) => LoadUC(new UC_HOME());
            }

            if (userControl is UC_DELUXE_ROOM deluxeCancelControl)
            {
                deluxeCancelControl.arrowClicked += (sender, e) => LoadUC(new UC_HOME());
            }

            add_UControls(userControl);
        }

        public void FeedbackToHome()
        {
            parentPanel.Controls.Clear();
            var homeControl = new UC_HOME();
            homeControl.Dock = DockStyle.Fill;
            parentPanel.Controls.Add(homeControl);
            homeControl.BringToFront();
        }


        private void btnAbout_Click(object sender, EventArgs e)
        {
            cmsAbout.Show(btnAbout, 0, btnAbout.Height);
        }

        private void btnManageReservations_Click(object sender, EventArgs e)
        {
            cmsAccount.Show(btnAccount, 0, btnAccount.Height);
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
                    LoadUC(new UC_ROOMS());
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
                    case "menuManageReserve":
                        
                        
                        
                        
                        
                        LoadUC(new UC_NO_RESERVATIONS());
                        break;
                }
            }
            else
            {
                MessageBox.Show("Unexpected sender type in MenuItem_Click", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuLogin_Click(object sender, EventArgs e)
        {
            LoginFrame loginFrame = new LoginFrame();
            loginFrame.Show();
        }


    }
}