namespace Stopwatch
{
    partial class Timer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.OpenFormButton = new System.Windows.Forms.Button();
            this.tmrSecundomer = new System.Windows.Forms.Timer(this.components);
            this.txtMinutes = new System.Windows.Forms.NumericUpDown();
            this.txtSeconds = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHour = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHour)).BeginInit();
            this.SuspendLayout();
            // 
            // ClearButton
            // 
            this.ClearButton.Enabled = false;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ClearButton.Location = new System.Drawing.Point(12, 204);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(100, 45);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(242, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "sec";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(144, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "min";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnStart.Location = new System.Drawing.Point(172, 204);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 45);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // OpenFormButton
            // 
            this.OpenFormButton.Location = new System.Drawing.Point(270, -2);
            this.OpenFormButton.Name = "OpenFormButton";
            this.OpenFormButton.Size = new System.Drawing.Size(16, 23);
            this.OpenFormButton.TabIndex = 14;
            this.OpenFormButton.Text = "Stopwatch";
            this.OpenFormButton.UseVisualStyleBackColor = true;
            this.OpenFormButton.Click += new System.EventHandler(this.OpenFormButton_Click);
            // 
            // tmrSecundomer
            // 
            this.tmrSecundomer.Interval = 1000;
            this.tmrSecundomer.Tick += new System.EventHandler(this.tmrSecundomer_Tick);
            // 
            // txtMinutes
            // 
            this.txtMinutes.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtMinutes.Location = new System.Drawing.Point(95, 100);
            this.txtMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.ReadOnly = true;
            this.txtMinutes.Size = new System.Drawing.Size(45, 30);
            this.txtMinutes.TabIndex = 1;
            this.txtMinutes.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // txtSeconds
            // 
            this.txtSeconds.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtSeconds.Location = new System.Drawing.Point(188, 100);
            this.txtSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.ReadOnly = true;
            this.txtSeconds.Size = new System.Drawing.Size(45, 30);
            this.txtSeconds.TabIndex = 0;
            this.txtSeconds.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(58, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "hr";
            // 
            // txtHour
            // 
            this.txtHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtHour.Location = new System.Drawing.Point(12, 100);
            this.txtHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.txtHour.Name = "txtHour";
            this.txtHour.ReadOnly = true;
            this.txtHour.Size = new System.Drawing.Size(45, 30);
            this.txtHour.TabIndex = 2;
            this.txtHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHour.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHour);
            this.Controls.Add(this.txtSeconds);
            this.Controls.Add(this.txtMinutes);
            this.Controls.Add(this.OpenFormButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Timer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer";
            ((System.ComponentModel.ISupportInitialize)(this.txtMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button OpenFormButton;
        private System.Windows.Forms.Timer tmrSecundomer;
        private System.Windows.Forms.NumericUpDown txtMinutes;
        private System.Windows.Forms.NumericUpDown txtSeconds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtHour;
    }
}