using System;
using System.Windows.Forms;

namespace Railroad_ticket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addRecordButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(dateTime.Text) ||
                    string.IsNullOrWhiteSpace(comboFlight.Text) ||
                    string.IsNullOrWhiteSpace(comboTypeWagon.Text) ||
                    string.IsNullOrWhiteSpace(numPassengers.Text) ||
                    string.IsNullOrWhiteSpace(numPassengersWithBenefits.Text))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля перед добавлением записи.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int benefitPassengers = int.Parse(numPassengersWithBenefits.Text);
                int totalPassengers = int.Parse(numPassengers.Text);


                if (benefitPassengers > totalPassengers)
                {
                    MessageBox.Show("Количество льготных билетов не может быть больше общего количества пассажиров.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                resultDataGrid.Rows.Add
                (
                    dateTime.Text,
                    comboFlight.Text,
                    comboTypeWagon.Text,
                    totalPassengers,
                    benefitPassengers,
                    checkLuggage.Checked ? "Да" : "Нет",
                    (checkNutrition.Checked || checkBedding.Checked) ? "Да" : "Нет",
                    CalculateTotalCost(totalPassengers, benefitPassengers)
                );
            }
            catch
            {
                MessageBox.Show("При добавлении записи произошла ошибка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dellRecordButton_Click(object sender, EventArgs e)
        {
            if (resultDataGrid.Rows.Count > 1) 
            {
                resultDataGrid.Rows.RemoveAt(resultDataGrid.Rows.Count - 2); 
            }
            else
            {
                MessageBox.Show("Нет записей для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboTypeWagon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTypeWagon.Text == "СВ")
            {
                checkBedding.Checked = true;
                checkNutrition.Checked = true;
                checkBedding.Enabled = false;
                checkNutrition.Enabled = false;
            }
            else
            {
                checkBedding.Checked = false;
                checkNutrition.Checked = false;
                checkBedding.Enabled = true;
                checkNutrition.Enabled = true;
            }
        }

        private decimal SelectedBaseCost()
        {
            if (comboFlight.Text == "Екатеринбург - Пермь")
            {
                if (comboTypeWagon.Text == "Сидячий") return 1340;
                if (comboTypeWagon.Text == "Плацкарт") return 1242;
                if (comboTypeWagon.Text == "Купе") return 1266;
                if (comboTypeWagon.Text == "СВ") return 4475;
            }

            if (comboFlight.Text == "Екатеринбург - Тюмень")
            {
                if (comboTypeWagon.Text == "Сидячий") return 715;
                if (comboTypeWagon.Text == "Плацкарт") return 1008;
                if (comboTypeWagon.Text == "Купе") return 1105;
                if (comboTypeWagon.Text == "СВ") return 3706;
            }

            if (comboFlight.Text == "Екатеринбург - Казань")
            {
                if (comboTypeWagon.Text == "Сидячий") return 1270;
                if (comboTypeWagon.Text == "Плацкарт") return 1790;
                if (comboTypeWagon.Text == "Купе") return 2066;
                if (comboTypeWagon.Text == "СВ") return 7553;
            }

            if (comboFlight.Text == "Екатеринбург - Новосибирск")
            {
                if (comboTypeWagon.Text == "Сидячий") return 3259;
                if (comboTypeWagon.Text == "Плацкарт") return 3621;
                if (comboTypeWagon.Text == "Купе") return 3748;
                if (comboTypeWagon.Text == "СВ") return 14858;
            }

            if (comboFlight.Text == "Екатеринбург - Москва")
            {
                if (comboTypeWagon.Text == "Сидячий") return 4203;
                if (comboTypeWagon.Text == "Плацкарт") return 4161;
                if (comboTypeWagon.Text == "Купе") return 7255;
                if (comboTypeWagon.Text == "СВ") return 21596;
            }

            return 0; 
        }

        private decimal CalculateTotalCost(int totalPassengers, int benefitPassengers)
        {
            decimal baseCost = SelectedBaseCost();

            if (baseCost == 0)
            {
                MessageBox.Show("Выберите корректный маршрут и тип вагона.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            decimal luggageCost = checkLuggage.Checked ? (baseCost/100) : 0;
            decimal additionalServicesCost = (checkNutrition.Checked || checkBedding.Checked) ? (baseCost / 100) : 0;

            if (comboTypeWagon.Text == "СВ")
            {
                additionalServicesCost = 0;
            }

            decimal totalCost = 0;
            totalCost += benefitPassengers * baseCost * 0.5m;
            totalCost += (totalPassengers - benefitPassengers) * baseCost;
            totalCost += luggageCost + additionalServicesCost;

            return totalCost;
        }
    }
}
