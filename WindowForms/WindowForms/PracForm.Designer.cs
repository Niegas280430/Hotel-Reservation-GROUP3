namespace WindowForms
{
    partial class PracForm
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
            btn = new Button();
            lbl = new Label();
            SuspendLayout();
            // 
            // btn
            // 
            btn.Location = new Point(120, 204);
            btn.Name = "btn";
            btn.Size = new Size(172, 90);
            btn.TabIndex = 0;
            btn.Text = "button1";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl.Location = new Point(166, 78);
            lbl.Name = "lbl";
            lbl.Size = new Size(78, 32);
            lbl.TabIndex = 1;
            lbl.Text = "label1";
            // 
            // PracForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 322);
            Controls.Add(lbl);
            Controls.Add(btn);
            Name = "PracForm";
            Text = "PracForm";
            Load += PracForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn;
        private Label lbl;
    }
}