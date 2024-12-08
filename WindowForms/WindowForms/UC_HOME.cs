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
            BookingConfirmationFrame bcf = new BookingConfirmationFrame();
            bcf.ShowDialog();
        }
    }
}
