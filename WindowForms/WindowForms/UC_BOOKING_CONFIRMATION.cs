﻿using System;
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
        private double price;

        public UC_BOOKING_CONFIRMATION()
        {
            InitializeComponent();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
   
        private void setAdditionals()
        {
            // prices of every additionals
            int singlebed = 500;
            int blanket = 100;
            int pillow = 100;
            int bathrobe = 200;
            int bathtowel = 100;

            // quantity of each additionals
            int quantitySingleBed = Convert.ToInt16(txtSB.Text);
            int quantityBlanket = Convert.ToInt16(txtSB.Text);
            int quantityPillow = Convert.ToInt16(txtP.Text);
            int quantityBathrobe = Convert.ToInt16(txtBr.Text);
            int quantityBathTowel = Convert.ToInt16(txtBT.Text);

            // calculate total of additionals with its quantity
            int totalSingleBed = singlebed * quantitySingleBed;
            int totalBlanket = blanket * quantityBlanket;
            int totalPillow = pillow * quantityPillow;
            int totalBathrobe = bathrobe * quantityBathrobe;
            int totalBathTowel = bathtowel * quantityBathTowel;

            double total = totalSingleBed + totalBlanket + totalPillow + totalBathrobe + totalBathTowel;
            double applyTax = total * 1.12;

            if (txtDiscountCode.Text == "10%STILOHotel")
            {
                percentLbl.Text = "12%";
                double discountedAmount = applyTax * 0.10; 
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
            if (txtDiscountCode.Text == "10%STILOHotel")
            {
                double discount = 0.1;
                double newprice;

                MessageBox.Show("Voucher is Applied");
                percentLbl.Text = "10%";
            }
            else
            {
                MessageBox.Show("Discount Code is not Valid!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DiscountCode_PopUp dcp = new DiscountCode_PopUp();
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
                    else
                    {
                        setDiscount();

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            setAdditionals();
        }
    }
}
