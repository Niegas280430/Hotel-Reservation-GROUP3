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
    public partial class Cancel_Reservation_PopUp : Form
    {
        public Cancel_Reservation_PopUp()
        {
            InitializeComponent();
        }

        public event EventHandler okayClicked;


        private void btnOkay_Click(object sender, EventArgs e)
        {
            this.Close();
            okayClicked?.Invoke(this, EventArgs.Empty); 
        }
    }
}
