namespace WindowForms
{
    partial class RoomsFrame
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
            uC_rooms1 = new UC_ROOMS();
            SuspendLayout();
            // 
            // uC_rooms1
            // 
            uC_rooms1.AutoScroll = true;
            uC_rooms1.BackColor = Color.White;
            uC_rooms1.Location = new Point(0, 0);
            uC_rooms1.Name = "uC_rooms1";
            uC_rooms1.Size = new Size(1152, 1100);
            uC_rooms1.TabIndex = 0;
            // 
            // RoomsFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 1100);
            Controls.Add(uC_rooms1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RoomsFrame";
            Text = "RoomsFrame";
            ResumeLayout(false);
        }

        #endregion

        private UC_ROOMS uC_rooms1;
    }
}