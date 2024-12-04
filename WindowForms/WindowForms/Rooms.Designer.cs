namespace WindowForms
{
    partial class Rooms
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btnStiloLogo = new Button();
            btnOffers = new Button();
            btnRooms = new Button();
            btnManageReservations = new Button();
            btnFaq = new Button();
            btnAbout = new Button();
            btnFeedback = new Button();
            tableLayoutPanel1.SuspendLayout();
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
            tableLayoutPanel1.Controls.Add(btnManageReservations, 6, 0);
            tableLayoutPanel1.Controls.Add(btnFaq, 5, 0);
            tableLayoutPanel1.Controls.Add(btnAbout, 4, 0);
            tableLayoutPanel1.Controls.Add(btnFeedback, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1152, 87);
            tableLayoutPanel1.TabIndex = 1;
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
            // 
            // btnManageReservations
            // 
            btnManageReservations.FlatAppearance.BorderSize = 0;
            btnManageReservations.FlatStyle = FlatStyle.Flat;
            btnManageReservations.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnManageReservations.Location = new Point(979, 3);
            btnManageReservations.Name = "btnManageReservations";
            btnManageReservations.Size = new Size(158, 81);
            btnManageReservations.TabIndex = 1;
            btnManageReservations.Text = "MANAGE RESERVATIONS";
            btnManageReservations.UseVisualStyleBackColor = true;
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
            // 
            // btnFeedback
            // 
            btnFeedback.FlatAppearance.BorderSize = 0;
            btnFeedback.FlatStyle = FlatStyle.Flat;
            btnFeedback.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFeedback.Location = new Point(3, 3);
            btnFeedback.Name = "btnFeedback";
            btnFeedback.Size = new Size(138, 81);
            btnFeedback.TabIndex = 4;
            btnFeedback.Text = "FEEDBACK";
            btnFeedback.UseVisualStyleBackColor = true;
            // 
            // Rooms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 1100);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Rooms";
            Text = "Rooms";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnStiloLogo;
        private Button btnOffers;
        private Button btnRooms;
        private Button btnManageReservations;
        private Button btnFaq;
        private Button btnAbout;
        private Button btnFeedback;
    }
}