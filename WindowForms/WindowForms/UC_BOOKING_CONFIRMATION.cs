using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Win32;

namespace WindowForms
{

    public partial class UC_BOOKING_CONFIRMATION : UserControl
    {
        ConnectDatabase cd = new ConnectDatabase();

        int childrenguest = 0;
        int adultsguest = 0;

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
                            MessageBox.Show("Booked Room uccessfully");
                            TxtFname.Clear();
                            TxtLname.Clear();
                            TxtEmail.Clear();
                            TxtPhone.Clear();
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
                lblNumberOfAdults.Text = Convert.ToString(adultsguest);
            }
            lblNumberOfAdults.Text = Convert.ToString(adultsguest);
        }

        private void btnSubAdult_Click(object sender, EventArgs e)
        {
            adultsguest--;
            if (adultsguest < 0)
            {
                adultsguest = 0;
                lblNumberOfAdults.Text = Convert.ToString(adultsguest);
            }
            lblNumberOfAdults.Text = Convert.ToString(adultsguest);
        }

        private void btnAddChildren_Click(object sender, EventArgs e)
        {
            childrenguest++;
            if (childrenguest >= 7)
            {
                childrenguest = 0;
                lblNumberOfChildren.Text = Convert.ToString(childrenguest);
            }
            lblNumberOfChildren.Text = Convert.ToString(childrenguest);
        }

        private void btnSubChildren_Click(object sender, EventArgs e)
        {
            childrenguest--;
            if (childrenguest < 0)
            {
                childrenguest = 0;
                lblNumberOfChildren.Text = Convert.ToString(childrenguest);
            }
            lblNumberOfChildren.Text = Convert.ToString(childrenguest);
        }

        public event EventHandler arrowClicked;
        private void pbArrow1st_Click(object sender, EventArgs e)
        {
            arrowClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
