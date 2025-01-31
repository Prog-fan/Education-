using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Tag
{
    public partial class MainForm : Form
    {
        private Button[,] buttons;
        private int emptyRow, emptyCol;
        private Random rand = new Random();
        private int moves;
        private Stopwatch stopwatch;
        private Label movesLabel;
        private Label timeLabel;
        private Button restartButton;
        private TableLayoutPanel tableLayoutPanel;
        private Timer timer;

        public MainForm()
        {
            InitializeComponents();
            InitializeGame();
        }

        private void InitializeComponents()
        {
            buttons = new Button[4, 4];
            tableLayoutPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 4,
                ColumnCount = 4
            };
            for (int i = 0; i < 4; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            }
            Controls.Add(tableLayoutPanel);

            movesLabel = new Label
            {
                Text = "Шаги: 0",
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter
            };
            Controls.Add(movesLabel);

            timeLabel = new Label
            {
                Text = "Время: 00:00",
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter
            };
            Controls.Add(timeLabel);

            restartButton = new Button
            {
                Text = "Restart",
                Dock = DockStyle.Bottom,
                Width = 100,
                Height = 20,
                BackColor = Color.LightGray,
            };
            restartButton.Click += RestartButton_Click;
            Controls.Add(restartButton);
            restartButton.Location = new Point(0, 0);

            timer = new Timer { Interval = 1000 };
            timer.Tick += Timer_Tick;
        }

        private void InitializeGame()
        {
            CreateButtons();
            Shuffle();
            moves = 0;
            stopwatch = new Stopwatch();
            stopwatch.Start();
            timer.Start();
        }

        private void CreateButtons()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    buttons[i, j] = new Button
                    {
                        Dock = DockStyle.Fill,
                        Text = (i * 4 + j + 1).ToString(),
                        BackColor = Color.BurlyWood,
                        Margin = new Padding(0),
                        Font = new Font(FontFamily.GenericSansSerif, 14, FontStyle.Bold)
                    };

                    buttons[i, j].Click += Button_Click;
                    tableLayoutPanel.Controls.Add(buttons[i, j], j, i);
                }
            }

            buttons[3, 3].Text = "";
            emptyRow = 3;
            emptyCol = 3;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int row = tableLayoutPanel.GetRow(button);
            int col = tableLayoutPanel.GetColumn(button);

            if (IsAdjacent(row, col, emptyRow, emptyCol))
            {
                buttons[emptyRow, emptyCol].Text = button.Text;
                button.Text = "";
                emptyRow = row;
                emptyCol = col;
                moves++;
                movesLabel.Text = "Шаги: " + moves;

                if (CheckWin())
                {
                    timer.Stop();
                    MessageBox.Show($"Вы победили за {stopwatch.Elapsed:mm\\:ss} минут, совершив {moves} шагов.", "Победа!");
                }
            }
        }

        private bool IsAdjacent(int row1, int col1, int row2, int col2)
        {
            return (Math.Abs(row1 - row2) == 1 && col1 == col2) ||
                   (Math.Abs(col1 - col2) == 1 && row1 == row2);
        }

        private void Shuffle()
        {
            for (int i = 0; i < 100; i++)
            {
                int r1 = rand.Next(4);
                int c1 = rand.Next(4);
                int r2 = rand.Next(4);
                int c2 = rand.Next(4);

                var temp = buttons[r1, c1].Text;
                buttons[r1, c1].Text = buttons[r2, c2].Text;
                buttons[r2, c2].Text = temp;

                if (buttons[r1, c1].Text == "")
                {
                    emptyRow = r1;
                    emptyCol = c1;
                }
                if (buttons[r2, c2].Text == "")
                {
                    emptyRow = r2;
                    emptyCol = c2;
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = "Время: " + stopwatch.Elapsed.ToString(@"mm\:ss");
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            Shuffle();
            moves = 0;
            movesLabel.Text = "Шаги: " + moves;
            stopwatch.Restart();
            timer.Start();
        }

        private bool CheckWin()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (buttons[i, j].Text != "" && buttons[i, j].Text != (i * 4 + j + 1).ToString())
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
