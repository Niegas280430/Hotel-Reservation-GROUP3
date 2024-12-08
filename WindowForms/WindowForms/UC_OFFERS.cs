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
    public partial class UC_OFFERS : UserControl
    {
        public UC_OFFERS()
        {
            InitializeComponent();
        }

        private void UC_OFFERS_Load(object sender, EventArgs e)
        {
            pictureBox5.TabStop = true;
            pictureBox5.Focus();
            ScrollToControl(pictureBox5);
        }

        private void ScrollToControl(Control control)
        {
            if (control.Parent is Panel parentPanel && parentPanel.AutoScroll)
            {
                parentPanel.ScrollControlIntoView(control);
            }
        }

        private void btnViewCode_Click(object sender, EventArgs e)
        {
            DiscountCode_PopUp discountCode_PopUp = new DiscountCode_PopUp();
            discountCode_PopUp.Show();
        }
    }
}
