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
    public partial class MainHomePageFrame : Form
    {
        ConnectDatabase cd = new ConnectDatabase();
        private string CurrentLoginId { get; set; }
        public MainHomePageFrame()
        {
            InitializeComponent();
            AFTERmenuManageReserve1.Visible = false;
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
            if (userControl is UC_HOME homeControl)
            {
                homeControl.LearnMoreClicked += (sender, e) => LoadUC(new UC_LEARNMORE());
                homeControl.viewRoomsClicked += (sender, e) => LoadUC(new UC_ROOMS());
                homeControl.roomAVAILClicked += (sender, e) => LoadUC(new UC_ROOM_AVAILABILITY());
            }
            else if (userControl is UC_OFFERS offersControl)
            {
                offersControl.LearnMoreClicked += (sender, e) => LoadUC(new UC_LEARNMORE());
                offersControl.viewRoomsClicked += (sender, e) => LoadUC(new UC_ROOMS());
                offersControl.roomAVAILClicked += (sender, e) => LoadUC(new UC_ROOM_AVAILABILITY());
            }

            if (userControl is UC_ROOM_AVAILABILITY roomAvailability)
            {
                roomAvailability.standardbedroomClicked += (sender, e) => LoadUC(new UC_BOOKING_CONFIRMATION());
                roomAvailability.singlebedroomClicked += (sender, e) => LoadUC(new UC_BOOKING_CONFIRMATION());
                roomAvailability.triplebedroomClicked += (sender, e) => LoadUC(new UC_BOOKING_CONFIRMATION());
                roomAvailability.suitebedroomClicked += (sender, e) => LoadUC(new UC_BOOKING_CONFIRMATION());
                roomAvailability.deluxebedroomClicked += (sender, e) => LoadUC(new UC_BOOKING_CONFIRMATION());
            }

            if (userControl is UC_BOOKING_CONFIRMATION2nd booking2nd)
            {
                booking2nd.arrowClicked += (sender, e) => LoadUC(new UC_ROOM_AVAILABILITY());
            }

            if (userControl is UC_ROOMS roomsControl)
            {
                roomsControl.roomSearchClicked += (sender, e) => LoadUC(new UC_ROOM_AVAILABILITY());
                roomsControl.StandardRoomClicked += (sender, e) => LoadUC(new UC_STANDARD_ROOM());
                roomsControl.SingleRoomClicked += (sender, e) => LoadUC(new UC_SINGLE_ROOM());
                roomsControl.TripleRoomClicked += (sender, e) => LoadUC(new UC_TRIPLE_ROOM());
                roomsControl.SuiteRoomClicked += (sender, e) => LoadUC(new UC_SUITE_ROOM());
                roomsControl.DeluxeRoom += (sender, e) => LoadUC(new UC_DELUXE_ROOM());
            }

            if (userControl is UC_STANDARD_ROOM standardRoomControl)
            {
                standardRoomControl.StandardReserveClicked += (sender, e) =>
                {
                    var bookingConfirmation = new UC_BOOKING_CONFIRMATION2nd();
                    bookingConfirmation.SetRoomDetails("(Standard Bedroom)", 2900.00, 2900.00);
                    LoadUC(bookingConfirmation);
                };
                standardRoomControl.arrowClicked += (sender, e) => LoadUC(new UC_ROOMS());
            }

            if (userControl is UC_SINGLE_ROOM singleRoomControl)
            {
                singleRoomControl.SingleReserveClicked += (sender, e) =>
                {
                    var bookingConfirmation = new UC_BOOKING_CONFIRMATION2nd();
                    bookingConfirmation.SetRoomDetails("(Single Bedroom)", 2100.00, 2100.00);
                    LoadUC(bookingConfirmation);
                };
                singleRoomControl.arrowClicked += (sender, e) => LoadUC(new UC_ROOMS());
            }

            if (userControl is UC_TRIPLE_ROOM tripleRoomControl)
            {
                tripleRoomControl.TripleReserveClicked += (sender, e) =>
                {
                    var bookingConfirmation = new UC_BOOKING_CONFIRMATION2nd();
                    bookingConfirmation.SetRoomDetails("(Triple Bedroom)", 3675.00, 3675.00);
                    LoadUC(bookingConfirmation);
                };
                tripleRoomControl.arrowClicked += (sender, e) => LoadUC(new UC_ROOMS());
            }

            if (userControl is UC_SUITE_ROOM suiteRoomControl)
            {
                suiteRoomControl.SuiteReserveClicked += (sender, e) =>
                {
                    var bookingConfirmation = new UC_BOOKING_CONFIRMATION2nd();
                    bookingConfirmation.SetRoomDetails("(Suite Bedroom)", 3900.00, 3900.00);
                    LoadUC(bookingConfirmation);
                };
                suiteRoomControl.arrowClicked += (sender, e) => LoadUC(new UC_ROOMS());
            }

            if (userControl is UC_DELUXE_ROOM deluxeRoomControl)
            {
                deluxeRoomControl.DeluxeReserveClicked += (sender, e) =>
                {
                    var bookingConfirmation = new UC_BOOKING_CONFIRMATION2nd();
                    bookingConfirmation.SetRoomDetails("(Deluxe Bedroom)", 4500.00, 4500.00);
                    LoadUC(bookingConfirmation);
                };
                deluxeRoomControl.arrowClicked += (sender, e) => LoadUC(new UC_ROOMS());
            }

            // NAVIGATE TO UC_ROOM_AVAILABILITY start here
            if (userControl is UC_ROOM_AVAILABILITY singlebedControl)
            {
                singlebedControl.singlebedroomClicked += (sender, e) =>
                {
                    var bookingConfirmation = new UC_BOOKING_CONFIRMATION();
                    bookingConfirmation.SetRoomDetails("(Single Bedroom)", 2100.00, 2100.00);
                    LoadUC(bookingConfirmation);
                };
            }
            if (userControl is UC_ROOM_AVAILABILITY standardbedControl)
            {
                standardbedControl.standardbedroomClicked += (sender, e) =>
                {
                    var bookingConfirmation = new UC_BOOKING_CONFIRMATION();
                    bookingConfirmation.SetRoomDetails("(Standard Bedroom)", 2900.00, 2900.00);
                    LoadUC(bookingConfirmation);
                };
            }
            if (userControl is UC_ROOM_AVAILABILITY triplebedControl)
            {
                triplebedControl.triplebedroomClicked += (sender, e) =>
                {
                    var bookingConfirmation = new UC_BOOKING_CONFIRMATION();
                    bookingConfirmation.SetRoomDetails("(Triple Bedroom)", 3675.00, 3675.00);
                    LoadUC(bookingConfirmation);
                };
            }
            if (userControl is UC_ROOM_AVAILABILITY suitebedControl)
            {
                suitebedControl.suitebedroomClicked += (sender, e) =>
                {
                    var bookingConfirmation = new UC_BOOKING_CONFIRMATION();
                    bookingConfirmation.SetRoomDetails("(Suite Bedroom)", 3900.00, 3900.00);
                    LoadUC(bookingConfirmation);
                };
            }
            if (userControl is UC_ROOM_AVAILABILITY deluxebedControl)
            {
                deluxebedControl.deluxebedroomClicked += (sender, e) =>
                {
                    var bookingConfirmation = new UC_BOOKING_CONFIRMATION();
                    bookingConfirmation.SetRoomDetails("(Deluxe Bedroom)", 4500.00, 4500.00);
                    LoadUC(bookingConfirmation);
                };
            }


            if (userControl is UC_BOOKING_CONFIRMATION booking1st)
            {
                booking1st.arrowClicked += (sender, e) => LoadUC(new UC_ROOMS());
            }

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

            if (userControl is UC_SINGLEROOM_CANCELLATION singleCancelControl)
            {
                singleCancelControl.arrowClicked += (sender, e) => LoadUC(new UC_HOME());
            }

            if (userControl is UC_TRIPLEROOM_CANCELLATION tripleCancelControl)
            {
                tripleCancelControl.arrowClicked += (sender, e) => LoadUC(new UC_HOME());
            }

            if (userControl is UC_SUITEROOM_CANCELLATION suiteCancelControl)
            {
                suiteCancelControl.arrowClicked += (sender, e) => LoadUC(new UC_HOME());
            }

            if (userControl is UC_DELUXEROOM_CANCELLATION deluxeCancelControl)
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

            loginFrame.LoginSuccessful += (s, args) =>
            {
                menuLogin.Visible = false;
                BEFOREmenuManageReserve1.Visible = false;
                AFTERmenuManageReserve1.Visible = true;
            };

            var dialogResult = loginFrame.ShowDialog();

            if (dialogResult == DialogResult.OK && loginFrame.Tag != null)
            {
                // Store the logged-in user ID
                CurrentLoginId = loginFrame.Tag.ToString();

                MessageBox.Show($"Welcome, {CurrentLoginId}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void uC_home1_Load(object sender, EventArgs e)
        {

        }

        private void AFTERmenuManageReserve1_Click(object sender, EventArgs e)
        {
            // Use the stored CurrentLoginId
            if (!string.IsNullOrEmpty(CurrentLoginId))
            {
                using (SqlConnection con = cd.DatabaseConnect())
                {
                    try
                    {
                        con.Open();

                        // Query to fetch room type based on LoginID
                        string query = "SELECT RoomType FROM BookInfo WHERE LoginID = @loginID";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@loginID", CurrentLoginId);

                        // Fetch the room type
                        object result = cmd.ExecuteScalar();
                        string roomType = result?.ToString();

                        if (!string.IsNullOrEmpty(roomType))
                        {
                            // Load appropriate UserControl based on room type
                            switch (roomType)
                            {
                                case "(Standard Bedroom)":
                                    LoadUC(new UC_STANDARDROOM_CANCELLATION());
                                    break;
                                case "(Single Bedroom)":
                                    LoadUC(new UC_SINGLEROOM_CANCELLATION());
                                    break;
                                case "(Triple Bedroom)":
                                    LoadUC(new UC_TRIPLEROOM_CANCELLATION());
                                    break;
                                case "(Suite Bedroom)":
                                    LoadUC(new UC_SUITEROOM_CANCELLATION());
                                    break;
                                case "(Deluxe Bedroom)":
                                    LoadUC(new UC_DELUXEROOM_CANCELLATION());
                                    break;
                                default:
                                    MessageBox.Show("No matching room found for the login ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("No matching room found for the login ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Error handling
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("You must log in first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}