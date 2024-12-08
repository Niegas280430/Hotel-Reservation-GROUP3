namespace WindowForms
{
    partial class NoReserveRoomFrame
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
            uC_nO_reservations1 = new UC_NO_RESERVATIONS();
            SuspendLayout();
            // 
            // uC_nO_reservations1
            // 
            uC_nO_reservations1.AutoScroll = true;
            uC_nO_reservations1.BackColor = Color.White;
            uC_nO_reservations1.Location = new Point(0, 0);
            uC_nO_reservations1.Name = "uC_nO_reservations1";
            uC_nO_reservations1.Size = new Size(1152, 1100);
            uC_nO_reservations1.TabIndex = 0;
            // 
            // NoReserveRoomFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1152, 1100);
            Controls.Add(uC_nO_reservations1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NoReserveRoomFrame";
            Text = "NoReserveRoomFrae";
            ResumeLayout(false);
        }

        #endregion

        private UC_NO_RESERVATIONS uC_nO_reservations1;
    }
}