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
            label5 = new Label();
            textBox2 = new TextBox();
            pbStar5 = new PictureBox();
            pbStar4 = new PictureBox();
            pbStar3 = new PictureBox();
            pbStar2 = new PictureBox();
            pbStar1 = new PictureBox();
            label10 = new Label();
            label9 = new Label();
            textBox1 = new TextBox();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button6 = new Button();
            btnSearch = new Button();
            panel2 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            pbMainImage = new PictureBox();
            pnlFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbButtomFrame).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbStar5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbStar4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbStar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbStar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbStar1).BeginInit();
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
            pbButtomFrame.Location = new Point(0, 883);
            pbButtomFrame.Name = "pbButtomFrame";
            pbButtomFrame.Size = new Size(1152, 224);
            pbButtomFrame.TabIndex = 45;
            pbButtomFrame.TabStop = false;
            // 
            // panel4
            // 
            panel4.Location = new Point(0, 856);
            panel4.Name = "panel4";
            panel4.Size = new Size(1152, 27);
            panel4.TabIndex = 44;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(pbStar5);
            panel1.Controls.Add(pbStar4);
            panel1.Controls.Add(pbStar3);
            panel1.Controls.Add(pbStar2);
            panel1.Controls.Add(pbStar1);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(288, 15);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(40);
            panel1.Size = new Size(559, 839);
            panel1.TabIndex = 43;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(248, 246, 240);
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonShadow;
            label5.Location = new Point(61, 440);
            label5.Name = "label5";
            label5.Size = new Size(330, 39);
            label5.TabIndex = 8;
            label5.Text = "Add your comments and suggestions here.";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(248, 246, 240);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Times New Roman", 14.25F);
            textBox2.Location = new Point(43, 433);
            textBox2.Margin = new Padding(5);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(473, 115);
            textBox2.TabIndex = 48;
            // 
            // pbStar5
            // 
            pbStar5.ErrorImage = Properties.Resources.fullStar;
            pbStar5.Image = Properties.Resources.fullStar;
            pbStar5.Location = new Point(404, 181);
            pbStar5.Name = "pbStar5";
            pbStar5.Size = new Size(50, 50);
            pbStar5.SizeMode = PictureBoxSizeMode.StretchImage;
            pbStar5.TabIndex = 47;
            pbStar5.TabStop = false;
            pbStar5.Click += Star_Click;
            // 
            // pbStar4
            // 
            pbStar4.ErrorImage = Properties.Resources.fullStar;
            pbStar4.Image = Properties.Resources.fullStar;
            pbStar4.Location = new Point(329, 181);
            pbStar4.Name = "pbStar4";
            pbStar4.Size = new Size(50, 50);
            pbStar4.SizeMode = PictureBoxSizeMode.StretchImage;
            pbStar4.TabIndex = 46;
            pbStar4.TabStop = false;
            pbStar4.Click += Star_Click;
            // 
            // pbStar3
            // 
            pbStar3.ErrorImage = Properties.Resources.fullStar;
            pbStar3.Image = Properties.Resources.fullStar;
            pbStar3.Location = new Point(254, 181);
            pbStar3.Name = "pbStar3";
            pbStar3.Size = new Size(50, 50);
            pbStar3.SizeMode = PictureBoxSizeMode.StretchImage;
            pbStar3.TabIndex = 45;
            pbStar3.TabStop = false;
            pbStar3.Click += Star_Click;
            // 
            // pbStar2
            // 
            pbStar2.ErrorImage = Properties.Resources.fullStar;
            pbStar2.Image = Properties.Resources.fullStar;
            pbStar2.Location = new Point(179, 181);
            pbStar2.Name = "pbStar2";
            pbStar2.Size = new Size(50, 50);
            pbStar2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbStar2.TabIndex = 44;
            pbStar2.TabStop = false;
            pbStar2.Click += Star_Click;
            // 
            // pbStar1
            // 
            pbStar1.ErrorImage = Properties.Resources.fullStar;
            pbStar1.Image = Properties.Resources.fullStar;
            pbStar1.Location = new Point(104, 181);
            pbStar1.Name = "pbStar1";
            pbStar1.Size = new Size(50, 50);
            pbStar1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbStar1.TabIndex = 43;
            pbStar1.TabStop = false;
            pbStar1.Click += Star_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Times New Roman", 9F, FontStyle.Italic);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(175, 676);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 22;
            label10.Text = "Optional*";
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(239, 228, 201);
            label9.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DarkGoldenrod;
            label9.Location = new Point(43, 656);
            label9.Name = "label9";
            label9.Size = new Size(122, 35);
            label9.TabIndex = 21;
            label9.Text = "Input Name";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(248, 246, 240);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(43, 703);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(473, 27);
            textBox1.TabIndex = 20;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(43, 613);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(473, 26);
            dateTimePicker1.TabIndex = 19;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(0, 123, 167);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Transparent;
            button6.Location = new Point(43, 773);
            button6.Name = "button6";
            button6.Size = new Size(108, 29);
            button6.TabIndex = 17;
            button6.Text = "Cancel";
            button6.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkGoldenrod;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.Transparent;
            btnSearch.Location = new Point(408, 773);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(108, 29);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Submit";
            btnSearch.UseVisualStyleBackColor = false;
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
            ((System.ComponentModel.ISupportInitialize)pbStar5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbStar4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbStar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbStar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbStar1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbMainImage).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlFill;
        private PictureBox pbMainImage;
        private Panel panel4;
        private Panel panel1;
        private PictureBox pbStar5;
        private PictureBox pbStar4;
        private PictureBox pbStar3;
        private PictureBox pbStar2;
        private PictureBox pbStar1;
        private Label label10;
        private Label label9;
        private TextBox textBox1;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private Button button6;
        private Button btnSearch;
        private Label label5;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private PictureBox pbButtomFrame;
        private TextBox textBox2;
    }
}
