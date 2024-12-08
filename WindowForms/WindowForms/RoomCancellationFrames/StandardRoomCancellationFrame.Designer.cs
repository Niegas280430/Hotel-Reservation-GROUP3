namespace WindowForms
{
    partial class StandardRoomCancellationFrame
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
            uC_standardrooM_cancellation1 = new UC_STANDARDROOM_CANCELLATION();
            SuspendLayout();
            // 
            // uC_standardrooM_cancellation1
            // 
            uC_standardrooM_cancellation1.BackColor = Color.White;
            uC_standardrooM_cancellation1.Location = new Point(0, 0);
            uC_standardrooM_cancellation1.Name = "uC_standardrooM_cancellation1";
            uC_standardrooM_cancellation1.Size = new Size(1152, 1100);
            uC_standardrooM_cancellation1.TabIndex = 0;
            // 
            // StandardRoomCancellation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1152, 1100);
            Controls.Add(uC_standardrooM_cancellation1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StandardRoomCancellation";
            Text = "StandardRoomCancellation";
            ResumeLayout(false);
        }

        #endregion

        private UC_STANDARDROOM_CANCELLATION uC_standardrooM_cancellation1;
    }
}