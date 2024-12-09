namespace WindowForms
{
    partial class MainHomePageFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnStiloLogo = new Button();
            btnOffers = new Button();
            btnRooms = new Button();
            btnAccount = new Button();
            btnFaq = new Button();
            btnAbout = new Button();
            btnFeedback = new Button();
            parentPanel = new Panel();
            uC_home1 = new UC_HOME();
            cmsAbout = new ContextMenuStrip(components);
            ourStoryToolStripMenuItem = new ToolStripMenuItem();
            termsAndConditionsToolStripMenuItem = new ToolStripMenuItem();
            cmsAccount = new ContextMenuStrip(components);
            menuLogin = new ToolStripMenuItem();
            menuManageReserve = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            parentPanel.SuspendLayout();
            cmsAbout.SuspendLayout();
            cmsAccount.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(248, 246, 240);
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.75862F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.24138F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 261F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 156F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 109F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 175F));
            tableLayoutPanel1.Controls.Add(btnStiloLogo, 3, 0);
            tableLayoutPanel1.Controls.Add(btnOffers, 2, 0);
            tableLayoutPanel1.Controls.Add(btnRooms, 1, 0);
            tableLayoutPanel1.Controls.Add(btnAccount, 6, 0);
            tableLayoutPanel1.Controls.Add(btnFaq, 5, 0);
            tableLayoutPanel1.Controls.Add(btnAbout, 4, 0);
            tableLayoutPanel1.Controls.Add(btnFeedback, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1152, 87);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // btnStiloLogo
            // 
            btnStiloLogo.BackgroundImage = Properties.Resources.HOTEL_LOGO1;
            btnStiloLogo.FlatAppearance.BorderSize = 0;
            btnStiloLogo.FlatStyle = FlatStyle.Flat;
            btnStiloLogo.Location = new Point(453, 3);
            btnStiloLogo.Name = "btnStiloLogo";
            btnStiloLogo.Size = new Size(255, 81);
            btnStiloLogo.TabIndex = 9;
            btnStiloLogo.UseVisualStyleBackColor = true;
            btnStiloLogo.Click += Btn_Click;
            // 
            // btnOffers
            // 
            btnOffers.FlatAppearance.BorderSize = 0;
            btnOffers.FlatStyle = FlatStyle.Flat;
            btnOffers.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOffers.Location = new Point(293, 3);
            btnOffers.Name = "btnOffers";
            btnOffers.Size = new Size(154, 81);
            btnOffers.TabIndex = 6;
            btnOffers.Text = "OFFERS";
            btnOffers.UseVisualStyleBackColor = true;
            btnOffers.Click += Btn_Click;
            // 
            // btnRooms
            // 
            btnRooms.FlatAppearance.BorderSize = 0;
            btnRooms.FlatStyle = FlatStyle.Flat;
            btnRooms.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRooms.Location = new Point(156, 3);
            btnRooms.Name = "btnRooms";
            btnRooms.Size = new Size(131, 81);
            btnRooms.TabIndex = 5;
            btnRooms.Text = "ROOMS";
            btnRooms.UseVisualStyleBackColor = true;
            btnRooms.Click += Btn_Click;
            // 
            // btnAccount
            // 
            btnAccount.FlatAppearance.BorderSize = 0;
            btnAccount.FlatStyle = FlatStyle.Flat;
            btnAccount.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAccount.Location = new Point(979, 3);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(170, 81);
            btnAccount.TabIndex = 1;
            btnAccount.Text = "My Account";
            btnAccount.UseVisualStyleBackColor = true;
            btnAccount.Click += btnManageReservations_Click;
            // 
            // btnFaq
            // 
            btnFaq.FlatAppearance.BorderSize = 0;
            btnFaq.FlatStyle = FlatStyle.Flat;
            btnFaq.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFaq.Location = new Point(870, 3);
            btnFaq.Name = "btnFaq";
            btnFaq.Size = new Size(103, 81);
            btnFaq.TabIndex = 3;
            btnFaq.Text = "FAQ";
            btnFaq.UseVisualStyleBackColor = true;
            btnFaq.Click += Btn_Click;
            // 
            // btnAbout
            // 
            btnAbout.FlatAppearance.BorderSize = 0;
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAbout.Location = new Point(714, 3);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(150, 81);
            btnAbout.TabIndex = 2;
            btnAbout.Text = "ABOUT";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // btnFeedback
            // 
            btnFeedback.Dock = DockStyle.Fill;
            btnFeedback.FlatAppearance.BorderSize = 0;
            btnFeedback.FlatStyle = FlatStyle.Flat;
            btnFeedback.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFeedback.Location = new Point(3, 3);
            btnFeedback.Name = "btnFeedback";
            btnFeedback.Size = new Size(147, 81);
            btnFeedback.TabIndex = 4;
            btnFeedback.Text = "FEEDBACK";
            btnFeedback.UseVisualStyleBackColor = true;
            btnFeedback.Click += Btn_Click;
            // 
            // parentPanel
            // 
            parentPanel.AutoScroll = true;
            parentPanel.Controls.Add(uC_home1);
            parentPanel.Dock = DockStyle.Fill;
            parentPanel.Location = new Point(0, 87);
            parentPanel.Name = "parentPanel";
            parentPanel.Size = new Size(1152, 1013);
            parentPanel.TabIndex = 5;
            // 
            // uC_home1
            // 
            uC_home1.BackColor = Color.White;
            uC_home1.Dock = DockStyle.Fill;
            uC_home1.Location = new Point(0, 0);
            uC_home1.Name = "uC_home1";
            uC_home1.Size = new Size(1152, 1013);
            uC_home1.TabIndex = 0;
            // 
            // cmsAbout
            // 
            cmsAbout.BackColor = Color.FromArgb(239, 228, 201);
            cmsAbout.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmsAbout.Items.AddRange(new ToolStripItem[] { ourStoryToolStripMenuItem, termsAndConditionsToolStripMenuItem });
            cmsAbout.Name = "cmsAbout";
            cmsAbout.Size = new Size(247, 56);
            // 
            // ourStoryToolStripMenuItem
            // 
            ourStoryToolStripMenuItem.Name = "ourStoryToolStripMenuItem";
            ourStoryToolStripMenuItem.Size = new Size(246, 26);
            ourStoryToolStripMenuItem.Text = "Our Story";
            ourStoryToolStripMenuItem.Click += MenuItem_Click;
            // 
            // termsAndConditionsToolStripMenuItem
            // 
            termsAndConditionsToolStripMenuItem.Name = "termsAndConditionsToolStripMenuItem";
            termsAndConditionsToolStripMenuItem.Size = new Size(246, 26);
            termsAndConditionsToolStripMenuItem.Text = "Terms and Conditions";
            termsAndConditionsToolStripMenuItem.Click += MenuItem_Click;
            // 
            // cmsAccount
            // 
            cmsAccount.BackColor = Color.FromArgb(239, 228, 201);
            cmsAccount.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmsAccount.Items.AddRange(new ToolStripItem[] { menuLogin, menuManageReserve });
            cmsAccount.Name = "cmsAbout";
            cmsAccount.Size = new Size(232, 78);
            // 
            // menuLogin
            // 
            menuLogin.Name = "menuLogin";
            menuLogin.Size = new Size(231, 26);
            menuLogin.Text = "Login";
            menuLogin.Click += menuLogin_Click;
            // 
            // menuManageReserve
            // 
            menuManageReserve.Name = "menuManageReserve";
            menuManageReserve.Size = new Size(231, 26);
            menuManageReserve.Text = "Manage Reservation";
            menuManageReserve.Click += MenuItem_Click;
            // 
            // MainHomePageFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1152, 1100);
            Controls.Add(parentPanel);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainHomePageFrame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RunForm";
            tableLayoutPanel1.ResumeLayout(false);
            parentPanel.ResumeLayout(false);
            cmsAbout.ResumeLayout(false);
            cmsAccount.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnStiloLogo;
        private Button btnOffers;
        private Button btnRooms;
        private Button btnAccount;
        private Button btnFaq;
        private Button btnAbout;
        private Button btnFeedback;
        private Panel parentPanel;
        private ContextMenuStrip cmsAbout;
        private ToolStripMenuItem ourStoryToolStripMenuItem;
        private ToolStripMenuItem termsAndConditionsToolStripMenuItem;
        private ContextMenuStrip cmsAccount;
        private ToolStripMenuItem menuLogin;
        private ToolStripMenuItem menuManageReserve;
        private UC_HOME uC_home1;
    }
}