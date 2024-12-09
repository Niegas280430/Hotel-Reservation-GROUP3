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
using Microsoft.Win32;

namespace WindowForms
{

    public partial class UC_BOOKING_CONFIRMATION : UserControl
    {
        ConnectDatabase cd = new ConnectDatabase();

        int childrenguest = 0;
        int adultsguest = 0;
        double discount;
        public UC_BOOKING_CONFIRMATION()
        {
            InitializeComponent();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int totalguest = childrenguest + adultsguest;
            try
            {
                SqlConnection con = cd.DatabaseConnect();

                con.Open();
                SqlCommand bookinginfo = new SqlCommand("INSERT INTO BookInfo (firstname, lastname, email, phone, checkin, checkout) VALUES (@firstname, @lastname, @email, @phone, @checkin, @checkout)", con);

                if (string.IsNullOrEmpty(TxtFname.Text) && string.IsNullOrEmpty(TxtLname.Text) &&
                    string.IsNullOrEmpty(TxtEmail.Text) && string.IsNullOrEmpty(TxtPhone.Text))
                {
                    if (totalguest > 6)
                    {
                        MessageBox.Show("Number of Guest exceeds the 6 amount!");
                        adultsguest = 1;
                        childrenguest = 1;
                        lblNumberOfAdults.Text = Convert.ToString(adultsguest);
                        lblNumberOfChildren.Text = Convert.ToString(childrenguest);
                    }
                }
                else
                {
                    DialogResult option = MessageBox.Show("--Is this the correct information?--" +
                                                      "\nLast Name: " + TxtFname.Text +
                                                      "\nFirst Name: " + TxtLname.Text +
                                                      "\nEmail: " + TxtEmail.Text +
                                                      "\nPhone Number: " + TxtPhone.Text,
                                                      "Confirm", MessageBoxButtons.YesNo);

                    if (option == DialogResult.Yes)
                    {
                        bookinginfo.Parameters.AddWithValue("@firstname", TxtFname.Text);
                        bookinginfo.Parameters.AddWithValue("@lastname", TxtLname.Text);
                        bookinginfo.Parameters.AddWithValue("@email", TxtEmail.Text);
                        bookinginfo.Parameters.AddWithValue("@phone", TxtPhone.Text);
                        bookinginfo.Parameters.AddWithValue("@checkin", dateTimeCheckin.Text);
                        bookinginfo.Parameters.AddWithValue("@checkout", dateTimeCheckout.Text);

                        int i = bookinginfo.ExecuteNonQuery();

                        if (i != 0)
                        {
                            MessageBox.Show("Booked Room successfully");
                            TxtFname.Clear();
                            TxtLname.Clear();
                            TxtEmail.Clear();
                            TxtPhone.Clear();
                        }
                    }
                    else
                    {
                        TxtFname.Clear();
                        TxtLname.Clear();
                        TxtEmail.Clear();
                        TxtPhone.Clear();
                    }
                }
            }
            catch (Exception ex) // iibahin pato ng message
            {
                MessageBox.Show(ex.Message);
            }
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

        private void btnSubChildren_Click(object sender, EventArgs e)
        {
            childrenguest--;
            if (childrenguest < 0)
            {
                childrenguest = 0;
            }
            lblNumberOfChildren.Text = Convert.ToString(childrenguest);
        }

        public event EventHandler arrowClicked;
        private void pbArrow1st_Click(object sender, EventArgs e)
        {
            arrowClicked?.Invoke(this, EventArgs.Empty);
        }     

        private void getRoomNamePrices(string roomType)
        { 

            switch (roomType)
            {
                case "SingleBedRoom":
                    nameofroomLabel.Text = "Single Bedroom";
                    double singlebedroomPrice = 2100.00;
                    break;
                case "StandardBedRoom":
                    nameofroomLabel.Text = "Standard Bedroom";
                    double standardbedroomPrice = 2900.00;
                    break;
                case "TripleBedRoom":
                    nameofroomLabel.Text = "Triple Bedroom";
                    double triplebedroom = 3675.00;
                    break;
                case "SuitedBedRoom":
                    nameofroomLabel.Text = "Suited Bedroom";
                    double suitebedroomprice = 3900.00;
                    break;
                case "DeluxeBedRoom":
                    nameofroomLabel.Text = "Deluxe Bedroom";
                    double deluxebedroomprice = 4500.00;
                    break;
            }
        }
        private void setAdditionals()
        {
            // prices of every additionals
            int singlebed = 500;
            int blanket = 100;
            int pillow = 100;
            int bathrobe = 200;
            int bathtowel = 100;

            // quantity fpr each additionals
            int quantitySingleBed = Convert.ToInt16(txtSB.Text);
            int quantityBlanket = Convert.ToInt16(txtSB.Text);
            int quantityPillow = Convert.ToInt16(txtP.Text);
            int quantityBathrobe = Convert.ToInt16(txtBr.Text);
            int quantityBathTowel = Convert.ToInt16(txtBT.Text);

            // calculate total of home room price, and additionals with its quantity - WIP
            int totalSingleBed = singlebed * quantitySingleBed;
            int totalBlanket = blanket * quantityBlanket;
            int totalPillow = pillow * quantityPillow;
            int totalBathrobe = bathrobe * quantityBathrobe;
            int totalBathTowel = bathtowel * quantityBathTowel;

            double total = totalSingleBed + totalBlanket + totalPillow + totalBathrobe + totalBathTowel;
            double applyTax = total * 1.12;

            if (txtDiscountCode.Text == "10%STILOHotel")
            {
                setDiscount();
                percentLbl.Text = "10%";
                double discountedAmount = applyTax * discount;
                double finalTotal = applyTax - discountedAmount;

                lblTotalPrice1.Text = finalTotal.ToString();
            }
            else
            {
                lblTotalPrice1.Text = applyTax.ToString();
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
    }
}
