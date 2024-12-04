using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowForms
{
    public partial class MainHomePageForm : Form
    {
        public MainHomePageForm()
        {
            InitializeComponent();
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void pbtnLogo_Click(object sender, EventArgs e) { }
        private void MainHomePageForm_Load(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        
        private void label8_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label13_Click(object sender, EventArgs e) { }
        private void label14_Click(object sender, EventArgs e) { }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(btnAbout, 0, btnAbout.Height);
        }
    }
}
