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
    public partial class UC_ROOM_AVAILABILITY : UserControl
    {
        public event EventHandler singlebedroomClicked, standardbedroomClicked, triplebedroomClicked, deluxebedroomClicked, suitebedroomClicked, searchClicked;
        UC_BOOKING_CONFIRMATION ucbookconfirmation = new UC_BOOKING_CONFIRMATION();

        private int singlebedroomguestnum = 0;
        private int standardbedroomguestnum = 0;
        private int triplebedroomguestnum = 0;
        private int suitebedroomguestnum = 0;
        private int deluxebedroomguestnum = 0;


        public UC_ROOM_AVAILABILITY()
        {
            InitializeComponent();
        }

        public void addGuest(string roomType)
        {
            switch (roomType)
            {
                case "SingleBedRoom":
                    singlebedroomguestnum++;
                    if (singlebedroomguestnum >= 11)
                    {
                        singlebedroomguestnum = 0;
                    }
                    labelsinglebedGuest.Text = singlebedroomguestnum.ToString();
                    break;
                case "StandardBedRoom":
                    standardbedroomguestnum++;
                    if (standardbedroomguestnum >= 11)
                    {
                        standardbedroomguestnum = 0;
                    }
                    standardroomLbl.Text = standardbedroomguestnum.ToString();
                    break;
                case "TripleBedRoom":
                    triplebedroomguestnum++;
                    if (triplebedroomguestnum >= 11)
                    {
                        triplebedroomguestnum = 0;
                    }
                    triplebedLabel.Text = triplebedroomguestnum.ToString();
                    break;
                case "SuitedBedRoom":
                    suitebedroomguestnum++;
                    if (suitebedroomguestnum >= 11)
                    {
                        suitebedroomguestnum = 0;
                    }
                    suitebedLabel.Text = suitebedroomguestnum.ToString();
                    break;
                case "DeluxeBedRoom":
                    deluxebedroomguestnum++;
                    if (deluxebedroomguestnum >= 11)
                    {
                        deluxebedroomguestnum = 0;
                    }
                    deluxeroomLabel.Text = deluxebedroomguestnum.ToString();
                    break;
            }
        }
        public void subtractGuest(string roomType)
        {
            switch (roomType)
            {
                case "SingleBedRoom":
                    singlebedroomguestnum--;
                    if (singlebedroomguestnum >= 11)
                    {
                        singlebedroomguestnum = 0;
                    }
                    labelsinglebedGuest.Text = singlebedroomguestnum.ToString();
                    break;
                case "StandardBedRoom":
                    standardbedroomguestnum--;
                    if (standardbedroomguestnum <= 0)
                    {
                        standardbedroomguestnum = 0;
                    }
                    standardroomLbl.Text = standardbedroomguestnum.ToString();
                    break;
                case "TripleBedRoom":
                    triplebedroomguestnum++;
                    if (triplebedroomguestnum <= 0)
                    {
                        triplebedroomguestnum = 0;
                    }
                    triplebedLabel.Text = triplebedroomguestnum.ToString();
                    break;
                case "SuitedBedRoom":
                    suitebedroomguestnum--;
                    if (suitebedroomguestnum <= 0)
                    {
                        suitebedroomguestnum = 0;
                    }
                    suitebedLabel.Text = suitebedroomguestnum.ToString();
                    break;
                case "DeluxeBedRoom":
                    deluxebedroomguestnum--;
                    if (deluxebedroomguestnum <= 0)
                    {
                        deluxebedroomguestnum = 0;
                    }
                    deluxeroomLabel.Text = deluxebedroomguestnum.ToString();
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            standardbedroomClicked?.Invoke(this, EventArgs.Empty);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            singlebedroomClicked?.Invoke(this, EventArgs.Empty);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            triplebedroomClicked?.Invoke(this, EventArgs.Empty);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            suitebedroomClicked?.Invoke(this, EventArgs.Empty);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            deluxebedroomClicked?.Invoke(this, EventArgs.Empty);
        }

        private void button6_Click(object sender, EventArgs e) // add button for single bed
        {
            addGuest("SingleBedRoom");
        }

        private void singlebedSubBtn_Click(object sender, EventArgs e)
        {
            subtractGuest("SingleBedRoom");
        }

        private void button17_Click(object sender, EventArgs e) //add button for standard bed
        {
            addGuest("StandardBedRoom");
        }
        private void standardSubBtn_Click(object sender, EventArgs e)
        {
            subtractGuest("StandardBedRoom");
        }

        private void triplebedAddBtn_Click(object sender, EventArgs e)
        {
            addGuest("TripleBedRoom");
        }

        private void triplebedsubBtn_Click(object sender, EventArgs e)
        {
            subtractGuest("TripleBedRoom");
        }

        private void suitebedAddBtn_Click(object sender, EventArgs e)
        {
            addGuest("SuitedBedRoom");
        }

        private void suitebedsubBtn_Click(object sender, EventArgs e)
        {
            subtractGuest("SuitedBedRoom");
        }

        private void deluxeroomAddBtn_Click(object sender, EventArgs e)
        {
            addGuest("DeluxeBedRoom");
        }

        private void deluxeroomSubBtn_Click(object sender, EventArgs e)
        {
            subtractGuest("DeluxeBedRoom");
        }
        private void pnlFill_Paint(object sender, PaintEventArgs e)
        {

        }

        int guestnum = 1;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            guestnum++;
            if (guestnum >= 7)
            {
                guestnum = 1;
            }
            lblNumberOfGuests.Text = Convert.ToString(guestnum);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            guestnum--;
            if (guestnum <= 0)
            {
                guestnum = 1;
            }
            lblNumberOfGuests.Text = Convert.ToString(guestnum);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchClicked?.Invoke(this, EventArgs.Empty);
        }
        public void setCheckInOutDate(string checkin, string checkout)
        {
            dtpCheckIn.Value = DateTime.Parse(checkin);
            dtpCheckOut.Value = DateTime.Parse(checkout);
        }
    }
}
