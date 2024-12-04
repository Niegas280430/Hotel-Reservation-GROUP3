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
    public partial class PracForm : Form
    {
        public PracForm()
        {
            InitializeComponent();
        }

        private void PracForm_Load(object sender, EventArgs e)
        { }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse the label's text to an integer
                int labelValue = int.Parse(lbl.Text);

                // Increment the value
                labelValue++;

                // Update the label
                lbl.Text = labelValue.ToString();
            }
            catch
            {
                // If parsing fails, reset the label to "1"
                lbl.Text = "1";
            }
           



        }
    }
}
