namespace TestDatabase
{
    partial class RegisterForm
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
            this.registerBtn = new System.Windows.Forms.Button();
            this.registerpassLbl = new System.Windows.Forms.Label();
            this.registeremailLbl = new System.Windows.Forms.Label();
            this.registerpassTxtBox = new System.Windows.Forms.TextBox();
            this.registeremailTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // registerBtn
            // 
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.Location = new System.Drawing.Point(246, 242);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(127, 35);
            this.registerBtn.TabIndex = 0;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // registerpassLbl
            // 
            this.registerpassLbl.AutoSize = true;
            this.registerpassLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerpassLbl.Location = new System.Drawing.Point(115, 170);
            this.registerpassLbl.Name = "registerpassLbl";
            this.registerpassLbl.Size = new System.Drawing.Size(106, 25);
            this.registerpassLbl.TabIndex = 4;
            this.registerpassLbl.Text = "Password";
            // 
            // registeremailLbl
            // 
            this.registeremailLbl.AutoSize = true;
            this.registeremailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registeremailLbl.Location = new System.Drawing.Point(136, 115);
            this.registeremailLbl.Name = "registeremailLbl";
            this.registeremailLbl.Size = new System.Drawing.Size(65, 25);
            this.registeremailLbl.TabIndex = 3;
            this.registeremailLbl.Text = "Email";
            // 
            // registerpassTxtBox
            // 
            this.registerpassTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerpassTxtBox.Location = new System.Drawing.Point(231, 170);
            this.registerpassTxtBox.Name = "registerpassTxtBox";
            this.registerpassTxtBox.PasswordChar = '*';
            this.registerpassTxtBox.Size = new System.Drawing.Size(288, 31);
            this.registerpassTxtBox.TabIndex = 2;
            // 
            // registeremailTxtBox
            // 
            this.registeremailTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registeremailTxtBox.Location = new System.Drawing.Point(231, 112);
            this.registeremailTxtBox.Name = "registeremailTxtBox";
            this.registeremailTxtBox.Size = new System.Drawing.Size(288, 31);
            this.registeremailTxtBox.TabIndex = 1;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(665, 364);
            this.Controls.Add(this.registerpassLbl);
            this.Controls.Add(this.registeremailLbl);
            this.Controls.Add(this.registerpassTxtBox);
            this.Controls.Add(this.registeremailTxtBox);
            this.Controls.Add(this.registerBtn);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Label registerpassLbl;
        private System.Windows.Forms.Label registeremailLbl;
        private System.Windows.Forms.TextBox registerpassTxtBox;
        private System.Windows.Forms.TextBox registeremailTxtBox;
    }
}