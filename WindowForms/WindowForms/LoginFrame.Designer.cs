namespace WindowForms
{
    partial class LoginFrame
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
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            txtboxAccountID = new TextBox();
            btnLogin = new Button();
            btnCancel = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(239, 228, 201);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(392, 70);
            panel2.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 22);
            label1.Name = "label1";
            label1.Size = new Size(166, 24);
            label1.TabIndex = 0;
            label1.Text = "Enter Account ID";
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 14.25F);
            label2.Location = new Point(21, 87);
            label2.Name = "label2";
            label2.Size = new Size(350, 53);
            label2.TabIndex = 15;
            label2.Text = "Please enter the given account id in your email inbox.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtboxAccountID
            // 
            txtboxAccountID.BackColor = Color.FromArgb(248, 246, 240);
            txtboxAccountID.BorderStyle = BorderStyle.FixedSingle;
            txtboxAccountID.Font = new Font("Times New Roman", 14.25F);
            txtboxAccountID.Location = new Point(21, 145);
            txtboxAccountID.Margin = new Padding(5);
            txtboxAccountID.Multiline = true;
            txtboxAccountID.Name = "txtboxAccountID";
            txtboxAccountID.Size = new Size(350, 41);
            txtboxAccountID.TabIndex = 49;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkGoldenrod;
            btnLogin.BackgroundImageLayout = ImageLayout.None;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Times New Roman", 11.25F);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(278, 203);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(93, 31);
            btnLogin.TabIndex = 50;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(0, 123, 167);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Transparent;
            btnCancel.Location = new Point(21, 203);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(108, 29);
            btnCancel.TabIndex = 51;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // LoginFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 255);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(txtboxAccountID);
            Controls.Add(label2);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginFrame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginFrame";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Label label2;
        private TextBox txtboxAccountID;
        private Button btnLogin;
        private Button btnCancel;
    }
}