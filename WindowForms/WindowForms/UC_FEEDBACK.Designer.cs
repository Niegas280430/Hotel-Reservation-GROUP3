namespace WindowForms
{
    partial class UC_FEEDBACK
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlFill = new Panel();
            pbButtomFrame = new PictureBox();
            panel4 = new Panel();
            panel1 = new Panel();
            label10 = new Label();
            cbAnonymousUsername = new CheckBox();
            txtComment = new TextBox();
            picStar5 = new PictureBox();
            picStar4 = new PictureBox();
            picStar3 = new PictureBox();
            picStar2 = new PictureBox();
            picStar1 = new PictureBox();
            label7 = new Label();
            selectDataPicker = new DateTimePicker();
            btnCancel = new Button();
            btnSubmit = new Button();
            panel2 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            pbMainImage = new PictureBox();
            pnlFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbButtomFrame).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStar5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStar4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStar1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMainImage).BeginInit();
            SuspendLayout();
            // 
            // pnlFill
            // 
            pnlFill.AutoScroll = true;
            pnlFill.Controls.Add(pbButtomFrame);
            pnlFill.Controls.Add(panel4);
            pnlFill.Controls.Add(panel1);
            pnlFill.Controls.Add(pbMainImage);
            pnlFill.Dock = DockStyle.Fill;
            pnlFill.Location = new Point(0, 0);
            pnlFill.Name = "pnlFill";
            pnlFill.Size = new Size(1152, 1100);
            pnlFill.TabIndex = 9;
            // 
            // pbButtomFrame
            // 
            pbButtomFrame.Dock = DockStyle.Bottom;
            pbButtomFrame.Image = Properties.Resources.For_UI_Buttom_Frame;
            pbButtomFrame.Location = new Point(0, 922);
            pbButtomFrame.Name = "pbButtomFrame";
            pbButtomFrame.Size = new Size(1152, 224);
            pbButtomFrame.TabIndex = 45;
            pbButtomFrame.TabStop = false;
            // 
            // panel4
            // 
            panel4.Location = new Point(0, 895);
            panel4.Name = "panel4";
            panel4.Size = new Size(1152, 27);
            panel4.TabIndex = 44;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(cbAnonymousUsername);
            panel1.Controls.Add(txtComment);
            panel1.Controls.Add(picStar5);
            panel1.Controls.Add(picStar4);
            panel1.Controls.Add(picStar3);
            panel1.Controls.Add(picStar2);
            panel1.Controls.Add(picStar1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(selectDataPicker);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnSubmit);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(288, 68);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(40);
            panel1.Size = new Size(559, 812);
            panel1.TabIndex = 43;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(86, 663);
            label10.Name = "label10";
            label10.Size = new Size(243, 19);
            label10.TabIndex = 58;
            label10.Text = "Leave your feedback anonymously";
            // 
            // cbAnonymousUsername
            // 
            cbAnonymousUsername.AutoSize = true;
            cbAnonymousUsername.BackColor = Color.FromArgb(239, 228, 201);
            cbAnonymousUsername.Location = new Point(43, 665);
            cbAnonymousUsername.Name = "cbAnonymousUsername";
            cbAnonymousUsername.Size = new Size(15, 14);
            cbAnonymousUsername.TabIndex = 56;
            cbAnonymousUsername.UseVisualStyleBackColor = false;
            // 
            // txtComment
            // 
            txtComment.BackColor = Color.FromArgb(248, 246, 240);
            txtComment.BorderStyle = BorderStyle.FixedSingle;
            txtComment.Font = new Font("Times New Roman", 14.25F);
            txtComment.Location = new Point(43, 433);
            txtComment.Margin = new Padding(5);
            txtComment.Multiline = true;
            txtComment.Name = "txtComment";
            txtComment.PlaceholderText = "Add your comments and suggestions here.";
            txtComment.Size = new Size(473, 115);
            txtComment.TabIndex = 48;
            // 
            // picStar5
            // 
            picStar5.ErrorImage = Properties.Resources.fullStar;
            picStar5.Image = Properties.Resources.fullStar;
            picStar5.Location = new Point(404, 181);
            picStar5.Name = "picStar5";
            picStar5.Size = new Size(50, 50);
            picStar5.SizeMode = PictureBoxSizeMode.StretchImage;
            picStar5.TabIndex = 47;
            picStar5.TabStop = false;
            picStar5.Click += Star_Click;
            // 
            // picStar4
            // 
            picStar4.ErrorImage = Properties.Resources.fullStar;
            picStar4.Image = Properties.Resources.fullStar;
            picStar4.Location = new Point(329, 181);
            picStar4.Name = "picStar4";
            picStar4.Size = new Size(50, 50);
            picStar4.SizeMode = PictureBoxSizeMode.StretchImage;
            picStar4.TabIndex = 46;
            picStar4.TabStop = false;
            picStar4.Click += Star_Click;
            // 
            // picStar3
            // 
            picStar3.ErrorImage = Properties.Resources.fullStar;
            picStar3.Image = Properties.Resources.fullStar;
            picStar3.Location = new Point(254, 181);
            picStar3.Name = "picStar3";
            picStar3.Size = new Size(50, 50);
            picStar3.SizeMode = PictureBoxSizeMode.StretchImage;
            picStar3.TabIndex = 45;
            picStar3.TabStop = false;
            picStar3.Click += Star_Click;
            // 
            // picStar2
            // 
            picStar2.ErrorImage = Properties.Resources.fullStar;
            picStar2.Image = Properties.Resources.fullStar;
            picStar2.Location = new Point(179, 181);
            picStar2.Name = "picStar2";
            picStar2.Size = new Size(50, 50);
            picStar2.SizeMode = PictureBoxSizeMode.StretchImage;
            picStar2.TabIndex = 44;
            picStar2.TabStop = false;
            picStar2.Click += Star_Click;
            // 
            // picStar1
            // 
            picStar1.ErrorImage = Properties.Resources.fullStar;
            picStar1.Image = Properties.Resources.fullStar;
            picStar1.Location = new Point(104, 181);
            picStar1.Name = "picStar1";
            picStar1.Size = new Size(50, 50);
            picStar1.SizeMode = PictureBoxSizeMode.StretchImage;
            picStar1.TabIndex = 43;
            picStar1.TabStop = false;
            picStar1.Click += Star_Click;
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(239, 228, 201);
            label7.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkGoldenrod;
            label7.Location = new Point(43, 567);
            label7.Name = "label7";
            label7.Size = new Size(122, 35);
            label7.TabIndex = 18;
            label7.Text = "Select Date";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // selectDataPicker
            // 
            selectDataPicker.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selectDataPicker.Format = DateTimePickerFormat.Short;
            selectDataPicker.Location = new Point(43, 613);
            selectDataPicker.Name = "selectDataPicker";
            selectDataPicker.Size = new Size(473, 26);
            selectDataPicker.TabIndex = 19;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(0, 123, 167);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Transparent;
            btnCancel.Location = new Point(43, 733);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(108, 29);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.DarkGoldenrod;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.Transparent;
            btnSubmit.Location = new Point(408, 733);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(108, 29);
            btnSubmit.TabIndex = 16;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(248, 246, 240);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.Location = new Point(43, 305);
            panel2.Name = "panel2";
            panel2.Size = new Size(473, 115);
            panel2.TabIndex = 9;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(248, 246, 240);
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(71, 14);
            label3.Name = "label3";
            label3.Size = new Size(331, 88);
            label3.TabIndex = 8;
            label3.Text = "We welcome any suggestions or specific \nfeedback you may have to help us improve\nour services. Thank you for choosing\nStilo Hotel!";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(239, 228, 201);
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGoldenrod;
            label4.Location = new Point(43, 258);
            label4.Name = "label4";
            label4.Size = new Size(122, 35);
            label4.TabIndex = 7;
            label4.Text = "Feedback";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(248, 246, 240);
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 88);
            label2.Name = "label2";
            label2.Size = new Size(473, 81);
            label2.TabIndex = 1;
            label2.Text = "How was your experience at Stilo Hotel?";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(239, 228, 201);
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGoldenrod;
            label1.Location = new Point(43, 41);
            label1.Name = "label1";
            label1.Size = new Size(122, 35);
            label1.TabIndex = 0;
            label1.Text = "Rate";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbMainImage
            // 
            pbMainImage.Image = Properties.Resources.Get_the_rest_you_deserve_Pic;
            pbMainImage.Location = new Point(0, 0);
            pbMainImage.Name = "pbMainImage";
            pbMainImage.Size = new Size(1152, 462);
            pbMainImage.TabIndex = 40;
            pbMainImage.TabStop = false;
            // 
            // UC_FEEDBACK
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            Controls.Add(pnlFill);
            Name = "UC_FEEDBACK";
            Size = new Size(1152, 1100);
            pnlFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbButtomFrame).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStar5).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStar4).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStar1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbMainImage).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlFill;
        private PictureBox pbMainImage;
        private Panel panel4;
        private Panel panel1;
        private PictureBox picStar5;
        private PictureBox picStar4;
        private PictureBox picStar3;
        private PictureBox picStar2;
        private PictureBox picStar1;
        private Label label7;
        private DateTimePicker selectDataPicker;
        private Button btnCancel;
        private Button btnSubmit;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private PictureBox pbButtomFrame;
        private TextBox txtComment;
        private CheckBox cbAnonymousUserName;
        private CheckBox cbVisibleUserName;
        private Label label6;
        private Label label9;
        private Label label10;
        private CheckBox cbAnonymousUsername;
        private Label label8;
    }
}
