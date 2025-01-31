namespace Railroad_ticket
{
    partial class Form1
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
            this.resultDataGrid = new System.Windows.Forms.DataGridView();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeWagonColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumOfticketscolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumOfDisTicketsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuggageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddictionalServiceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBedding = new System.Windows.Forms.CheckBox();
            this.checkNutrition = new System.Windows.Forms.CheckBox();
            this.checkLuggage = new System.Windows.Forms.CheckBox();
            this.comboFlight = new System.Windows.Forms.ComboBox();
            this.comboTypeWagon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numPassengers = new System.Windows.Forms.NumericUpDown();
            this.numPassengersWithBenefits = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addRecordButton = new System.Windows.Forms.Button();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.dellRecordButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPassengers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPassengersWithBenefits)).BeginInit();
            this.SuspendLayout();
            // 
            // resultDataGrid
            // 
            this.resultDataGrid.AllowUserToAddRows = false;
            this.resultDataGrid.AllowUserToDeleteRows = false;
            this.resultDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.resultDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.resultDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateColumn,
            this.FlightColumn,
            this.TypeWagonColumn,
            this.NumOfticketscolumn,
            this.NumOfDisTicketsColumn,
            this.LuggageColumn,
            this.AddictionalServiceColumn,
            this.TotalCostColumn});
            this.resultDataGrid.Location = new System.Drawing.Point(12, 236);
            this.resultDataGrid.Name = "resultDataGrid";
            this.resultDataGrid.ReadOnly = true;
            this.resultDataGrid.RowHeadersVisible = false;
            this.resultDataGrid.Size = new System.Drawing.Size(542, 218);
            this.resultDataGrid.TabIndex = 0;
            // 
            // DateColumn
            // 
            this.DateColumn.HeaderText = "Дата";
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.ReadOnly = true;
            // 
            // FlightColumn
            // 
            this.FlightColumn.HeaderText = "Рейс";
            this.FlightColumn.Name = "FlightColumn";
            this.FlightColumn.ReadOnly = true;
            // 
            // TypeWagonColumn
            // 
            this.TypeWagonColumn.HeaderText = "Тип вагона";
            this.TypeWagonColumn.Name = "TypeWagonColumn";
            this.TypeWagonColumn.ReadOnly = true;
            // 
            // NumOfticketscolumn
            // 
            this.NumOfticketscolumn.FillWeight = 80F;
            this.NumOfticketscolumn.HeaderText = "Билеты";
            this.NumOfticketscolumn.Name = "NumOfticketscolumn";
            this.NumOfticketscolumn.ReadOnly = true;
            // 
            // NumOfDisTicketsColumn
            // 
            this.NumOfDisTicketsColumn.HeaderText = "льготные билеты";
            this.NumOfDisTicketsColumn.Name = "NumOfDisTicketsColumn";
            this.NumOfDisTicketsColumn.ReadOnly = true;
            // 
            // LuggageColumn
            // 
            this.LuggageColumn.FillWeight = 80F;
            this.LuggageColumn.HeaderText = "Багаж";
            this.LuggageColumn.Name = "LuggageColumn";
            this.LuggageColumn.ReadOnly = true;
            this.LuggageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // AddictionalServiceColumn
            // 
            this.AddictionalServiceColumn.FillWeight = 150F;
            this.AddictionalServiceColumn.HeaderText = "Дополнительные услуги";
            this.AddictionalServiceColumn.Name = "AddictionalServiceColumn";
            this.AddictionalServiceColumn.ReadOnly = true;
            this.AddictionalServiceColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AddictionalServiceColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TotalCostColumn
            // 
            this.TotalCostColumn.HeaderText = "Итоговая стоимость";
            this.TotalCostColumn.Name = "TotalCostColumn";
            this.TotalCostColumn.ReadOnly = true;
            this.TotalCostColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TotalCostColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBedding);
            this.groupBox1.Controls.Add(this.checkNutrition);
            this.groupBox1.Controls.Add(this.checkLuggage);
            this.groupBox1.Location = new System.Drawing.Point(354, 12);
            this.groupBox1.MinimumSize = new System.Drawing.Size(187, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 146);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Доп.услуги";
            // 
            // checkBedding
            // 
            this.checkBedding.AutoSize = true;
            this.checkBedding.Location = new System.Drawing.Point(7, 68);
            this.checkBedding.Name = "checkBedding";
            this.checkBedding.Size = new System.Drawing.Size(57, 17);
            this.checkBedding.TabIndex = 2;
            this.checkBedding.Text = "Белье";
            this.checkBedding.UseVisualStyleBackColor = true;
            // 
            // checkNutrition
            // 
            this.checkNutrition.AutoSize = true;
            this.checkNutrition.Location = new System.Drawing.Point(7, 44);
            this.checkNutrition.Name = "checkNutrition";
            this.checkNutrition.Size = new System.Drawing.Size(69, 17);
            this.checkNutrition.TabIndex = 1;
            this.checkNutrition.Text = "Питание";
            this.checkNutrition.UseVisualStyleBackColor = true;
            // 
            // checkLuggage
            // 
            this.checkLuggage.AutoSize = true;
            this.checkLuggage.Location = new System.Drawing.Point(7, 20);
            this.checkLuggage.Name = "checkLuggage";
            this.checkLuggage.Size = new System.Drawing.Size(58, 17);
            this.checkLuggage.TabIndex = 0;
            this.checkLuggage.Text = "Багаж";
            this.checkLuggage.UseVisualStyleBackColor = true;
            // 
            // comboFlight
            // 
            this.comboFlight.FormattingEnabled = true;
            this.comboFlight.Items.AddRange(new object[] {
            "Екатеринбург - Пермь",
            "Екатеринбург - Тюмень",
            "Екатеринбург - Казань",
            "Екатеринбург - Новосибирск",
            "Екатеринбург - Москва"});
            this.comboFlight.Location = new System.Drawing.Point(9, 137);
            this.comboFlight.Name = "comboFlight";
            this.comboFlight.Size = new System.Drawing.Size(179, 21);
            this.comboFlight.TabIndex = 2;
            // 
            // comboTypeWagon
            // 
            this.comboTypeWagon.FormattingEnabled = true;
            this.comboTypeWagon.Items.AddRange(new object[] {
            "Плацкарт",
            "Сидячий",
            "Купе",
            "СВ"});
            this.comboTypeWagon.Location = new System.Drawing.Point(194, 137);
            this.comboTypeWagon.Name = "comboTypeWagon";
            this.comboTypeWagon.Size = new System.Drawing.Size(121, 21);
            this.comboTypeWagon.TabIndex = 3;
            this.comboTypeWagon.SelectedIndexChanged += new System.EventHandler(this.comboTypeWagon_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Колличество пассажиров";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пассажиры с льготами";
            // 
            // numPassengers
            // 
            this.numPassengers.Location = new System.Drawing.Point(155, 7);
            this.numPassengers.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numPassengers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPassengers.Name = "numPassengers";
            this.numPassengers.Size = new System.Drawing.Size(49, 20);
            this.numPassengers.TabIndex = 6;
            this.numPassengers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numPassengersWithBenefits
            // 
            this.numPassengersWithBenefits.Location = new System.Drawing.Point(155, 33);
            this.numPassengersWithBenefits.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numPassengersWithBenefits.Name = "numPassengersWithBenefits";
            this.numPassengersWithBenefits.Size = new System.Drawing.Size(49, 20);
            this.numPassengersWithBenefits.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Рейс";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Тип вагона";
            // 
            // addRecordButton
            // 
            this.addRecordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addRecordButton.Location = new System.Drawing.Point(479, 460);
            this.addRecordButton.Name = "addRecordButton";
            this.addRecordButton.Size = new System.Drawing.Size(75, 23);
            this.addRecordButton.TabIndex = 10;
            this.addRecordButton.Text = "Добавить";
            this.addRecordButton.UseVisualStyleBackColor = true;
            this.addRecordButton.Click += new System.EventHandler(this.addRecordButton_Click);
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(12, 77);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(200, 20);
            this.dateTime.TabIndex = 11;
            // 
            // dellRecordButton
            // 
            this.dellRecordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dellRecordButton.Location = new System.Drawing.Point(398, 460);
            this.dellRecordButton.Name = "dellRecordButton";
            this.dellRecordButton.Size = new System.Drawing.Size(75, 23);
            this.dellRecordButton.TabIndex = 12;
            this.dellRecordButton.Text = "удалить";
            this.dellRecordButton.UseVisualStyleBackColor = true;
            this.dellRecordButton.Click += new System.EventHandler(this.dellRecordButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 490);
            this.Controls.Add(this.dellRecordButton);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.addRecordButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numPassengersWithBenefits);
            this.Controls.Add(this.numPassengers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboTypeWagon);
            this.Controls.Add(this.comboFlight);
            this.Controls.Add(this.resultDataGrid);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(582, 529);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Railroad_ticket";
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPassengers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPassengersWithBenefits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView resultDataGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkNutrition;
        private System.Windows.Forms.CheckBox checkLuggage;
        private System.Windows.Forms.ComboBox comboFlight;
        private System.Windows.Forms.ComboBox comboTypeWagon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numPassengers;
        private System.Windows.Forms.NumericUpDown numPassengersWithBenefits;
        private System.Windows.Forms.CheckBox checkBedding;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addRecordButton;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeWagonColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumOfticketscolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumOfDisTicketsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuggageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddictionalServiceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCostColumn;
        private System.Windows.Forms.Button dellRecordButton;
    }
}

