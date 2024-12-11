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

        int childrenguest = 0;
        int adultsguest = 0;

        int adultguestprice;
        double discount;

        public UC_BOOKING_CONFIRMATION()
        {
            InitializeComponent();
        }
        private void label20_Click(object sender, EventArgs e)
        {

        }

        public event EventHandler arrowClicked;
        private void pbArrow1st_Click(object sender, EventArgs e)
        {
            arrowClicked?.Invoke(this, EventArgs.Empty);
        }

        private void button4_Click(object sender, EventArgs e) 
        {
            int totalguest = childrenguest + adultsguest;

            // Input validation
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
                SqlCommand bookinginfo = new SqlCommand("INSERT INTO BookInfo (firstname, lastname, email, phone, checkin, checkout) VALUES (@firstname, @lastname, @email, @phone, @checkin, @checkout)", con);

                bookinginfo.Parameters.AddWithValue("@firstname", TxtFname.Text.Trim());
                bookinginfo.Parameters.AddWithValue("@lastname", TxtLname.Text.Trim());
                bookinginfo.Parameters.AddWithValue("@email", TxtEmail.Text.Trim());
                bookinginfo.Parameters.AddWithValue("@phone", TxtPhone.Text.Trim());
                bookinginfo.Parameters.AddWithValue("@checkin", dateTimeCheckin.Value.ToString("yyyy-MM-dd"));
                bookinginfo.Parameters.AddWithValue("@checkout", dateTimeCheckout.Value.ToString("yyyy-MM-dd"));

                int i = bookinginfo.ExecuteNonQuery();
                con.Close();

                if (i != 0)
                {
                    Reservation_Successful_PopUp rsp = new Reservation_Successful_PopUp();
                    rsp.ShowDialog();
                    ClearInputs();
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
            int quantityBlanket = string.IsNullOrWhiteSpace(txtSB.Text) ? 0 : Convert.ToInt16(txtSB.Text);
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

        private void setRoomNamePrices(string chosenRoom)
        {

        }
        public void SetRoomDetails(string roomName, double roomPrice)
        {
            nameofroomLabel.Text = roomName;
            priceofroomLabel.Text = Convert.ToString(roomPrice);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            adultsguest++;
            if (adultsguest >= 7)
            {
                adultsguest = 0;
            }
            lblNumberOfAdults.Text = Convert.ToString(adultsguest);
        }

        private void btnSubAdult_Click(object sender, EventArgs e)
        {
            adultsguest--;
            if (adultsguest < 0)
            {
                adultsguest = 0;
            }
            lblNumberOfAdults.Text = Convert.ToString(adultsguest);
        }

        private void btnAddChildren_Click(object sender, EventArgs e)
        {
            childrenguest++;
            if (childrenguest >= 7)
            {
                childrenguest = 0;
            }
            lblNumberOfChildren.Text = Convert.ToString(childrenguest);
        }
    }
}