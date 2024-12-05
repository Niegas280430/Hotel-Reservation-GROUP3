namespace WindowForms
{
    partial class UC_HOME
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_HOME));
            panelPbox1 = new Panel();
            pbox1 = new PictureBox();
            panelPbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbox1).BeginInit();
            SuspendLayout();
            // 
            // panelPbox1
            // 
            panelPbox1.Controls.Add(pbox1);
            panelPbox1.Dock = DockStyle.Top;
            panelPbox1.Location = new Point(0, 0);
            panelPbox1.Name = "panelPbox1";
            panelPbox1.Size = new Size(1433, 429);
            panelPbox1.TabIndex = 0;
            // 
            // pbox1
            // 
            pbox1.Dock = DockStyle.Fill;
            pbox1.Image = (Image)resources.GetObject("pbox1.Image");
            pbox1.Location = new Point(0, 0);
            pbox1.Name = "pbox1";
            pbox1.Size = new Size(1433, 429);
            pbox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbox1.TabIndex = 0;
            pbox1.TabStop = false;
            // 
            // UC_HOME
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            Controls.Add(panelPbox1);
            Margin = new Padding(0);
            Name = "UC_HOME";
            Size = new Size(1433, 707);
            panelPbox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPbox1;
        private PictureBox pbox1;
    }
}
