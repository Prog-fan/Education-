namespace Organizer
{
    partial class RegistrationForm
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
            this.RepeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.RepeadPassword = new System.Windows.Forms.Label();
            this.PasswordVisibleCheck = new System.Windows.Forms.CheckBox();
            this.Login = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.btnEntry = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RepeatPasswordTextBox
            // 
            this.RepeatPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RepeatPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.RepeatPasswordTextBox.Location = new System.Drawing.Point(12, 201);
            this.RepeatPasswordTextBox.MaximumSize = new System.Drawing.Size(380, 50);
            this.RepeatPasswordTextBox.Name = "RepeatPasswordTextBox";
            this.RepeatPasswordTextBox.ShortcutsEnabled = false;
            this.RepeatPasswordTextBox.Size = new System.Drawing.Size(320, 26);
            this.RepeatPasswordTextBox.TabIndex = 2;
            this.RepeatPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // RepeadPassword
            // 
            this.RepeadPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RepeadPassword.AutoSize = true;
            this.RepeadPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.RepeadPassword.Location = new System.Drawing.Point(12, 178);
            this.RepeadPassword.Name = "RepeadPassword";
            this.RepeadPassword.Size = new System.Drawing.Size(167, 20);
            this.RepeadPassword.TabIndex = 10;
            this.RepeadPassword.Text = "Повторите пароль";
            // 
            // PasswordVisibleCheck
            // 
            this.PasswordVisibleCheck.AutoSize = true;
            this.PasswordVisibleCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordVisibleCheck.Location = new System.Drawing.Point(19, 233);
            this.PasswordVisibleCheck.Name = "PasswordVisibleCheck";
            this.PasswordVisibleCheck.Size = new System.Drawing.Size(75, 17);
            this.PasswordVisibleCheck.TabIndex = 29;
            this.PasswordVisibleCheck.TabStop = false;
            this.PasswordVisibleCheck.Text = "Показать";
            this.PasswordVisibleCheck.UseVisualStyleBackColor = true;
            this.PasswordVisibleCheck.Click += new System.EventHandler(this.TogglePasswordVisibility);
            // 
            // Login
            // 
            this.Login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Login.Location = new System.Drawing.Point(15, 49);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(59, 20);
            this.Login.TabIndex = 28;
            this.Login.Text = "Логин";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LoginTextBox.Location = new System.Drawing.Point(12, 72);
            this.LoginTextBox.MaximumSize = new System.Drawing.Size(380, 50);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(320, 26);
            this.LoginTextBox.TabIndex = 0;
            // 
            // Password
            // 
            this.Password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Password.Location = new System.Drawing.Point(15, 126);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(72, 20);
            this.Password.TabIndex = 26;
            this.Password.Text = "Пароль";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.PasswordTextBox.Location = new System.Drawing.Point(12, 149);
            this.PasswordTextBox.MaximumSize = new System.Drawing.Size(380, 50);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.ShortcutsEnabled = false;
            this.PasswordTextBox.Size = new System.Drawing.Size(320, 26);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.WordWrap = false;
            // 
            // btnEntry
            // 
            this.btnEntry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEntry.Location = new System.Drawing.Point(12, 314);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(320, 39);
            this.btnEntry.TabIndex = 3;
            this.btnEntry.Text = "Зарегистрироваться";
            this.btnEntry.UseVisualStyleBackColor = true;
            this.btnEntry.Click += new System.EventHandler(this.HandleRegistration);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(310, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(22, 20);
            this.CloseButton.TabIndex = 33;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseForm);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(16, 356);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(0, 13);
            this.MessageLabel.TabIndex = 34;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(344, 378);
            this.ControlBox = false;
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.RepeadPassword);
            this.Controls.Add(this.PasswordVisibleCheck);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.RepeatPasswordTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.btnEntry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandleMouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox RepeatPasswordTextBox;
        private System.Windows.Forms.Label RepeadPassword;
        private System.Windows.Forms.CheckBox PasswordVisibleCheck;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button btnEntry;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label MessageLabel;
    }
}