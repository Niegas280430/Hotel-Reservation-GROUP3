namespace WindowForms
{
    partial class DiscountCodePopUp
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
            parentDiscountPanel = new Panel();
            btnOkay = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            parentDiscountPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // parentDiscountPanel
            // 
            parentDiscountPanel.BackColor = Color.FromArgb(248, 246, 240);
            parentDiscountPanel.Controls.Add(btnOkay);
            parentDiscountPanel.Controls.Add(textBox3);
            parentDiscountPanel.Controls.Add(textBox2);
            parentDiscountPanel.Controls.Add(textBox1);
            parentDiscountPanel.Controls.Add(panel1);
            parentDiscountPanel.Dock = DockStyle.Fill;
            parentDiscountPanel.Location = new Point(0, 0);
            parentDiscountPanel.Name = "parentDiscountPanel";
            parentDiscountPanel.Size = new Size(343, 301);
            parentDiscountPanel.TabIndex = 0;
            // 
            // btnOkay
            // 
            btnOkay.BackColor = Color.DarkGoldenrod;
            btnOkay.BackgroundImageLayout = ImageLayout.None;
            btnOkay.FlatAppearance.BorderSize = 0;
            btnOkay.FlatStyle = FlatStyle.Flat;
            btnOkay.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOkay.ForeColor = Color.White;
            btnOkay.Location = new Point(239, 252);
            btnOkay.Name = "btnOkay";
            btnOkay.Size = new Size(81, 27);
            btnOkay.TabIndex = 4;
            btnOkay.Text = "Okay";
            btnOkay.UseVisualStyleBackColor = false;
            btnOkay.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(248, 246, 240);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(25, 169);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(306, 68);
            textBox3.TabIndex = 3;
            textBox3.Text = "Copy & Paste the code in the Booking Confirmations when you book 2 weeks in advance of your check-in date.";
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(248, 246, 240);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Times New Roman", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.DarkGoldenrod;
            textBox2.Location = new Point(25, 128);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(306, 22);
            textBox2.TabIndex = 2;
            textBox2.Text = "“10%STILOHotel”";
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(248, 246, 240);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(25, 81);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(306, 45);
            textBox1.TabIndex = 1;
            textBox1.Text = "Enjoy your stay at our Deluxe Room with a discount code of ";
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(239, 228, 201);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(343, 62);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 19);
            label1.Name = "label1";
            label1.Size = new Size(206, 24);
            label1.TabIndex = 0;
            label1.Text = "Deluxe Discount Code";
            // 
            // DiscountCodePopUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 301);
            Controls.Add(parentDiscountPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DiscountCodePopUp";
            Text = "DiscountCodePopUp";
            parentDiscountPanel.ResumeLayout(false);
            parentDiscountPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel parentDiscountPanel;
        private Panel panel1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btnOkay;
        private TextBox textBox3;
        private Label label1;
    }
}