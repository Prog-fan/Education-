using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Organizer
{
    public partial class OrganizerForm : Form
    {
        readonly Logic _logic = new Logic();
        public OrganizerForm()
        {
            InitializeComponent();
            InitializeToolTips();
            CategoryEventComboBox.SelectedIndex = 0;
            AccoutName.Text = _logic.GetUserName();
        }

        private void InitializeToolTips()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(AddEventButton, "Добавить событие");
            toolTip.SetToolTip(pictureBox1, "Поиск по событиям");
            toolTip.SetToolTip(SortButton, "Сортировка по дате");
            toolTip.SetToolTip(AllByCategoryRadioButton, "Фильтр по категориям");
            toolTip.SetToolTip(AllEventRadioButton, "Вывод всех событий");
        }


        private void ShowAddEventForm(object sender, EventArgs e)
        {
            var eventForm = new AddEventForm();
            eventForm.Show();
        }

        private void LoadDataFromResource(object sender, EventArgs e)
        {
            ListEventDataGrid.Rows.Clear();

            if (!File.Exists(_logic.TempFile()))
            {
                try
                {
                    File.Create(_logic.TempFile()).Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не удалось создать файл: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            string[] lines;
            try
            {
                lines = File.ReadAllLines(_logic.TempFile());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось прочитать файл: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var line in lines)
            {
                try
                {
                    var parts = line.Split('§');
                    var part = parts[1].Split('¶');
                    var records = part[0].Split('¤');
                    if (records.Length == 3)
                    {
                        if (parts[0] == _logic.GetUserName() && IsFilteredByCategory(part[1]))
                        {
                            ListEventDataGrid.Rows.Add(records[0], records[1], records[2]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка обработки строки: \"{line}\". {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private bool IsFilteredByCategory(string category)
        {
            if (AllByCategoryRadioButton.Checked)
            {
                CategoryEventComboBox.Enabled = true;
                if (CategoryEventComboBox.Text == category)
                {
                    return true;
                }
                return false;
            }
            CategoryEventComboBox.Enabled = false;
            return true;
        }

        private void DeleteSelectedRow(object sender, EventArgs e)
        {
                var selectedRow = ListEventDataGrid.SelectedRows[0];
                string date = selectedRow.Cells[0].Value.ToString();
                string time = selectedRow.Cells[1].Value.ToString();
                string text = selectedRow.Cells[2].Value.ToString();

                string[] lines = File.ReadAllLines(_logic.TempFile());
                using (StreamWriter writer = new StreamWriter(_logic.TempFile(), false))
                {
                    foreach (var line in lines)
                    {
                        if (!line.Contains($"{date}¤{time}¤{text}"))
                        {
                            writer.WriteLine(line);
                        }
                    }
                }
                LoadDataFromResource(sender, e);
        }

        private void UpdateRow(object sender, EventArgs e)
        {
            // Проверяем, выбрана ли строка
            if (ListEventDataGrid.SelectedRows.Count > 0)
            {
                var selectedRow = ListEventDataGrid.SelectedRows[0];

                // Получаем данные из выбранной строки
                string date = selectedRow.Cells[0].Value.ToString();
                string time = selectedRow.Cells[1].Value.ToString();
                string text = selectedRow.Cells[2].Value.ToString();
                // Создаем и открываем форму с переданными данными
                DeleteSelectedRow(sender, e);
                var eventForm = new AddEventForm(date, time, text);
                eventForm.FormClosed += (s, args) =>
                {
                    LoadDataFromResource(sender, e);
                };

                eventForm.Show();
              
            }
            else
            {
                MessageBox.Show("Выберите строку для редактирования", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = SearchTextBox.Text.ToLower();
            FilterDataBySearchText(searchText);
        }

        private void FilterDataBySearchText(string searchText)
        {
            ListEventDataGrid.Rows.Clear();
            string[] lines;
            try
            {
                lines = File.ReadAllLines(_logic.TempFile());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось прочитать файл: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var line in lines)
            {
                try
                {
                    var parts = line.Split('§');
                    var part = parts[1].Split('¶');
                    var records = part[0].Split('¤');
                    string date = records[0].ToLower();
                    string time = records[1].ToLower();
                    string text = records[2].ToLower();

                    if (parts[0] == _logic.GetUserName() && IsFilteredByCategory(part[1]))
                    {
                        // Фильтрация по введенному тексту
                        if (date.Contains(searchText) || time.Contains(searchText) || text.Contains(searchText))
                        {
                            ListEventDataGrid.Rows.Add(records[0], records[1], records[2]);
                        }
                    }
                }
                catch (Exception ex)

                {
                    MessageBox.Show($"Ошибка обработки строки: \"{line}\". {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void SortByDate(object sender, EventArgs e)
        {
            // Сортировка строк по времени
            var sortedRows = ListEventDataGrid.Rows.Cast<DataGridViewRow>().Where(r => r.Cells[0].Value != null)
                .OrderBy
                (r =>
                    {
                        if (DateTime.TryParse(r.Cells[0].Value.ToString(), out var date))
                        {
                            return date;
                        }
                        return DateTime.MaxValue; // Если время некорректно, ставим в конец
                    }
                ).ToList();

            ListEventDataGrid.Rows.Clear();
            foreach (var row in sortedRows)
            {
                var values = row.Cells.Cast<DataGridViewCell>().Select(c => c.Value).ToArray();
                ListEventDataGrid.Rows.Add(values);
            }
        }

        private void ExitTool_Click(object sender, EventArgs e) { Application.Restart(); }
    }
}