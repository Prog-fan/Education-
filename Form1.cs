using System;
using System.Windows.Forms;
using Jace;
using System.Linq;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        // Удаление последнего символа
        private void DelChar_Click(object sender, EventArgs e)
        {
            if (panel.Text.Length > 0) { panel.Text = panel.Text.Remove(panel.Text.Length - 1); }
        }

        // Очистка всего поля
        private void ClearField_Click(object sender, EventArgs e)
        {
            bool isTextEmpty = string.IsNullOrEmpty(panel.Text);
            SetClearButtonText(isTextEmpty ? "C" : "AC");

            if (isTextEmpty) { HistoryBar.Items.Clear(); }
            else
            {
                panel.Text = "";
                IntermediateResultString.Text = panel.Text;
            }
        }

        private void SetClearButtonText(string text)
        {
            btnClear.Text = text; 
            btnClearC.Text = text;
        }

        // Ввод математических символов и цифр
        private void OperandCals_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string memory = button.Text;

            if (!ValidOperandInput(memory)) { return; }
            if (panel.Text == "0") { panel.Text = memory; }
            else { panel.Text += memory; }
        }

        //обработчик событий для ввода символов
        private bool ValidOperandInput(string memory)
        {
            if (panel.Text.Length > 0)
            {
                char lastChar = panel.Text[panel.Text.Length - 1];
                if ("+*/,".Contains(lastChar) && "+*/,".Contains(memory)
                   || "-".Contains(lastChar) && "-/*+".Contains(memory))
                {
                    return false;
                }
            }

            if (panel.Text.Length == 0 && "*/+,".Contains(memory)) { return false; }

            return true;
        }

        private void Panel_TextChanged(object sender, EventArgs e)
        {
            string lastResult = panel.Text;

            if (lastResult.Length > 0 && !"+-*/".Contains(lastResult.Last()))
            {
                try
                {
                    CalculationEngine engine = new CalculationEngine();
                    var result = engine.Calculate(lastResult);
                    IntermediateResultString.Text = result.ToString();
                }
                catch
                {
                    IntermediateResultString.Text = "Error";
                }
            }
        }

        // Конвертирование строки в математический пример и вывод ответа
        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            try
            {
                HistoryBar.Items.Add($"{panel.Text} = {IntermediateResultString.Text}");
                panel.Text = IntermediateResultString.Text;
            }
            catch
            {
                panel.Text = "Error";
            }
        }

        // Дополнительные математические операции
        private void MathOperation_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string memory = button.Text;
            string[] parts = panel.Text.Split(new char[] { '+', '-', '*', '/' });
            string lastNumber = parts.Last();

            // Определяем индекс последнего разделителя
            int lastSeparatorIndex = panel.Text.LastIndexOfAny(new char[] { '+', '-', '*', '/' });

            // Проверяем, является ли последний разделитель знаком минус
            bool lastSeparatorWasMinus = lastSeparatorIndex != -1 && panel.Text[lastSeparatorIndex] == '-';

            if (double.TryParse(lastNumber, out double number))
            {
                double result = 0;

                switch (memory)
                {
                    case "%":
                        result = number / 100;
                        break;
                    case "sin":
                        if (!lastSeparatorWasMinus) { result = Math.Sin(number); }
                        else {IntermediateResultString.Text = "error"; return; }
                        break;
                    case "cos":
                        if (!lastSeparatorWasMinus) { result = Math.Cos(number); }
                        else { IntermediateResultString.Text = "error"; return; }
                        break;
                    case "tan":
                        if (!lastSeparatorWasMinus) { result = Math.Tan(number); }
                        else { IntermediateResultString.Text = "error"; return; }
                        break;
                    case "atan":
                        if (!lastSeparatorWasMinus) { result = Math.Atan(number); }
                        else { IntermediateResultString.Text = "error"; return; }
                        break;
                    case "±":
                        
                        break;
                    case "√":
                        if (!lastSeparatorWasMinus) { result = Math.Sqrt(number); }
                        else { IntermediateResultString.Text = "error"; return; }
                        break;
                    case "Xⁿ":
                        result = Math.Pow(number, 2);
                        break;
                    case "X!":
                        result = Factorial(number);
                        break;
                    case "1/X":
                        if (number != 0) { result = 1 / number; }
                        else { IntermediateResultString.Text = "error"; return; }
                        break;
                    case "lg":
                        if (!lastSeparatorWasMinus) { result = Math.Log10(number); }
                        else { IntermediateResultString.Text = "error"; return; }
                        break;
                    case "ln":
                        if (!lastSeparatorWasMinus) { result = Math.Log(number); }
                        else { IntermediateResultString.Text = "error"; return; }
                        break;
                    case "Pi":
                        result = Math.PI * number;
                        break;
                    case "e":
                        result = Math.E * number;
                        break;
                    default:
                       break;
                }

                string a = result.ToString();
                UpdatePanelWithResult(lastNumber, a);
            }
        }

        //разбивает строку на подстроки, позже заменяет вторую подстроку результатом от мат.операций, разделитель - математический знак
        private void UpdatePanelWithResult(string lastNumber, string result)
        {
            panel.Text = panel.Text.Substring(0, panel.Text.Length - lastNumber.Length) + result;
        }

        private double Factorial(double number)
        {
            double factorial = 1.0;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        // Скрывает/показывает контейнер fieldScience 
        private void BntF_Click(object sender, EventArgs e) { fieldScience.Visible = !fieldScience.Visible; }

        private void BntFullListBox_Click(object sender, EventArgs e)
        {
            if (HistoryBar.Dock == DockStyle.None)
            {
                panel.Visible = false;
                HistoryBar.Dock = DockStyle.Fill;
            }
            else
            {
                panel.Visible = true;
                HistoryBar.Dock = DockStyle.None;
            }
        }

        //ввод цифр и математических знаков с клавиатуры
        private void Panel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (char.IsDigit(e.KeyChar) || "+-*/,".Contains(e.KeyChar))
            {
                OperandCals_Click(new Button { Text = e.KeyChar.ToString() }, e);
            }

            if (e.KeyChar == '=' || e.KeyChar == (char)Keys.Enter)
            {
                ButtonEquals_Click(sender, e);
            }
            if(e.KeyChar == (char)8)
            {
                DelChar_Click(sender, e);
            }
        }
    }
}