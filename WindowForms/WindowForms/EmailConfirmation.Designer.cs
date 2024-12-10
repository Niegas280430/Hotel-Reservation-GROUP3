namespace WindowForms
{
    partial class EmailConfirmation
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
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            ExitButton = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            lblCheckIn = new Label();
            lblCheckOut = new Label();
            lblRoom = new Label();
            label16 = new Label();
            lblNumGuest = new Label();
            lblNameBooker = new Label();
            lblTotalCost = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label17 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(lblTotalCost);
            panel1.Controls.Add(lblNameBooker);
            panel1.Controls.Add(lblNumGuest);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(lblRoom);
            panel1.Controls.Add(lblCheckOut);
            panel1.Controls.Add(lblCheckIn);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(752, 668);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(239, 228, 201);
            panel2.Controls.Add(ExitButton);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(752, 63);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(172, 22);
            label1.TabIndex = 1;
            label1.Text = "Email Confirmation";
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Transparent;
            ExitButton.BackgroundImageLayout = ImageLayout.None;
            ExitButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            ExitButton.Location = new Point(698, 11);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(42, 39);
            ExitButton.TabIndex = 1;
            ExitButton.Text = "X";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 2;
            label2.Text = "Dear Customer,";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 114);
            label3.Name = "label3";
            label3.Size = new Size(740, 20);
            label3.TabIndex = 3;
            label3.Text = "Thank you for your booking your stay with Stilo Hotel. For reference, Your booking id is (1256306). ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 144);
            label4.Name = "label4";
            label4.Size = new Size(310, 20);
            label4.TabIndex = 4;
            label4.Text = "We are looking forward to your next visit.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 206);
            label5.Name = "label5";
            label5.Size = new Size(264, 20);
            label5.TabIndex = 5;
            label5.Text = "Your booking details are as follows:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 240);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 6;
            label6.Text = "Check In:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 275);
            label7.Name = "label7";
            label7.Size = new Size(91, 20);
            label7.TabIndex = 7;
            label7.Text = "Check Out:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 310);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 8;
            label8.Text = "Room:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 345);
            label9.Name = "label9";
            label9.Size = new Size(82, 20);
            label9.TabIndex = 9;
            label9.Text = "Breakfast:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(12, 450);
            label10.Name = "label10";
            label10.Size = new Size(50, 20);
            label10.TabIndex = 10;
            label10.Text = "Total:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(12, 415);
            label11.Name = "label11";
            label11.Size = new Size(95, 20);
            label11.TabIndex = 11;
            label11.Text = "Booked By:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(12, 380);
            label12.Name = "label12";
            label12.Size = new Size(143, 20);
            label12.TabIndex = 12;
            label12.Text = "Number Of Guest:";
            // 
            // lblCheckIn
            // 
            lblCheckIn.AutoSize = true;
            lblCheckIn.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCheckIn.Location = new Point(281, 240);
            lblCheckIn.Name = "lblCheckIn";
            lblCheckIn.Size = new Size(324, 20);
            lblCheckIn.TabIndex = 13;
            lblCheckIn.Text = "<Day of check in><Exact date of check in>";
            // 
            // lblCheckOut
            // 
            lblCheckOut.AutoSize = true;
            lblCheckOut.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCheckOut.Location = new Point(281, 275);
            lblCheckOut.Name = "lblCheckOut";
            lblCheckOut.Size = new Size(334, 20);
            lblCheckOut.TabIndex = 14;
            lblCheckOut.Text = "<Day of check out><Exact date of check in>";
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoom.Location = new Point(281, 310);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(182, 20);
            lblRoom.TabIndex = 15;
            lblRoom.Text = "<Name/ Type of room>";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(281, 345);
            label16.Name = "label16";
            label16.Size = new Size(91, 20);
            label16.TabIndex = 16;
            label16.Text = "<Included>";
            // 
            // lblNumGuest
            // 
            lblNumGuest.AutoSize = true;
            lblNumGuest.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumGuest.Location = new Point(281, 380);
            lblNumGuest.Name = "lblNumGuest";
            lblNumGuest.Size = new Size(155, 20);
            lblNumGuest.TabIndex = 17;
            lblNumGuest.Text = "<Number of Guest>";
            // 
            // lblNameBooker
            // 
            lblNameBooker.AutoSize = true;
            lblNameBooker.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNameBooker.Location = new Point(281, 415);
            lblNameBooker.Name = "lblNameBooker";
            lblNameBooker.Size = new Size(220, 20);
            lblNameBooker.TabIndex = 18;
            lblNameBooker.Text = "<Name of booked the room>";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalCost.Location = new Point(281, 450);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(141, 20);
            lblTotalCost.TabIndex = 19;
            lblTotalCost.Text = "<Total cost of all>";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(15, 502);
            label13.Name = "label13";
            label13.Size = new Size(448, 20);
            label13.TabIndex = 20;
            label13.Text = "If you have any questions please don’t hesitate to contact us ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(15, 532);
            label14.Name = "label14";
            label14.Size = new Size(279, 20);
            label14.TabIndex = 21;
            label14.Text = "We hope you enjoy your stay with us";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(15, 605);
            label15.Name = "label15";
            label15.Size = new Size(109, 20);
            label15.TabIndex = 22;
            label15.Text = "Best Regards,";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(15, 635);
            label17.Name = "label17";
            label17.Size = new Size(105, 20);
            label17.TabIndex = 23;
            label17.Text = "STILO Hotel";
            // 
            // EmailConfirmation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 668);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmailConfirmation";
            Text = "EmailConfirmation";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button ExitButton;
        private Label label2;
        private Label label3;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label lblTotalCost;
        private Label lblNameBooker;
        private Label lblNumGuest;
        private Label label16;
        private Label lblRoom;
        private Label lblCheckOut;
        private Label lblCheckIn;
        private Label label17;
        private Label label15;
        private Label label14;
        private Label label13;
    }
}