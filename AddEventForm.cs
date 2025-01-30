using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Organizer
{
    public partial class AddEventForm : Form
    {
        private readonly Logic _logic;

        public AddEventForm()
        {
            InitializeComponent();
            CategoryEventComboBox.SelectedIndex = 0;
            _logic = new Logic();
        }

        public AddEventForm(string date, string time, string text)
        {
            InitializeComponent();
            _logic =  new Logic();
            Calendar.Text = date;
            TimePicker.Text = time;
            TextBox.Text = text;
        }

        private void HandleMouseDown(object sender, MouseEventArgs e)
        {
            FormMover.EnableFormMove(this, e);
        }

        private void AddEvent(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TextBox.Text))
                {
                    MessageBox.Show("Заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Calendar.SelectionRange.Start.Date < DateTime.Today)
                {
                    MessageBox.Show("Нельзя выбрать прошедшую дату.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string eventData = $"{_logic.GetUserName()}§{Calendar.SelectionRange.Start.ToShortDateString()}¤{TimePicker.Text}¤{TextBox.Text}¶{CategoryEventComboBox.Text}";

                try
                {
                    File.AppendAllText(_logic.TempFile(), eventData + Environment.NewLine);
                }
                catch (IOException ioEx)
                {
                    MessageBox.Show($"Ошибка записи в файл: {ioEx.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloseFormAfterDeactivation(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(200);
            Close();
        }
    }
}