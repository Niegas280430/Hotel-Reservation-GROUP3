namespace WindowForms
{
    partial class Cancel_Reservation_PopUp
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
            label1 = new Label();
            label2 = new Label();
            btnOkay = new Button();
            btnSubmit = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(239, 228, 201);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(392, 70);
            panel2.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 22);
            label1.Name = "label1";
            label1.Size = new Size(184, 24);
            label1.TabIndex = 0;
            label1.Text = "Cancel Reservation";
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 14.25F);
            label2.Location = new Point(21, 91);
            label2.Name = "label2";
            label2.Size = new Size(350, 102);
            label2.TabIndex = 15;
            label2.Text = "Thank you for booking at STILO Hotel! An email verification will be shortly delivered which includes all of your booking details.";
            // 
            // btnOkay
            // 
            btnOkay.BackColor = Color.FromArgb(0, 123, 167);
            btnOkay.BackgroundImageLayout = ImageLayout.None;
            btnOkay.FlatAppearance.BorderSize = 0;
            btnOkay.FlatStyle = FlatStyle.Flat;
            btnOkay.Font = new Font("Times New Roman", 11.25F);
            btnOkay.ForeColor = Color.White;
            btnOkay.Location = new Point(151, 215);
            btnOkay.Name = "btnOkay";
            btnOkay.Size = new Size(93, 31);
            btnOkay.TabIndex = 16;
            btnOkay.Text = "Cancel";
            btnOkay.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.DarkGoldenrod;
            btnSubmit.BackgroundImageLayout = ImageLayout.None;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Times New Roman", 11.25F);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(278, 215);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(93, 31);
            btnSubmit.TabIndex = 17;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // Cancel_Reservation_PopUp
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 246, 240);
            ClientSize = new Size(392, 267);
            Controls.Add(btnSubmit);
            Controls.Add(btnOkay);
            Controls.Add(label2);
            Controls.Add(panel2);
            Font = new Font("Times New Roman", 11.25F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Cancel_Reservation_PopUp";
            Text = "Cancel_Reservation_PopUp";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Label label2;
        private Button btnOkay;
        private Button btnSubmit;
    }
}