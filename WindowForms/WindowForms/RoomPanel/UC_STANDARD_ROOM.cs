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
    public partial class UC_STANDARD_ROOM : UserControl
    {
        public event EventHandler StandardReserveClicked;

        public UC_STANDARD_ROOM()
        {
            InitializeComponent();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            StandardReserveClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
