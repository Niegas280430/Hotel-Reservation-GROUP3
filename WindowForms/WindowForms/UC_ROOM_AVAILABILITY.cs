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
        public UC_HOME uchome;
        public UC_ROOM_AVAILABILITY()
        {
            InitializeComponent();
            uchome = new UC_HOME();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.dtpCheckIn.Value = uchome.dtpCheckIn.Value;
            this.dtpCheckOut.Value = uchome.dtpCheckOut.Value;
            datecheckinLbl.Text = this.dtpCheckIn.Value.ToString();
            datecheckoutLbl.Text = this.dtpCheckOut.Value.ToString();
        }
        private void pnlFill_Paint(object sender, PaintEventArgs e)
        {
            this.dtpCheckIn.Value = uchome.dtpCheckIn.Value;
            this.dtpCheckOut.Value = uchome.dtpCheckOut.Value;
            datecheckinLbl.Text = this.dtpCheckIn.Value.ToString();
            datecheckoutLbl.Text = this.dtpCheckOut.Value.ToString();
        }
    }
}
