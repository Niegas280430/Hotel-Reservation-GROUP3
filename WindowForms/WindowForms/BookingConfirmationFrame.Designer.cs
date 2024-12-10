namespace WindowForms
{
    partial class BookingConfirmationFrame
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
            uC_bookinG_confirmation1 = new UC_BOOKING_CONFIRMATION();
            SuspendLayout();
            // 
            // uC_bookinG_confirmation1
            // 
            uC_bookinG_confirmation1.AutoScroll = true;
            uC_bookinG_confirmation1.BackColor = Color.White;
            uC_bookinG_confirmation1.Location = new Point(0, 0);
            uC_bookinG_confirmation1.Name = "uC_bookinG_confirmation1";
            uC_bookinG_confirmation1.Size = new Size(1152, 1100);
            uC_bookinG_confirmation1.TabIndex = 0;
            uC_bookinG_confirmation1.Load += uC_bookinG_confirmation1_Load;
            // 
            // BookingConfirmationFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 1100);
            Controls.Add(uC_bookinG_confirmation1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BookingConfirmationFrame";
            Text = "BookingConfirmationFrame";
            ResumeLayout(false);
        }

        #endregion

        private UC_BOOKING_CONFIRMATION uC_bookinG_confirmation1;
    }
}