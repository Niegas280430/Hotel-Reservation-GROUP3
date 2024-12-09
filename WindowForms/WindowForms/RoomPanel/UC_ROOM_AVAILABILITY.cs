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
    public partial class UC_ROOM_AVAILABILITY : UserControl
    {
        public event EventHandler Room1Clicked, Room2Clicked, 
            Room3Clicked, Room4Clicked, Room5Clicked;

        public UC_ROOM_AVAILABILITY()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Room1Clicked?.Invoke(this, EventArgs.Empty);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Room2Clicked?.Invoke(this, EventArgs.Empty);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Room3Clicked?.Invoke(this, EventArgs.Empty);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Room4Clicked?.Invoke(this, EventArgs.Empty);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Room5Clicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
