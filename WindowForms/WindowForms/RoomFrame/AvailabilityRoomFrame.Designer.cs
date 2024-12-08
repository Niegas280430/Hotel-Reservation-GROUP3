namespace WindowForms
{
    partial class AvailabilityRoomFrame
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
            uC_rooM_availability1 = new UC_ROOM_AVAILABILITY();
            SuspendLayout();
            // 
            // uC_rooM_availability1
            // 
            uC_rooM_availability1.AutoScroll = true;
            uC_rooM_availability1.BackColor = Color.White;
            uC_rooM_availability1.Location = new Point(0, 0);
            uC_rooM_availability1.Name = "uC_rooM_availability1";
            uC_rooM_availability1.Size = new Size(1152, 1100);
            uC_rooM_availability1.TabIndex = 0;
            // 
            // AvailabilityRoomFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 1100);
            Controls.Add(uC_rooM_availability1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AvailabilityRoomFrame";
            Text = "AvailabilityRoomFrame";
            ResumeLayout(false);
        }

        #endregion

        private UC_ROOM_AVAILABILITY uC_rooM_availability1;
    }
}