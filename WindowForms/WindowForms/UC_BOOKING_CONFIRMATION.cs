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

        private void button4_Click(object sender, EventArgs e) // button to enter details and book successfully
        {
            int totalguest = childrenguest + adultsguest;
            try
            {
                SqlConnection con = cd.DatabaseConnect();
                con.Open();
                SqlCommand bookinginfo = new SqlCommand("INSERT INTO BookInfo (firstname, lastname, email, phone, checkin, checkout) VALUES (@firstname, @lastname, @email, @phone, @checkin, @checkout)");

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
                    bookinginfo.Parameters.AddWithValue("@firstname", TxtFname.Text);
                    bookinginfo.Parameters.AddWithValue("@lastname", TxtLname.Text);
                    bookinginfo.Parameters.AddWithValue("@email", TxtEmail.Text);
                    bookinginfo.Parameters.AddWithValue("@phone", TxtPhone.Text);
                    bookinginfo.Parameters.AddWithValue("@checkin", dateTimeCheckin.Text);
                    bookinginfo.Parameters.AddWithValue("@checkout", dateTimeCheckout.Text);

                    int i = bookinginfo.ExecuteNonQuery();

                    if (i != 0)
                    {
                        Reservation_Successful_PopUp rsp = new Reservation_Successful_PopUp();
                        rsp.ShowDialog();
                        TxtFname.Clear();
                        TxtLname.Clear();
                        TxtEmail.Clear();
                        TxtPhone.Clear();
                        if (txtDiscountCode.Text != null)
                        {
                            txtDiscountCode.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Booked Room uccessfully");
                            TxtFname.Clear();
                            TxtLname.Clear();
                            TxtEmail.Clear();
                            TxtPhone.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Information Details"); // need ng label kung ano ung mali or empty
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

        private void setAdditionals()
        {
            // prices of every additionals
            int singlebed = 500;
            int blanket = 100;
            int pillow = 100;
            int bathrobe = 200;
            int bathtowel = 100;

            int adultguest = 700;

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

            double roomprice;
            roomprice = Convert.ToDouble(priceofroomLabel.Text);

            double total = roomprice + totalSingleBed + totalBlanket + totalPillow + totalBathrobe + totalBathTowel;
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
        public void SetRoomDetails(string roomName, double roomPrice)
        {
            nameofroomLabel.Text = roomName;
            priceofroomLabel.Text = Convert.ToString(roomPrice);
        }
       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}