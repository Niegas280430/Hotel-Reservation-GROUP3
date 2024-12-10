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
    public partial class UC_SINGLEROOM_CANCELLATION : UserControl
    {
        public UC_SINGLEROOM_CANCELLATION()
        {
            InitializeComponent();
        }

        public event EventHandler StandardReserveClicked, arrowClicked;
        private void pbArrow_Click(object sender, EventArgs e)
        {
            arrowClicked?.Invoke(this, EventArgs.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = "Cancel Reservation";
            string message = "Are you sure?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            DialogResult result = MessageBox.Show(message, title, buttons, icon);

            if (result == DialogResult.Yes)
            {
                Cancel_Reservation_PopUp cancelPopup = new Cancel_Reservation_PopUp();
                cancelPopup.okayClicked += (s, args) =>
                {
                    MainHomePageFrame mainForm = (MainHomePageFrame)FindForm();
                    mainForm.LoadUC(new UC_HOME());
                };
                cancelPopup.ShowDialog();
            }
        }
    }
}
