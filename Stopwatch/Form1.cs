using System;
using System.Windows.Forms;

namespace Stopwatch
{
    public partial class Stopwatch : Form
    {
        public Stopwatch()
        {
            InitializeComponent();
        }

        private void tmrSecundomer_Tick(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToString();

            int tmp = Int32.Parse(txtSeconds.Text); tmp++;
            txtSeconds.Text = tmp.ToString();

            if (txtSeconds.Text == "60")
            {
                txtSeconds.Text = "0";
                int tmm = Int32.Parse(txtMinutes.Text); tmm++;
                txtMinutes.Text = tmm.ToString();
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (tmrSecundomer.Enabled == true)
            {
                btnStart.Text = "Start";
                ClearButton.Enabled = true;
                tmrSecundomer.Enabled = false;
            }
            else
            {
                tmrSecundomer.Enabled = true;
                ClearButton.Enabled = false;
                btnStart.Text = "Stop";
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearButton.Enabled = false;
            txtMinutes.Text = "0";
            txtSeconds.Text = "0";
        }

        private void TimerButton_Click(object sender, EventArgs e)
        {
            Stopwatch.ActiveForm.Hide();
            Timer timer = new Timer();
            timer.ShowDialog();
            Close();
        }
    }
}
