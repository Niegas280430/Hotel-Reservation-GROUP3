﻿using System;
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
    public partial class UpdatedMainHomePage : Form
    {
        public UpdatedMainHomePage()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e) { }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            cmsAbout.Show(btnAbout, 0, btnAbout.Height);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}