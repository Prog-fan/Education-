using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace StatisticsCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Считывание данных из текстовых полей
                var variants = VariantsInput.Text.Split(' ').Select(double.Parse).ToList();
                var frequencies = FrequenciesInput.Text.Split(' ').Select(int.Parse).ToList();

                if (variants.Count != frequencies.Count)
                {
                    MessageBox.Show("Количество вариантов и частот должно совпадать.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                BtnStart.IsEnabled = !BtnStart.IsEnabled;

                // Создание списка для расчетов
                var data = new List<DataPoint>();
                double totalFrequency = frequencies.Sum();
                double mean = 0;

                for (int i = 0; i < variants.Count; i++)
                {
                    data.Add(new DataPoint
                    {
                        Variant = variants[i],
                        Frequency = frequencies[i],
                    });
                    mean += variants[i] * frequencies[i];
                }

                mean /= totalFrequency;

                // Расчет медианы
                var sortedData = data.OrderBy(d => d.Variant).ToList();
                double cumulativeFrequency = 0;
                double median = 0;

                foreach (var item in sortedData)
                {
                    cumulativeFrequency += item.Frequency;
                    if (cumulativeFrequency >= totalFrequency / 2)
                    {
                        median = item.Variant;
                        break;
                    }
                }

                // Расчет моды
                var mode = data.OrderByDescending(d => d.Frequency).First().Variant;

                // Расчет дисперсии
                double variance = data.Sum(d => d.Frequency * Math.Pow(d.Variant - mean, 2)) / totalFrequency;

                // Расчет среднеквадратичного отклонения
                double stdDeviation = Math.Sqrt(variance);

                ResultLst.Items.Add($"Вычисления:");
                ResultLst.Items.Add($"Математическое ожидание: {mean:F2}");
                ResultLst.Items.Add($"Медиана: {median:F2}");
                ResultLst.Items.Add($"Мода: {mode:F2}");
                ResultLst.Items.Add($"Дисперсия: {variance:F2}");
                ResultLst.Items.Add($"Среднеквадратичное отклонение: {stdDeviation:F2}");
            
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            BtnStart.IsEnabled = !BtnStart.IsEnabled;
            VariantsInput.Clear();
            FrequenciesInput.Clear();
            ResultLst.Items.Clear(); 
        }

        private void Text_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (BtnStart.IsEnabled == false) {BtnStart.IsEnabled = !BtnStart.IsEnabled; }
        }
    }

    public class DataPoint
    {
        public double Variant { get; set; } // Вариант
        public int Frequency { get; set; } // Частота
    }
}