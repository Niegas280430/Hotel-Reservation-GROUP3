using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.Win32;

namespace WindowForms
{

    public partial class UC_BOOKING_CONFIRMATION : UserControl
    {
        ConnectDatabase cd = new ConnectDatabase();
        private UC_ROOM_AVAILABILITY roomsAvail;

        int childrenguest = 1;
        int adultsguest = 1;

        int adultguestprice;
        double discount;

        public UC_BOOKING_CONFIRMATION()
        {
            InitializeComponent();
            termsandconditioncheckBox.CheckedChanged += termsandconditioncheckBox_CheckedChanged;
            booknowBtn.Enabled = false;
        }

        public event EventHandler arrowClicked;
        private void pbArrow1st_Click(object sender, EventArgs e)
        {
            arrowClicked?.Invoke(this, EventArgs.Empty);
        }

        private string GenerateRandomCode(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                                        .Select(s => s[random.Next(s.Length)])
                                        .ToArray());
        }
        private void btnBook_Click(object sender, EventArgs e) // button to enter details and book successfully
        {
            int totalguest = childrenguest + adultsguest;

            if (dateTimeCheckin.Value.Date < DateTime.Now.Date && dateTimeCheckout.Value.Date < DateTime.Now.Date)
            {
                string title = "Invalid Date";
                string message = "Please select current date";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;
                MessageBox.Show(message, title, buttons, icon);
                return;
            }
            else if (dateTimeCheckin.Value.Date < DateTime.Now.Date)
            {
                string title = "Invalid Date";
                string message = "Please select current date";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;
                MessageBox.Show(message, title, buttons, icon);
                return;
            }
            else if (dateTimeCheckout.Value.Date < DateTime.Now.Date)
            {
                string title = "Invalid Date";
                string message = "Please select current date";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;
                MessageBox.Show(message, title, buttons, icon);
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtFname.Text))
            {
                MessageBox.Show("First name is required.");
                TxtFname.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtLname.Text))
            {
                MessageBox.Show("Last name is required.");
                TxtLname.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtEmail.Text))
            {
                MessageBox.Show("Email is required.");
                TxtEmail.Focus();
                return;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(
                         TxtEmail.Text,
                         @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid email format.");
                TxtEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtPhone.Text))
            {
                MessageBox.Show("Phone number is required.");
                TxtPhone.Focus();
                return;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(
                         TxtPhone.Text,
                         @"^\d{10}$"))
            {
                MessageBox.Show("Phone number must contain exactly 10 digits.");
                TxtPhone.Focus();
                return;
            }

            if (totalguest > 6)
            {
                MessageBox.Show("The number of guests exceeds the maximum limit of 6.");
                return;
            }

            // Database insertion
            try
            {
                SqlConnection con = cd.DatabaseConnect();
                con.Open();

                string generatedLoginCode = GenerateRandomCode(5);

                SqlCommand bookinginfo = new SqlCommand(
                    "INSERT INTO BookInfo (loginID, firstname, lastname, email, phone, checkin, checkout) " +
                    "VALUES (@loginID, @firstname, @lastname, @email, @phone, @checkin, @checkout)",
                    con);

                bookinginfo.Parameters.AddWithValue("@loginID", generatedLoginCode); // Assign generated code
                bookinginfo.Parameters.AddWithValue("@firstname", TxtFname.Text.Trim());
                bookinginfo.Parameters.AddWithValue("@lastname", TxtLname.Text.Trim());
                bookinginfo.Parameters.AddWithValue("@email", TxtEmail.Text.Trim());
                bookinginfo.Parameters.AddWithValue("@phone", TxtPhone.Text.Trim());
                bookinginfo.Parameters.AddWithValue("@checkin", dateTimeCheckin.Value.ToString("yyyy-MM-dd"));
                bookinginfo.Parameters.AddWithValue("@checkout", dateTimeCheckout.Value.ToString("yyyy-MM-dd"));
                bookinginfo.Parameters.AddWithValue("@RoomType", nameofroomLabel.Text);

                int i = bookinginfo.ExecuteNonQuery();
                con.Close();

                if (i != 0)
                {
                    MessageBox.Show($"Booking successful! Your login code is: {generatedLoginCode}");
                    ClearInputs();
                    Reservation_Successful_PopUp rsp = new Reservation_Successful_PopUp();
                    rsp.Show();

                }
                else
                {
                    MessageBox.Show("Error occurred while booking. Please try again.");
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void ClearInputs()
        {
            TxtFname.Clear();
            TxtLname.Clear();
            TxtEmail.Clear();
            TxtPhone.Clear();
            txtDiscountCode.Clear();
            lblNumberOfAdults.Text = "0";
            lblNumberOfChildren.Text = "0";
        }

        private void btnSubChildren_Click(object sender, EventArgs e)
        {
            childrenguest--;
            if (childrenguest < 0)
            {
                childrenguest = 0;
            }
            lblNumberOfChildren.Text = Convert.ToString(childrenguest);
        }

        private void setAdditionals()
        {
            // prices of every additionals
            int singlebed = 500;
            int blanket = 100;
            int pillow = 100;
            int bathrobe = 200;
            int bathtowel = 100;

            int adultguest = 700;
            int adultguestquantity = Convert.ToInt16(lblNumberOfAdults.Text);
            int totaladultprice = adultguest * adultguestquantity;

            // quantity for each additionals
            int quantitySingleBed = string.IsNullOrWhiteSpace(txtSB.Text) ? 0 : Convert.ToInt16(txtSB.Text);
            int quantityBlanket = string.IsNullOrWhiteSpace(txtB.Text) ? 0 : Convert.ToInt16(txtB.Text); // Assuming this is for blankets, change if needed
            int quantityPillow = string.IsNullOrWhiteSpace(txtP.Text) ? 0 : Convert.ToInt16(txtP.Text);
            int quantityBathrobe = string.IsNullOrWhiteSpace(txtBr.Text) ? 0 : Convert.ToInt16(txtBr.Text);
            int quantityBathTowel = string.IsNullOrWhiteSpace(txtBT.Text) ? 0 : Convert.ToInt16(txtBT.Text);

            // calculate total of home room price, and additionals with its quantity - WIP
            int totalSingleBed = singlebed * quantitySingleBed;
            int totalBlanket = blanket * quantityBlanket;
            int totalPillow = pillow * quantityPillow;
            int totalBathrobe = bathrobe * quantityBathrobe;
            int totalBathTowel = bathtowel * quantityBathTowel;

            double roomprice;
            roomprice = Convert.ToDouble(priceofroomLabel.Text);

            double total = roomprice + totalSingleBed + totalBlanket + totalPillow + totalBathrobe + totalBathTowel;
            double applyTax = total * 1.12;

            if (txtDiscountCode.Text == "10%STILOHotel")
            {
                setDiscount();
                double discountedAmount = applyTax * discount;
                double finalTotal = applyTax - discountedAmount;

                lblTotalPrice1.Text = finalTotal.ToString("F2");
            }
            else
            {
                lblTotalPrice1.Text = applyTax.ToString("F2");
            }
        }
        private void setDiscount()
        {
            discount = 0.10;

            MessageBox.Show("Voucher is Applied");
            percentLbl.Text = "10%";
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            setAdditionals();
        }

        public void SetRoomDetails(string roomName, double roomPrice, double roomPriceLabel)
        {
            nameofroomLabel.Text = roomName;
            priceofroomLabel.Text = roomPrice.ToString("F2");
            lblTotalPrice1.Text = roomPriceLabel.ToString("F2");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            txtSB.Clear();
            txtB.Clear();
            txtP.Clear();
            txtBr.Clear();
            txtBT.Clear();
            lblTotalPrice1.Text = "<Total Price>";
        }

        private void btnAdd_Click(object sender, EventArgs e) // add adults
        {
            adultsguest++;
            if (adultsguest >= 7)
            {
                adultsguest = 1;
            }
            lblNumberOfAdults.Text = Convert.ToString(adultsguest);
        }

        private void btnSubAdult_Click(object sender, EventArgs e)
        {
            adultsguest--;
            if (adultsguest < 0)
            {
                adultsguest = 1;
            }
            lblNumberOfAdults.Text = Convert.ToString(adultsguest);
        }

        private void btnAddChildren_Click(object sender, EventArgs e)
        {
            childrenguest++;
            if (childrenguest >= 7)
            {
                childrenguest = 1;
            }
            lblNumberOfChildren.Text = Convert.ToString(childrenguest);
        }

        private void btnSubChildren_Click_1(object sender, EventArgs e)
        {
            childrenguest--;
            if (childrenguest < 0)
            {
                childrenguest = 1;
            }
            lblNumberOfChildren.Text = Convert.ToString(childrenguest);
        }

        private void termsandconditioncheckBox_CheckedChanged(object sender, EventArgs e)
        {
            booknowBtn.Enabled = termsandconditioncheckBox.Checked;
        }

        private void btnTerms_Conditions_Click(object sender, EventArgs e)
        {
            Terms_ConditionsFrame tc = new Terms_ConditionsFrame();
            tc.ShowDialog();
        }
    }
}