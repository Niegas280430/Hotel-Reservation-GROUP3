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
    public partial class UC_SUITE_ROOM : UserControl
    {
        public event EventHandler SuiteReserveClicked, arrowClicked;
        public UC_SUITE_ROOM()
        {
            InitializeComponent();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            SuiteReserveClicked?.Invoke(this, EventArgs.Empty);
        }

        private void pbArrow3_Click(object sender, EventArgs e)
        {
            arrowClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
