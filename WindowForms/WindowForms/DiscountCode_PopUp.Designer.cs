namespace WindowForms
{
    partial class DiscountCode_PopUp
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
            panel2 = new Panel();
            closeCode = new Label();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnOkay = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(239, 228, 201);
            panel2.Controls.Add(closeCode);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(392, 70);
            panel2.TabIndex = 6;
            // 
            // closeCode
            // 
            closeCode.AutoSize = true;
            closeCode.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeCode.Location = new Point(347, 14);
            closeCode.Name = "closeCode";
            closeCode.Size = new Size(24, 30);
            closeCode.TabIndex = 1;
            closeCode.Text = "x";
            closeCode.Click += closeCode_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 19);
            label1.Name = "label1";
            label1.Size = new Size(206, 24);
            label1.TabIndex = 0;
            label1.Text = "Deluxe Discount Code";
            // 
            // label4
            // 
            label4.Font = new Font("Times New Roman", 14.25F);
            label4.Location = new Point(21, 170);
            label4.Name = "label4";
            label4.Size = new Size(350, 69);
            label4.TabIndex = 15;
            label4.Text = "Copy and Paste the code in the Booking Confirmations when you book 2 weeks in advance of your check-in date.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Underline);
            label3.ForeColor = Color.DarkGoldenrod;
            label3.Location = new Point(21, 136);
            label3.Name = "label3";
            label3.Size = new Size(155, 21);
            label3.TabIndex = 14;
            label3.Text = "“10%STILOHotel”";
            label3.Click += label3_Click_1;
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 14.25F);
            label2.Location = new Point(21, 91);
            label2.Name = "label2";
            label2.Size = new Size(350, 45);
            label2.TabIndex = 13;
            label2.Text = "Enjoy your stay at our Deluxe Room with a discount code of ";
            // 
            // btnOkay
            // 
            btnOkay.BackColor = Color.DarkGoldenrod;
            btnOkay.BackgroundImageLayout = ImageLayout.None;
            btnOkay.FlatAppearance.BorderSize = 0;
            btnOkay.FlatStyle = FlatStyle.Flat;
            btnOkay.Font = new Font("Times New Roman", 11.25F);
            btnOkay.ForeColor = Color.White;
            btnOkay.Location = new Point(278, 245);
            btnOkay.Name = "btnOkay";
            btnOkay.Size = new Size(93, 31);
            btnOkay.TabIndex = 16;
            btnOkay.Text = "Okay";
            btnOkay.UseVisualStyleBackColor = false;
            btnOkay.Click += btnOkay_Click;
            // 
            // DiscountCode_PopUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 246, 240);
            ClientSize = new Size(392, 294);
            Controls.Add(btnOkay);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DiscountCode_PopUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DiscountCodePopUp";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnOkay;
        private Label closeCode;
    }
}