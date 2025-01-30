using System;
using System.IO;
using System.Windows.Forms;

namespace Organizer
{
    public partial class AuthorizationForm : Form
    {
        private readonly Logic _logic;

        public AuthorizationForm()
        {
            InitializeComponent();
            InitializeToolTips();
            _logic = new Logic();
        }

        private void InitializeToolTips()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(LoginTextBox, "Введите логин");
            toolTip.SetToolTip(PasswordTextBox, "Введите пароль");
        }
        private void TogglePasswordVisibility(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = !PasswordTextBox.UseSystemPasswordChar;
        }

        private void HandleEntry(object sender, EventArgs e)
        {
            string username = LoginTextBox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();

            if (IsInputValid(username, password))
            {
                AuthenticateUser(username, password);
            }
        }

        private bool IsInputValid(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageLabel.Text = "Поля логина и пароля не могут быть пустыми.";
                return false;
            }

            return true;
        }

        private void AuthenticateUser(string username, string password)
        {
            try
            {
                if (_logic.Authenticate(username, password))
                {
                    SaveUserName(username);
                    MessageLabel.Text = "Авторизация прошла успешно.";
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    PasswordTextBox.Text = string.Empty;
                    MessageLabel.Text = "Неверное имя пользователя или пароль.";
                }
            }
            catch (Exception ex)
            {
                MessageLabel.Text = $"Произошла ошибка: {ex.Message}";
            }
        }

        private void SaveUserName(string username)
        {
            try
            {
                _logic.SaveUserName(username);
            }
            catch (Exception)
            {
                MessageLabel.Text = "Не удалось сохранить имя пользователя. Попробуйте снова.";
            }
        }

        private void OpenRegistrationForm(object sender, EventArgs e)
        {
            Hide(); 
            LoginTextBox.Text = string.Empty;
            PasswordTextBox.Text = string.Empty;
            using (var registrationForm = new RegistrationForm())
            {
                registrationForm.ShowDialog();
            }

            Show();
        }

        private void CloseForm(object sender, EventArgs e) { Close(); }

        private void HandleMouseDown(object sender, MouseEventArgs e) { FormMover.EnableFormMove(this, e); }
    }
}