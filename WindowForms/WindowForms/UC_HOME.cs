﻿using System;
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
    public partial class UC_HOME : UserControl
    {
        public event EventHandler LearnMoreClicked,
        roomAVAILClicked, viewRoomsClicked,bookconfirmClicked;
        int guestnum = 1;
        public UC_HOME()
        {
            InitializeComponent();
        }


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

            if (dtpCheckIn.Value.Date < DateTime.Now.Date && dtpCheckOut.Value.Date < DateTime.Now.Date)
            {
                string title = "Invalid Date";
                string message = "Please select current date";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;
                MessageBox.Show(message, title, buttons, icon);
                return;
            }
            else if (dtpCheckIn.Value.Date < DateTime.Now.Date)
            {
                string title = "Invalid Date";
                string message = "Please select current date";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;
                MessageBox.Show(message, title, buttons, icon);
                return;
            }
            else if (dtpCheckOut.Value.Date < DateTime.Now.Date)
            {
                string title = "Invalid Date";
                string message = "Please select current date";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;
                MessageBox.Show(message, title, buttons, icon);
                return;
            }
            else
            {
                roomAVAILClicked?.Invoke(this, EventArgs.Empty);
            }

        }

        private void btnLearnMore_Click(object sender, EventArgs e)
        {
            LearnMoreClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnViewCode_Click(object sender, EventArgs e)
        {
            DiscountCode_PopUp discountCode_PopUp = new DiscountCode_PopUp();
            discountCode_PopUp.Show();
        }

        private void btnViewAllRooms_Click(object sender, EventArgs e)
        {
            viewRoomsClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
