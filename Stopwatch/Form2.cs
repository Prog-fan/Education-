using System;
using System.Media;
using System.Windows.Forms;

namespace Stopwatch
{
    public partial class Timer : Form
    {
        string timerStop = "D:\\work\\sounds\\timer-bell_m1tycbno.wav";
        public Timer()
        {
            InitializeComponent();
        }

        private void tmrSecundomer_Tick(object sender, EventArgs e)
        {
            if (txtHour.Text != "0" || txtMinutes.Text != "0" || txtSeconds.Text != "0")
            {
                if(txtHour.Text != "0" && txtMinutes.Text == "0" && txtSeconds.Text == "0")
                {
                    int tmp = Int32.Parse(txtHour.Text);
                    if (tmp > 59) { tmp = 59; }

                    if (tmp > 0)
                    { 
                        tmp--;
                        txtHour.Text = tmp.ToString();
                        txtMinutes.Text = "59";
                        txtSeconds.Text = "59";
                      
                    }
                }  
                
                if (txtSeconds.Text == "0" && txtMinutes.Text != "0")
                {
                    int tmp = Int32.Parse(txtMinutes.Text);
                    if (tmp > 59) { tmp = 59; }
                    
                    if (tmp > 0)
                    {
                        txtSeconds.Text = "59";
                        tmp--;
                        txtMinutes.Text = tmp.ToString();
                    }
                }

                if (txtMinutes.Text == "0" || txtSeconds.Text != "0")
                {
                    int tmp = Int32.Parse(txtSeconds.Text);
                    if(tmp > 59) { tmp = 59; }

                    if (tmp > 0)
                    {
                        tmp--;
                        txtSeconds.Text = tmp.ToString();
                    }
                }

              

                if (txtSeconds.Text == "0" && txtMinutes.Text == "0" && txtHour.Text == "0")
                {
                    SoundPlayer soundPlayer = new SoundPlayer(timerStop);
                    soundPlayer.Play();
                }
            }
        }

        private void btnStart_Click_1(object sender, EventArgs e)
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
        
        private void OpenFormButton_Click(object sender, EventArgs e)
        {
            Timer.ActiveForm.Hide();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.ShowDialog();
            Close();
        }
    }
}
