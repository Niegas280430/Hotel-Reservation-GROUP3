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
    public partial class UC_HOME : UserControl
    {
        public event EventHandler LearnMoreClicked,
            roomAVAILClicked, viewRoomsClicked;
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
                lblNumberOfGuests.Text = Convert.ToString(guestnum);
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
            roomAVAILClicked?.Invoke(this, EventArgs.Empty);
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
