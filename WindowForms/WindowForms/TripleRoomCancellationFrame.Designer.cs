namespace WindowForms
{
    partial class TripleRoomCancellationFrame
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
            uC_triplerooM_cancellation1 = new UC_TRIPLEROOM_CANCELLATION();
            SuspendLayout();
            // 
            // uC_triplerooM_cancellation1
            // 
            uC_triplerooM_cancellation1.AutoScroll = true;
            uC_triplerooM_cancellation1.BackColor = Color.White;
            uC_triplerooM_cancellation1.Location = new Point(0, 0);
            uC_triplerooM_cancellation1.Name = "uC_triplerooM_cancellation1";
            uC_triplerooM_cancellation1.Size = new Size(1152, 1100);
            uC_triplerooM_cancellation1.TabIndex = 0;
            // 
            // TripleRoomCancellationFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1152, 1100);
            Controls.Add(uC_triplerooM_cancellation1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TripleRoomCancellationFrame";
            Text = "TripleRoomCancellationFrame";
            ResumeLayout(false);
        }

        #endregion

        private UC_TRIPLEROOM_CANCELLATION uC_triplerooM_cancellation1;
    }
}