namespace Organizer
{
    partial class AuthorizationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.EntryButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordVisibleCheck = new System.Windows.Forms.CheckBox();
            this.RegistationLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EntryButton
            // 
            this.EntryButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EntryButton.Location = new System.Drawing.Point(12, 296);
            this.EntryButton.Name = "EntryButton";
            this.EntryButton.Size = new System.Drawing.Size(323, 39);
            this.EntryButton.TabIndex = 2;
            this.EntryButton.Text = "Вход";
            this.EntryButton.UseVisualStyleBackColor = true;
            this.EntryButton.Click += new System.EventHandler(this.HandleEntry);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.PasswordTextBox.Location = new System.Drawing.Point(12, 119);
            this.PasswordTextBox.MaximumSize = new System.Drawing.Size(380, 50);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.ShortcutsEnabled = false;
            this.PasswordTextBox.Size = new System.Drawing.Size(323, 26);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // Password
            // 
            this.Password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Password.Location = new System.Drawing.Point(12, 96);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(72, 20);
            this.Password.TabIndex = 3;
            this.Password.Text = "Пароль";
            // 
            // Login
            // 
            this.Login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Login.Location = new System.Drawing.Point(12, 44);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(59, 20);
            this.Login.TabIndex = 5;
            this.Login.Text = "Логин";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LoginTextBox.Location = new System.Drawing.Point(12, 67);
            this.LoginTextBox.MaximumSize = new System.Drawing.Size(380, 50);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(323, 26);
            this.LoginTextBox.TabIndex = 0;
            // 
            // PasswordVisibleCheck
            // 
            this.PasswordVisibleCheck.AutoSize = true;
            this.PasswordVisibleCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.PasswordVisibleCheck.Location = new System.Drawing.Point(16, 151);
            this.PasswordVisibleCheck.Name = "PasswordVisibleCheck";
            this.PasswordVisibleCheck.Size = new System.Drawing.Size(109, 24);
            this.PasswordVisibleCheck.TabIndex = 6;
            this.PasswordVisibleCheck.TabStop = false;
            this.PasswordVisibleCheck.Text = "Показать";
            this.PasswordVisibleCheck.UseVisualStyleBackColor = true;
            this.PasswordVisibleCheck.Click += new System.EventHandler(this.TogglePasswordVisibility);
            // 
            // RegistationLabel
            // 
            this.RegistationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RegistationLabel.AutoSize = true;
            this.RegistationLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.RegistationLabel.Location = new System.Drawing.Point(12, 362);
            this.RegistationLabel.Name = "RegistationLabel";
            this.RegistationLabel.Size = new System.Drawing.Size(183, 13);
            this.RegistationLabel.TabIndex = 8;
            this.RegistationLabel.Text = "Нет аккаунта? Зарегестрируйтесь";
            this.RegistationLabel.Click += new System.EventHandler(this.OpenRegistrationForm);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(313, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(22, 20);
            this.CloseButton.TabIndex = 13;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseForm);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(12, 338);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(0, 13);
            this.MessageLabel.TabIndex = 14;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(347, 384);
            this.ControlBox = false;
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.RegistationLabel);
            this.Controls.Add(this.PasswordVisibleCheck);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.EntryButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandleMouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EntryButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.CheckBox PasswordVisibleCheck;
        private System.Windows.Forms.Label RegistationLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label MessageLabel;
    }
}

