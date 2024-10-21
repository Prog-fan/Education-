namespace Stopwatch
{
    partial class Stopwatch
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.tmrSecundomer = new System.Windows.Forms.Timer(this.components);
            this.ClearButton = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.TimerButton = new System.Windows.Forms.Button();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnStart.Location = new System.Drawing.Point(171, 204);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 45);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(80, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(241, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "sec";
            // 
            // txtSeconds
            // 
            this.txtSeconds.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtSeconds.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtSeconds.Location = new System.Drawing.Point(174, 83);
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.ReadOnly = true;
            this.txtSeconds.ShortcutsEnabled = false;
            this.txtSeconds.Size = new System.Drawing.Size(61, 30);
            this.txtSeconds.TabIndex = 1;
            this.txtSeconds.Text = "0";
            this.txtSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tmrSecundomer
            // 
            this.tmrSecundomer.Interval = 1000;
            this.tmrSecundomer.Tick += new System.EventHandler(this.tmrSecundomer_Tick);
            // 
            // ClearButton
            // 
            this.ClearButton.Enabled = false;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ClearButton.Location = new System.Drawing.Point(12, 204);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(100, 45);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(86, 9);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(0, 13);
            this.DateLabel.TabIndex = 6;
            // 
            // TimerButton
            // 
            this.TimerButton.Location = new System.Drawing.Point(271, -2);
            this.TimerButton.Name = "TimerButton";
            this.TimerButton.Size = new System.Drawing.Size(14, 23);
            this.TimerButton.TabIndex = 7;
            this.TimerButton.Text = "Timer";
            this.TimerButton.UseVisualStyleBackColor = true;
            this.TimerButton.Click += new System.EventHandler(this.TimerButton_Click);
            // 
            // txtMinutes
            // 
            this.txtMinutes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtMinutes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtMinutes.Location = new System.Drawing.Point(12, 81);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.ReadOnly = true;
            this.txtMinutes.ShortcutsEnabled = false;
            this.txtMinutes.Size = new System.Drawing.Size(61, 30);
            this.txtMinutes.TabIndex = 0;
            this.txtMinutes.Text = "0";
            this.txtMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Stopwatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtMinutes);
            this.Controls.Add(this.TimerButton);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.txtSeconds);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Stopwatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stopwatch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSeconds;
        private System.Windows.Forms.Timer tmrSecundomer;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Button TimerButton;
        private System.Windows.Forms.TextBox txtMinutes;
    }
}

