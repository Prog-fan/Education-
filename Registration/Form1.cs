using System;
using System.Drawing;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Registration
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public Form1()
        {
            this.Text = "Регистрация";
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            radioButton1.Checked = true;
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void CloseScreen_Click(object sender, EventArgs e) => Close();
        private void MinimizedScreen_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            txtMask.Text = "";
            lbl.Text = radioButton1.Checked ? "номер телефона" : "Дата рождения";
            if (radioButton1.Checked)
            {
                txtMask.Mask = "+7 (000) 000-00-00";
                txtMask.PromptChar = '_';
            }
            else
            {
                txtMask.Mask = "00/00/0000";
                txtMask.ValidatingType = typeof(System.DateTime);
                txtMask.PromptChar = '_';
            }
        }
        // Метод генерации логина для заказчика
        private string GenerateCustomerLogin(string lastName, string firstName, string middleName, string phoneNumber)
        {
            // Получаем первые буквы ФИО
            string initials = $"{lastName[0]}{firstName[0]}{middleName[0]}".ToUpper();

            if (phoneNumber.Length < 3)
            {
                throw new ArgumentException("Номер телефона должен содержать не менее трех цифр.");
            }
            // Добавляем последние три цифры номера телефона
            string lastThreeDigits = phoneNumber.Substring(phoneNumber.Length - 3);
            return $"{initials}{lastThreeDigits}";
        }
        // Метод генерации пароля
        private string GeneratePassword()
        {
            Random random = new Random();
            StringBuilder password = new StringBuilder();
            // Символы для генерации пароля
            const string lowerCaseChars = "abcdefghijklmnopqrstuvwxyz";
            const string upperCaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string digits = "0123456789";

            password.Append(lowerCaseChars[random.Next(lowerCaseChars.Length)]);
            password.Append(lowerCaseChars[random.Next(lowerCaseChars.Length)]);
            password.Append(upperCaseChars[random.Next(upperCaseChars.Length)]);
            password.Append(upperCaseChars[random.Next(upperCaseChars.Length)]);
            password.Append(digits[random.Next(digits.Length)]);
            password.Append(digits[random.Next(digits.Length)]);
            password.Append(upperCaseChars[random.Next(upperCaseChars.Length)]);
            password.Append(upperCaseChars[random.Next(upperCaseChars.Length)]);

            return password.ToString();
        }

        private void Registration(object sender, EventArgs e)
        {
            try
            {
                // Получение данных с формы
                string name = txtName.Text;
                string lastName = txtLastName.Text;
                string patronymic = txtPatronymic.Text;
                string mask = txtMask.Text;

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(patronymic))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля ФИО.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (!ValidDateAndAge(mask) && radioButton2.Checked)
                {
                    MessageBox.Show("Неверная маска ввода", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string generatedLogin = GenerateCustomerLogin(lastName, name, patronymic, mask);
                    string generatedPassword = GeneratePassword();
                    txtLogin.Text = generatedLogin;
                    txtPassword.Text = generatedPassword;
                }
                
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidDateAndAge(string date)
        {
            if (DateTime.TryParse(date, out DateTime parsedDate))
            {
                // Проверка на количество дней в месяце
                if (parsedDate.Day > DateTime.DaysInMonth(parsedDate.Year, parsedDate.Month))
                {
                    return false;
                }

                int age = DateTime.Now.Year - parsedDate.Year;
                if (DateTime.Now < parsedDate.AddYears(age))
                {
                    age--;
                }
            }
            return false;
        }

    }
}
