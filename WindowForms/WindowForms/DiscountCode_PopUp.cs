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
    public partial class DiscountCode_PopUp : Form
    {
        public DiscountCode_PopUp()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) { }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            string textToCopy = "10%STILOHotel";
            Clipboard.SetText(textToCopy);
            MessageBox.Show($"Copied to Clipboard: {textToCopy}", "Text Copied", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeCode_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

