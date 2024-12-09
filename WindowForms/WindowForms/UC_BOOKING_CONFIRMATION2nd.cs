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
    public partial class UC_BOOKING_CONFIRMATION2nd : UserControl
    {
        public event EventHandler arrowClicked;
        public UC_BOOKING_CONFIRMATION2nd()
        {
            InitializeComponent();
        }

        private void pbArrow2nd_Click(object sender, EventArgs e)
        {
            arrowClicked?.Invoke(this, EventArgs.Empty);
        }

        private void booknowBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
