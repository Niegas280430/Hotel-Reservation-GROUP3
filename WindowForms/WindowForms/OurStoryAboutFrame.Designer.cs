namespace WindowForms
{
    partial class OurStoryAboutFrame
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
            uC_about1 = new UC_ABOUT();
            SuspendLayout();
            // 
            // uC_about1
            // 
            uC_about1.AutoScroll = true;
            uC_about1.BackColor = Color.White;
            uC_about1.Location = new Point(0, 0);
            uC_about1.Name = "uC_about1";
            uC_about1.Size = new Size(1152, 1100);
            uC_about1.TabIndex = 0;
            // 
            // OurStoryAboutFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1152, 1061);
            Controls.Add(uC_about1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OurStoryAboutFrame";
            Text = "OurStoryAboutFrame";
            ResumeLayout(false);
        }

        #endregion

        private UC_ABOUT uC_about1;
    }
}