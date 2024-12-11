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
            label1 = new Label();
            SuspendLayout();
            // 
            // uC_termS_conditions1
            // 
            uC_termS_conditions1.AutoScroll = true;
            uC_termS_conditions1.BackColor = Color.White;
            uC_termS_conditions1.Location = new Point(-1, 2);
            uC_termS_conditions1.Name = "uC_termS_conditions1";
            uC_termS_conditions1.Size = new Size(1152, 1100);
            uC_termS_conditions1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(1065, 29);
            label1.Name = "label1";
            label1.Size = new Size(45, 42);
            label1.TabIndex = 1;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // Terms_ConditionsFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1152, 1100);
            Controls.Add(label1);
            Controls.Add(uC_termS_conditions1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Terms_ConditionsFrame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Terms_ConditionsFrame";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UC_TERMS_CONDITIONS uC_termS_conditions1;
        private Label label1;
    }
}