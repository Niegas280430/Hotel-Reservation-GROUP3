namespace WindowForms
{
    partial class UC_OFFERS
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(289, 169);
            label1.Name = "label1";
            label1.Size = new Size(251, 86);
            label1.TabIndex = 0;
            label1.Text = "OFFERS";
            // 
            // UC_OFFERS
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(label1);
            Margin = new Padding(0);
            Name = "UC_OFFERS";
            Size = new Size(900, 500);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}
