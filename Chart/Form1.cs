using System;
using System.Windows.Forms;

namespace Chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenRandom(object sender, EventArgs e)
        {
            Random random = new Random();

            double rx = Math.Round(random.NextDouble(), 2); 
            double ry = Math.Round(random.NextDouble(), 2);
            double rz = Math.Round(random.NextDouble(), 2);

            double rxm = rx + Math.Round(random.NextDouble(), 2);
            double rym = ry + Math.Round(random.NextDouble(), 2);
            double rzm = rz + Math.Round(random.NextDouble(), 2);

            double rstep = Math.Round(random.NextDouble(), 2);

            XtextBox.Text = rx.ToString();
            YtextBox.Text = ry.ToString();
            ZtextBox.Text = rz.ToString();
            MaxXtextBox.Text = rxm.ToString();
            MaxYtextBox.Text = rym.ToString();
            MaxZtextBox.Text = rzm.ToString();
            StepTextBox.Text = rstep.ToString();


            Graphs(sender, e);
        }

        private void Graphs(object sender, EventArgs e)
        {
            if (
                   XtextBox.Text.Length > 0 
                && MaxXtextBox.Text.Length > 0 
                && YtextBox.Text.Length > 0 
                && MaxYtextBox.Text.Length > 0 
                && ZtextBox.Text.Length > 0 
                && MaxZtextBox.Text.Length > 0 
                && StepTextBox.Text.Length > 0)
            {

                if
                    (
                           double.TryParse(XtextBox.Text.Replace(".", ","), out double x)
                        && double.TryParse(MaxXtextBox.Text.Replace(".", ","), out double xmax)
                        && double.TryParse(YtextBox.Text.Replace(".", ","), out double y)
                        && double.TryParse(MaxYtextBox.Text.Replace(".", ","), out double ymax)
                        && double.TryParse(ZtextBox.Text.Replace(".", ","), out double z)
                        && double.TryParse(MaxZtextBox.Text.Replace(".", ","), out double zmax)
                        && double.TryParse(StepTextBox.Text.Replace(".", ","), out double step)

                   )
                {
                    if (xmax > x && ymax > y && zmax > z && step > 0 && z > 0)
                    {
                        int count = (int)Math.Ceiling((xmax - x) / step) + 1;

                        double[] F = new double[count];
                        for (int i = 0; i < count; i++)
                        {
                            double currentx = x + step * i;
                            double currenty = y + step * i;
                            double currentz = z + step * i;

                            if (currentx != 0 && currenty != 0 && currentz != 0 && Math.Abs(currenty) < 20 && Math.Abs(currentx) < 20)
                            {
                                F[i] = 1 + Math.Pow(Math.Sin(currentx + currenty), 2) / currentx - (2 * currenty) / (1 + Math.Pow(currentx, 2) * Math.Pow(currentx, 2)) * Math.Pow(currentx, Math.Abs(currenty)) + Math.Pow(Math.Cos(Math.Atan(1 / currentz)), 2);
                            }
                            else
                            {
                                MessageBox.Show($"Значения на итерации {i} некорректны.");
                                return;
                            }
                        }
                        double[] point = new double[F.Length];
                        for (int i = 0; i < F.Length; i++)
                        {
                            point[i] = x + step * i;
                        }
                        chart1.Series[0].Points.DataBindXY(point, F);
                    }

                    else
                    {
                        MessageBox.Show("Значения не соответствуют требованиям");
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка ввода данных");
                }
            }
            else
            {
                return;
            }
        }
    }
}