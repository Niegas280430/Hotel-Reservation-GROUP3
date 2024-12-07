namespace WindowForms
{
    partial class MainHomePageFrame
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
            uC_home1 = new UC_HOME();
            SuspendLayout();
            // 
            // uC_home1
            // 
            uC_home1.BackColor = Color.White;
            uC_home1.Location = new Point(0, 0);
            uC_home1.Name = "uC_home1";
            uC_home1.Size = new Size(1152, 1100);
            uC_home1.TabIndex = 0;
            // 
            // RunForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 1100);
            Controls.Add(uC_home1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RunForm";
            Text = "RunForm";
            ResumeLayout(false);
        }

        #endregion

        private UC_HOME uC_home1;
    }
}