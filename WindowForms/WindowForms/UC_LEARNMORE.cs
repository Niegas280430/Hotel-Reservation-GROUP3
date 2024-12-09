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
    public partial class UC_LEARNMORE : UserControl
    {
        public UC_LEARNMORE()
        {
            InitializeComponent();
        }

        private void UC_LEARNMORE_Load(object sender, EventArgs e)
        {
            pbButtomFrame.TabStop = true;
            pbButtomFrame.Focus();
            ScrollToControlLM(pbButtomFrame);
        }

        private void ScrollToControlLM(Control control)
        {
            if (control.Parent is Panel parentPanel && parentPanel.AutoScroll)
            {
                parentPanel.ScrollControlIntoView(control);
            }
        }
    }
}
