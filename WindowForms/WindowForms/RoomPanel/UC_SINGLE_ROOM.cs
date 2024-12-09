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
    public partial class UC_SINGLE_ROOM : UserControl
    {
        public event EventHandler SingleReserveClicked, arrowClicked;
        public UC_SINGLE_ROOM()
        {
            InitializeComponent();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            SingleReserveClicked?.Invoke(this, EventArgs.Empty);
        }

        private void pbArrow1_Click(object sender, EventArgs e)
        {
            arrowClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
