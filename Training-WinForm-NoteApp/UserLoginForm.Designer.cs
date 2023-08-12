namespace Training_WinForm_NoteApp
{
    partial class UserLoginForm
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
            btnUserLoginGirisYap = new Button();
            label1 = new Label();
            label2 = new Label();
            txtUserLoginUsername = new TextBox();
            txtUserLoginPassword = new TextBox();
            btnUserLoginClose = new Button();
            SuspendLayout();
            // 
            // btnUserLoginGirisYap
            // 
            btnUserLoginGirisYap.Location = new Point(22, 125);
            btnUserLoginGirisYap.Name = "btnUserLoginGirisYap";
            btnUserLoginGirisYap.Size = new Size(274, 36);
            btnUserLoginGirisYap.TabIndex = 3;
            btnUserLoginGirisYap.Text = "Giriş Yap";
            btnUserLoginGirisYap.UseVisualStyleBackColor = true;
            btnUserLoginGirisYap.Click += btnUserLoginGirisYap_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 55);
            label1.Name = "label1";
            label1.Size = new Size(112, 14);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 87);
            label2.Name = "label2";
            label2.Size = new Size(56, 14);
            label2.TabIndex = 0;
            label2.Text = "Şifre :";
            // 
            // txtUserLoginUsername
            // 
            txtUserLoginUsername.Location = new Point(140, 52);
            txtUserLoginUsername.Name = "txtUserLoginUsername";
            txtUserLoginUsername.Size = new Size(156, 22);
            txtUserLoginUsername.TabIndex = 1;
            // 
            // txtUserLoginPassword
            // 
            txtUserLoginPassword.Location = new Point(140, 84);
            txtUserLoginPassword.Name = "txtUserLoginPassword";
            txtUserLoginPassword.Size = new Size(156, 22);
            txtUserLoginPassword.TabIndex = 2;
            txtUserLoginPassword.UseSystemPasswordChar = true;
            // 
            // btnUserLoginClose
            // 
            btnUserLoginClose.Location = new Point(22, 167);
            btnUserLoginClose.Name = "btnUserLoginClose";
            btnUserLoginClose.Size = new Size(274, 36);
            btnUserLoginClose.TabIndex = 4;
            btnUserLoginClose.Text = "Kapat";
            btnUserLoginClose.UseVisualStyleBackColor = true;
            btnUserLoginClose.Click += btnUserLoginClose_Click;
            // 
            // UserLoginForm
            // 
            AcceptButton = btnUserLoginGirisYap;
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 229);
            Controls.Add(txtUserLoginPassword);
            Controls.Add(txtUserLoginUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnUserLoginClose);
            Controls.Add(btnUserLoginGirisYap);
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "UserLoginForm";
            Text = "UserLoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUserLoginGirisYap;
        private Label label1;
        private Label label2;
        private TextBox txtUserLoginUsername;
        private TextBox txtUserLoginPassword;
        private Button btnUserLoginClose;
    }
}