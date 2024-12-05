namespace WindowForms
{
    partial class HomePageForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageForm));
            pictureBox1 = new PictureBox();
            btnRegister = new Button();
            btnLogin = new Button();
            pnlLOGO1 = new Panel();
            pnlTOP = new TableLayoutPanel();
            pnlHOME = new Panel();
            btnHOME = new Button();
            pnlROOMS = new Panel();
            btnROOMS = new Button();
            pnlFAQ = new Panel();
            btnFAQ = new Button();
            pnlOFFERS = new Panel();
            btnOFFERS = new Button();
            pnlMAIN = new Panel();
            panelPbox1 = new Panel();
            pbox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlLOGO1.SuspendLayout();
            pnlTOP.SuspendLayout();
            pnlHOME.SuspendLayout();
            pnlROOMS.SuspendLayout();
            pnlFAQ.SuspendLayout();
            pnlOFFERS.SuspendLayout();
            pnlMAIN.SuspendLayout();
            panelPbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnRegister
            // 
            btnRegister.Dock = DockStyle.Right;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(820, 0);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(107, 70);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register?";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Dock = DockStyle.Right;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(713, 0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(107, 70);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login?";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // pnlLOGO1
            // 
            pnlLOGO1.BackColor = SystemColors.Control;
            pnlLOGO1.Controls.Add(btnLogin);
            pnlLOGO1.Controls.Add(btnRegister);
            pnlLOGO1.Controls.Add(pictureBox1);
            pnlLOGO1.Dock = DockStyle.Top;
            pnlLOGO1.Location = new Point(0, 0);
            pnlLOGO1.Name = "pnlLOGO1";
            pnlLOGO1.Size = new Size(927, 70);
            pnlLOGO1.TabIndex = 0;
            // 
            // pnlTOP
            // 
            pnlTOP.BackColor = Color.Cornsilk;
            pnlTOP.ColumnCount = 5;
            pnlTOP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTOP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTOP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTOP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTOP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTOP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            pnlTOP.Controls.Add(pnlHOME, 2, 0);
            pnlTOP.Controls.Add(pnlROOMS, 0, 0);
            pnlTOP.Controls.Add(pnlFAQ, 3, 0);
            pnlTOP.Controls.Add(pnlOFFERS, 1, 0);
            pnlTOP.Dock = DockStyle.Top;
            pnlTOP.Location = new Point(0, 70);
            pnlTOP.Name = "pnlTOP";
            pnlTOP.RowCount = 1;
            pnlTOP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlTOP.Size = new Size(927, 77);
            pnlTOP.TabIndex = 2;
            // 
            // pnlHOME
            // 
            pnlHOME.BackColor = Color.RoyalBlue;
            pnlHOME.Controls.Add(btnHOME);
            pnlHOME.Dock = DockStyle.Fill;
            pnlHOME.Location = new Point(375, 5);
            pnlHOME.Margin = new Padding(5, 5, 5, 0);
            pnlHOME.Name = "pnlHOME";
            pnlHOME.Padding = new Padding(0, 0, 0, 6);
            pnlHOME.Size = new Size(175, 72);
            pnlHOME.TabIndex = 6;
            // 
            // btnHOME
            // 
            btnHOME.BackColor = Color.Cornsilk;
            btnHOME.BackgroundImage = (Image)resources.GetObject("btnHOME.BackgroundImage");
            btnHOME.BackgroundImageLayout = ImageLayout.Zoom;
            btnHOME.Dock = DockStyle.Fill;
            btnHOME.FlatAppearance.BorderSize = 0;
            btnHOME.FlatStyle = FlatStyle.Flat;
            btnHOME.Location = new Point(0, 0);
            btnHOME.Name = "btnHOME";
            btnHOME.Size = new Size(175, 66);
            btnHOME.TabIndex = 1;
            btnHOME.UseVisualStyleBackColor = false;
            btnHOME.Click += Btn_Click;
            // 
            // pnlROOMS
            // 
            pnlROOMS.BackColor = Color.Cornsilk;
            pnlROOMS.Controls.Add(btnROOMS);
            pnlROOMS.Dock = DockStyle.Fill;
            pnlROOMS.Location = new Point(5, 5);
            pnlROOMS.Margin = new Padding(5, 5, 5, 0);
            pnlROOMS.Name = "pnlROOMS";
            pnlROOMS.Padding = new Padding(0, 0, 0, 6);
            pnlROOMS.Size = new Size(175, 72);
            pnlROOMS.TabIndex = 5;
            // 
            // btnROOMS
            // 
            btnROOMS.BackColor = Color.Cornsilk;
            btnROOMS.Dock = DockStyle.Fill;
            btnROOMS.FlatAppearance.BorderSize = 0;
            btnROOMS.FlatStyle = FlatStyle.Flat;
            btnROOMS.Location = new Point(0, 0);
            btnROOMS.Name = "btnROOMS";
            btnROOMS.Size = new Size(175, 66);
            btnROOMS.TabIndex = 0;
            btnROOMS.Text = "ROOMS";
            btnROOMS.UseVisualStyleBackColor = false;
            btnROOMS.Click += Btn_Click;
            // 
            // pnlFAQ
            // 
            pnlFAQ.BackColor = Color.Cornsilk;
            pnlFAQ.Controls.Add(btnFAQ);
            pnlFAQ.Dock = DockStyle.Fill;
            pnlFAQ.Location = new Point(560, 5);
            pnlFAQ.Margin = new Padding(5, 5, 5, 0);
            pnlFAQ.Name = "pnlFAQ";
            pnlFAQ.Padding = new Padding(0, 0, 0, 6);
            pnlFAQ.Size = new Size(175, 72);
            pnlFAQ.TabIndex = 3;
            // 
            // btnFAQ
            // 
            btnFAQ.BackColor = Color.Cornsilk;
            btnFAQ.Dock = DockStyle.Fill;
            btnFAQ.FlatAppearance.BorderSize = 0;
            btnFAQ.FlatStyle = FlatStyle.Flat;
            btnFAQ.Location = new Point(0, 0);
            btnFAQ.Name = "btnFAQ";
            btnFAQ.Size = new Size(175, 66);
            btnFAQ.TabIndex = 1;
            btnFAQ.Text = "FAQ";
            btnFAQ.UseVisualStyleBackColor = false;
            btnFAQ.Click += Btn_Click;
            // 
            // pnlOFFERS
            // 
            pnlOFFERS.BackColor = Color.Cornsilk;
            pnlOFFERS.Controls.Add(btnOFFERS);
            pnlOFFERS.Dock = DockStyle.Fill;
            pnlOFFERS.Location = new Point(190, 5);
            pnlOFFERS.Margin = new Padding(5, 5, 5, 0);
            pnlOFFERS.Name = "pnlOFFERS";
            pnlOFFERS.Padding = new Padding(0, 0, 0, 6);
            pnlOFFERS.Size = new Size(175, 72);
            pnlOFFERS.TabIndex = 1;
            // 
            // btnOFFERS
            // 
            btnOFFERS.BackColor = Color.Cornsilk;
            btnOFFERS.Dock = DockStyle.Fill;
            btnOFFERS.FlatAppearance.BorderSize = 0;
            btnOFFERS.FlatStyle = FlatStyle.Flat;
            btnOFFERS.Location = new Point(0, 0);
            btnOFFERS.Name = "btnOFFERS";
            btnOFFERS.Size = new Size(175, 66);
            btnOFFERS.TabIndex = 1;
            btnOFFERS.Text = "OFFERS";
            btnOFFERS.UseVisualStyleBackColor = false;
            btnOFFERS.Click += Btn_Click;
            // 
            // pnlMAIN
            // 
            pnlMAIN.BackColor = Color.White;
            pnlMAIN.Controls.Add(panelPbox1);
            pnlMAIN.Dock = DockStyle.Fill;
            pnlMAIN.Location = new Point(0, 147);
            pnlMAIN.Name = "pnlMAIN";
            pnlMAIN.Size = new Size(927, 614);
            pnlMAIN.TabIndex = 3;
            // 
            // panelPbox1
            // 
            panelPbox1.Controls.Add(pbox1);
            panelPbox1.Dock = DockStyle.Top;
            panelPbox1.Location = new Point(0, 0);
            panelPbox1.Name = "panelPbox1";
            panelPbox1.Size = new Size(927, 429);
            panelPbox1.TabIndex = 1;
            // 
            // pbox1
            // 
            pbox1.Dock = DockStyle.Fill;
            pbox1.Image = (Image)resources.GetObject("pbox1.Image");
            pbox1.Location = new Point(0, 0);
            pbox1.Name = "pbox1";
            pbox1.Size = new Size(927, 429);
            pbox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbox1.TabIndex = 0;
            pbox1.TabStop = false;
            // 
            // HomePageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(927, 761);
            Controls.Add(pnlMAIN);
            Controls.Add(pnlTOP);
            Controls.Add(pnlLOGO1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "HomePageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home Page";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlLOGO1.ResumeLayout(false);
            pnlTOP.ResumeLayout(false);
            pnlHOME.ResumeLayout(false);
            pnlROOMS.ResumeLayout(false);
            pnlFAQ.ResumeLayout(false);
            pnlOFFERS.ResumeLayout(false);
            pnlMAIN.ResumeLayout(false);
            panelPbox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnRegister;
        private Button btnLogin;
        private Panel pnlLOGO1;
        private MenuStrip miniToolStrip;
        private ToolStripMenuItem aBOUTToolStripMenuItem;
        private ToolStripMenuItem feeToolStripMenuItem;
        private MenuStrip menuStrip1;
        private TableLayoutPanel pnlTOP;
        private Panel pnlFAQ;
        private Panel pnlOFFERS;
        private Button btnOFFERS;
        private Panel pnlMAIN;
        private Button btnFAQ;
        private Panel pnlROOMS;
        private Button btnROOMS;
        private Panel pnlHOME;
        private Button btnHOME;
        private PictureBox pictureBox2;
        private Panel panelPbox1;
        private PictureBox pbox1;
    }
}
