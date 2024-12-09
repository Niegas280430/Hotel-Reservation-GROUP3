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
    public partial class UC_ROOMS : UserControl
    {
        public event EventHandler StandardRoomClicked, SingleRoomClicked,
            TripleRoomClicked, SuiteRoomClicked, DeluxeRoom;
        public UC_ROOMS()
        {
            InitializeComponent();
        }

        private void btnStandardRoomDetails_Click(object sender, EventArgs e)
        {
            StandardRoomClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnSingleRoomDetails_Click(object sender, EventArgs e)
        {
            SingleRoomClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnTripleRoomDetails_Click(object sender, EventArgs e)
        {
            TripleRoomClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnSuiteRoomDetails_Click(object sender, EventArgs e)
        {
            SuiteRoomClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnDeluxeRoomDetails_Click(object sender, EventArgs e)
        {
            DeluxeRoom?.Invoke(this, EventArgs.Empty);
        }
    }
}
