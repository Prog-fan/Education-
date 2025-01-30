using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Organizer
{
    public partial class RegistrationForm : Form
    {
        private readonly Logic _logic;

        public RegistrationForm()
        {
            InitializeComponent();
            InitializeToolTips();
            _logic = new Logic();
        }

        private void InitializeToolTips()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(LoginTextBox, "Придумайте логин");
            toolTip.SetToolTip(PasswordTextBox, "Придумайте пароль");
            toolTip.SetToolTip(RepeatPasswordTextBox, "Подтвердите пароль");
        }

        private void HandleRegistration(object sender, EventArgs e)
        {
            string username = LoginTextBox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();
            string repeatPassword = RepeatPasswordTextBox.Text.Trim();

            if (!IsInputValid(username, password, repeatPassword))
                return;

            if (_logic.UserExists(username))
            {
                MessageLabel.Text ="Пользователь с таким именем уже существует.";
                ClearInputFields();
                return;
            }

            RegisterUser(username, password);
        }

        private bool IsInputValid(string username, string password, string repeatPassword)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageLabel.Text = "Имя пользователя и пароль не могут быть пустыми.";
                return false;
            }

            if (password != repeatPassword)
            {
                MessageLabel.Text = "Пароли не совпадают. Убедитесь, что вы ввели их правильно.";
                ClearPasswordFields();
                return false;
            }

            if (password.Length < 8)
            {
                MessageLabel.Text = "Пароль должен содержать не менее 8 символов.";
                return false;
            }

            if (!password.Any(char.IsDigit) || !password.Any(char.IsUpper))
            {
                MessageLabel.Text = "Пароль должен содержать хотя бы одну цифру и одну заглавную букву.";
                return false;
            }

            return true;
        }

        private void RegisterUser(string username, string password)
        {
            try
            {
                string userFilePath = _logic.UsersFile();
                using (StreamWriter sw = new StreamWriter(userFilePath, true))
                {
                    sw.WriteLine($"{username}:{password}");
                }

               MessageLabel.Text ="Регистрация прошла успешно.";
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageLabel.Text = $"Произошла ошибка: {ex.Message}";
            }
        }

        private void ClearInputFields()
        {
            LoginTextBox.Text = string.Empty;
            ClearPasswordFields();
        }

        private void ClearPasswordFields()
        {
            PasswordTextBox.Text = string.Empty;
            RepeatPasswordTextBox.Text = string.Empty;
        }

        private void TogglePasswordVisibility(object sender, EventArgs e)
        {
            bool isPasswordVisible = !PasswordTextBox.UseSystemPasswordChar;
            PasswordTextBox.UseSystemPasswordChar = isPasswordVisible;
            RepeatPasswordTextBox.UseSystemPasswordChar = isPasswordVisible;
        }

        private void HandleMouseDown(object sender, MouseEventArgs e) { FormMover.EnableFormMove(this, e); }

        private void CloseForm(object sender, EventArgs e) { Close(); }
    }
}
