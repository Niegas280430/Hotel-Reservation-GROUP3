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
    public partial class UC_DELUXE_ROOM : UserControl
    {
        public event EventHandler DeluxeReserveClicked, arrowClicked;
        public UC_DELUXE_ROOM()
        {
            InitializeComponent();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            DeluxeReserveClicked?.Invoke(this, EventArgs.Empty);

        }

        private void pbArrow4_Click(object sender, EventArgs e)
        {
            arrowClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
