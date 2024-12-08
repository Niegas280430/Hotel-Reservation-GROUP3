namespace WindowForms
{
    partial class Terms_ConditionsFrame
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
            uC_termS_conditions1 = new UC_TERMS_CONDITIONS();
            SuspendLayout();
            // 
            // uC_termS_conditions1
            // 
            uC_termS_conditions1.AutoScroll = true;
            uC_termS_conditions1.BackColor = Color.White;
            uC_termS_conditions1.Location = new Point(0, 0);
            uC_termS_conditions1.Name = "uC_termS_conditions1";
            uC_termS_conditions1.Size = new Size(1152, 1100);
            uC_termS_conditions1.TabIndex = 0;
            // 
            // Terms_ConditionsFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1152, 1100);
            Controls.Add(uC_termS_conditions1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Terms_ConditionsFrame";
            Text = "Terms_ConditionsFrame";
            ResumeLayout(false);
        }

        #endregion

        private UC_TERMS_CONDITIONS uC_termS_conditions1;
    }
}