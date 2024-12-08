namespace WindowForms
{
    partial class StandardRoomFrame
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
            uC_standarD_room1 = new UC_STANDARD_ROOM();
            SuspendLayout();
            // 
            // uC_standarD_room1
            // 
            uC_standarD_room1.AutoScroll = true;
            uC_standarD_room1.BackColor = Color.White;
            uC_standarD_room1.Location = new Point(0, 0);
            uC_standarD_room1.Name = "uC_standarD_room1";
            uC_standarD_room1.Size = new Size(1152, 1100);
            uC_standarD_room1.TabIndex = 0;
            // 
            // StandardRoomFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1152, 1100);
            Controls.Add(uC_standarD_room1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StandardRoomFrame";
            Text = "StandardRoomFrame";
            ResumeLayout(false);
        }

        #endregion

        private UC_STANDARD_ROOM uC_standarD_room1;
    }
}