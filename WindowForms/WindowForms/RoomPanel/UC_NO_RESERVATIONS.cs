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
    public partial class UC_NO_RESERVATIONS : UserControl
    {
        public event EventHandler searchClicked1, searchClicked2,
            searchClicked3, searchClicked4, searchClicked5;
        public UC_NO_RESERVATIONS()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchClicked1?.Invoke(this, EventArgs.Empty);
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            searchClicked2?.Invoke(this, EventArgs.Empty);
        }

        private void btnSearch3_Click(object sender, EventArgs e)
        {
            searchClicked3?.Invoke(this, EventArgs.Empty);
        }

        private void btnSearch4_Click(object sender, EventArgs e)
        {
            searchClicked4?.Invoke(this, EventArgs.Empty);
        }

        private void btnSearch5_Click(object sender, EventArgs e)
        {
            searchClicked5?.Invoke(this, EventArgs.Empty);
        }
    }
}
