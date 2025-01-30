using System.Drawing.Drawing2D;

namespace Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.panel = new System.Windows.Forms.TextBox();
            this.field = new System.Windows.Forms.TableLayoutPanel();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnFloat = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.ScienceModeButton = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnMultip = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnProcent = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.HistoryBar = new System.Windows.Forms.ListBox();
            this.FullScreenHistoryBar = new System.Windows.Forms.Label();
            this.IntermediateResultString = new System.Windows.Forms.TextBox();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnDeg = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.btnLn = new System.Windows.Forms.Button();
            this.btnClearC = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.StandartModeButton = new System.Windows.Forms.Button();
            this.btnPM = new System.Windows.Forms.Button();
            this.btnPow = new System.Windows.Forms.Button();
            this.bntlg = new System.Windows.Forms.Button();
            this.btnBracket = new System.Windows.Forms.Button();
            this.bthBrecket1 = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.fieldScience = new System.Windows.Forms.TableLayoutPanel();
            this.field.SuspendLayout();
            this.fieldScience.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panel.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.panel.ForeColor = System.Drawing.Color.Black;
            this.panel.HideSelection = false;
            this.panel.Location = new System.Drawing.Point(0, 31);
            this.panel.Name = "panel";
            this.panel.ReadOnly = true;
            this.panel.ShortcutsEnabled = false;
            this.panel.Size = new System.Drawing.Size(333, 24);
            this.panel.TabIndex = 0;
            this.panel.TabStop = false;
            this.panel.TextChanged += new System.EventHandler(this.Panel_TextChanged);
            this.panel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Panel_KeyPress);
            // 
            // field
            // 
            this.field.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.field.AutoSize = true;
            this.field.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.field.ColumnCount = 4;
            this.field.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.field.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.field.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.field.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.field.Controls.Add(this.btnEquals, 3, 4);
            this.field.Controls.Add(this.btnFloat, 2, 4);
            this.field.Controls.Add(this.btnZero, 1, 4);
            this.field.Controls.Add(this.ScienceModeButton, 0, 4);
            this.field.Controls.Add(this.btnPlus, 3, 3);
            this.field.Controls.Add(this.btnNine, 2, 3);
            this.field.Controls.Add(this.btnEight, 1, 3);
            this.field.Controls.Add(this.btnSeven, 0, 3);
            this.field.Controls.Add(this.btnMinus, 3, 2);
            this.field.Controls.Add(this.btnSix, 2, 2);
            this.field.Controls.Add(this.btnFive, 1, 2);
            this.field.Controls.Add(this.btnFour, 0, 2);
            this.field.Controls.Add(this.btnMultip, 3, 1);
            this.field.Controls.Add(this.btnThree, 2, 1);
            this.field.Controls.Add(this.btnTwo, 1, 1);
            this.field.Controls.Add(this.btnOne, 0, 1);
            this.field.Controls.Add(this.btnDivision, 3, 0);
            this.field.Controls.Add(this.btnProcent, 2, 0);
            this.field.Controls.Add(this.btnDel, 1, 0);
            this.field.Controls.Add(this.btnClear, 0, 0);
            this.field.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.field.Location = new System.Drawing.Point(0, 100);
            this.field.Name = "field";
            this.field.RowCount = 5;
            this.field.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.field.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.field.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.field.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.field.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.field.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.field.Size = new System.Drawing.Size(333, 297);
            this.field.TabIndex = 1;
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEquals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnEquals.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEquals.Location = new System.Drawing.Point(252, 239);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(78, 55);
            this.btnEquals.TabIndex = 19;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.ButtonEquals_Click);
            // 
            // btnFloat
            // 
            this.btnFloat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFloat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnFloat.Location = new System.Drawing.Point(169, 239);
            this.btnFloat.Name = "btnFloat";
            this.btnFloat.Size = new System.Drawing.Size(77, 55);
            this.btnFloat.TabIndex = 18;
            this.btnFloat.Text = ",";
            this.btnFloat.UseVisualStyleBackColor = true;
            this.btnFloat.Click += new System.EventHandler(this.OperandCals_Click);
            // 
            // btnZero
            // 
            this.btnZero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnZero.Location = new System.Drawing.Point(86, 239);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(77, 55);
            this.btnZero.TabIndex = 17;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.OperandCals_Click);
            // 
            // ScienceModeButton
            // 
            this.ScienceModeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScienceModeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.ScienceModeButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.ScienceModeButton.Location = new System.Drawing.Point(3, 239);
            this.ScienceModeButton.Name = "ScienceModeButton";
            this.ScienceModeButton.Size = new System.Drawing.Size(77, 55);
            this.ScienceModeButton.TabIndex = 16;
            this.ScienceModeButton.Text = "f";
            this.ScienceModeButton.UseVisualStyleBackColor = true;
            this.ScienceModeButton.Click += new System.EventHandler(this.BntF_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnPlus.ForeColor = System.Drawing.Color.Orange;
            this.btnPlus.Location = new System.Drawing.Point(252, 180);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(78, 53);
            this.btnPlus.TabIndex = 15;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.OperandCals_Click);
            // 
            // btnNine
            // 
            this.btnNine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnNine.Location = new System.Drawing.Point(169, 180);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(77, 53);
            this.btnNine.TabIndex = 14;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.OperandCals_Click);
            // 
            // btnEight
            // 
            this.btnEight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnEight.Location = new System.Drawing.Point(86, 180);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(77, 53);
            this.btnEight.TabIndex = 13;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.OperandCals_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnSeven.Location = new System.Drawing.Point(3, 180);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(77, 53);
            this.btnSeven.TabIndex = 12;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.OperandCals_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnMinus.ForeColor = System.Drawing.Color.Orange;
            this.btnMinus.Location = new System.Drawing.Point(252, 121);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(78, 53);
            this.btnMinus.TabIndex = 11;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.OperandCals_Click);
            // 
            // btnSix
            // 
            this.btnSix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnSix.Location = new System.Drawing.Point(169, 121);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(77, 53);
            this.btnSix.TabIndex = 10;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.OperandCals_Click);
            // 
            // btnFive
            // 
            this.btnFive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnFive.Location = new System.Drawing.Point(86, 121);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(77, 53);
            this.btnFive.TabIndex = 9;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.OperandCals_Click);
            // 
            // btnFour
            // 
            this.btnFour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnFour.Location = new System.Drawing.Point(3, 121);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(77, 53);
            this.btnFour.TabIndex = 8;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.OperandCals_Click);
            // 
            // btnMultip
            // 
            this.btnMultip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMultip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnMultip.ForeColor = System.Drawing.Color.Orange;
            this.btnMultip.Location = new System.Drawing.Point(252, 62);
            this.btnMultip.Name = "btnMultip";
            this.btnMultip.Size = new System.Drawing.Size(78, 53);
            this.btnMultip.TabIndex = 7;
            this.btnMultip.Text = "*";
            this.btnMultip.UseVisualStyleBackColor = true;
            this.btnMultip.Click += new System.EventHandler(this.OperandCals_Click);
            // 
            // btnThree
            // 
            this.btnThree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnThree.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnThree.Location = new System.Drawing.Point(169, 62);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(77, 53);
            this.btnThree.TabIndex = 6;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.OperandCals_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnTwo.Location = new System.Drawing.Point(86, 62);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(77, 53);
            this.btnTwo.TabIndex = 5;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.OperandCals_Click);
            // 
            // btnOne
            // 
            this.btnOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnOne.Location = new System.Drawing.Point(3, 62);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(77, 53);
            this.btnOne.TabIndex = 4;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.OperandCals_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnDivision.ForeColor = System.Drawing.Color.Orange;
            this.btnDivision.Location = new System.Drawing.Point(252, 3);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(78, 53);
            this.btnDivision.TabIndex = 3;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.OperandCals_Click);
            // 
            // btnProcent
            // 
            this.btnProcent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProcent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnProcent.ForeColor = System.Drawing.Color.Orange;
            this.btnProcent.Location = new System.Drawing.Point(169, 3);
            this.btnProcent.Name = "btnProcent";
            this.btnProcent.Size = new System.Drawing.Size(77, 53);
            this.btnProcent.TabIndex = 2;
            this.btnProcent.Text = "%";
            this.btnProcent.UseVisualStyleBackColor = true;
            this.btnProcent.Click += new System.EventHandler(this.MathOperation_Click);
            // 
            // btnDel
            // 
            this.btnDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnDel.ForeColor = System.Drawing.Color.Orange;
            this.btnDel.Location = new System.Drawing.Point(86, 3);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(77, 53);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "<<";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.DelChar_Click);
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnClear.ForeColor = System.Drawing.Color.Orange;
            this.btnClear.Location = new System.Drawing.Point(3, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(77, 53);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.ClearField_Click);
            // 
            // HistoryBar
            // 
            this.HistoryBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HistoryBar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.HistoryBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HistoryBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.HistoryBar.FormattingEnabled = true;
            this.HistoryBar.ItemHeight = 17;
            this.HistoryBar.Location = new System.Drawing.Point(0, 1);
            this.HistoryBar.Name = "HistoryBar";
            this.HistoryBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HistoryBar.Size = new System.Drawing.Size(304, 17);
            this.HistoryBar.TabIndex = 5;
            // 
            // FullScreenHistoryBar
            // 
            this.FullScreenHistoryBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FullScreenHistoryBar.AutoSize = true;
            this.FullScreenHistoryBar.Location = new System.Drawing.Point(314, 1);
            this.FullScreenHistoryBar.Name = "FullScreenHistoryBar";
            this.FullScreenHistoryBar.Size = new System.Drawing.Size(19, 13);
            this.FullScreenHistoryBar.TabIndex = 6;
            this.FullScreenHistoryBar.Text = "📜";
            this.FullScreenHistoryBar.Click += new System.EventHandler(this.BntFullListBox_Click);
            // 
            // IntermediateResultString
            // 
            this.IntermediateResultString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntermediateResultString.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.IntermediateResultString.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IntermediateResultString.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IntermediateResultString.Location = new System.Drawing.Point(12, 74);
            this.IntermediateResultString.Name = "IntermediateResultString";
            this.IntermediateResultString.ReadOnly = true;
            this.IntermediateResultString.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IntermediateResultString.Size = new System.Drawing.Size(309, 16);
            this.IntermediateResultString.TabIndex = 7;
            this.IntermediateResultString.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnTan
            // 
            this.btnTan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnTan.Location = new System.Drawing.Point(204, 3);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(57, 36);
            this.btnTan.TabIndex = 4;
            this.btnTan.Text = "tan";
            this.btnTan.UseVisualStyleBackColor = true;
            this.btnTan.Click += new System.EventHandler(this.MathOperation_Click);
            // 
            // btnDeg
            // 
            this.btnDeg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnDeg.Location = new System.Drawing.Point(267, 3);
            this.btnDeg.Name = "btnDeg";
            this.btnDeg.Size = new System.Drawing.Size(63, 36);
            this.btnDeg.TabIndex = 1;
            this.btnDeg.Text = "atan";
            this.btnDeg.UseVisualStyleBackColor = true;
            this.btnDeg.Click += new System.EventHandler(this.MathOperation_Click);
            // 
            // btnCos
            // 
            this.btnCos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnCos.Location = new System.Drawing.Point(135, 3);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(63, 36);
            this.btnCos.TabIndex = 3;
            this.btnCos.Text = "cos";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.MathOperation_Click);
            // 
            // btnSin
            // 
            this.btnSin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnSin.Location = new System.Drawing.Point(69, 3);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(60, 36);
            this.btnSin.TabIndex = 2;
            this.btnSin.Text = "sin";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.MathOperation_Click);
            // 
            // button18
            // 
            this.button18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button18.Location = new System.Drawing.Point(204, 213);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(57, 36);
            this.button18.TabIndex = 45;
            this.button18.Text = "9";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.OperandCals_Click);
            // 
            // button28
            // 
            this.button28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button28.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button28.Location = new System.Drawing.Point(204, 129);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(57, 36);
            this.button28.TabIndex = 37;
            this.button28.Text = "3";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.OperandCals_Click);
            // 
            // button19
            // 
            this.button19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button19.Location = new System.Drawing.Point(135, 213);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(63, 36);
            this.button19.TabIndex = 44;
            this.button19.Text = "8";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.OperandCals_Click);
            // 
            // button29
            // 
            this.button29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button29.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button29.Location = new System.Drawing.Point(135, 129);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(63, 36);
            this.button29.TabIndex = 36;
            this.button29.Text = "2";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.OperandCals_Click);
            // 
            // button20
            // 
            this.button20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button20.Location = new System.Drawing.Point(69, 213);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(60, 36);
            this.button20.TabIndex = 43;
            this.button20.Text = "7";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.OperandCals_Click);
            // 
            // button30
            // 
            this.button30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button30.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button30.Location = new System.Drawing.Point(69, 129);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(60, 36);
            this.button30.TabIndex = 35;
            this.button30.Text = "1";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.OperandCals_Click);
            // 
            // button13
            // 
            this.button13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button13.Location = new System.Drawing.Point(204, 255);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(57, 39);
            this.button13.TabIndex = 49;
            this.button13.Text = ",";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.OperandCals_Click);
            // 
            // button34
            // 
            this.button34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button34.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button34.ForeColor = System.Drawing.Color.DarkOrange;
            this.button34.Location = new System.Drawing.Point(135, 87);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(63, 36);
            this.button34.TabIndex = 32;
            this.button34.Text = "<<";
            this.button34.UseVisualStyleBackColor = true;
            this.button34.Click += new System.EventHandler(this.DelChar_Click);
            // 
            // button22
            // 
            this.button22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button22.ForeColor = System.Drawing.Color.DarkOrange;
            this.button22.Location = new System.Drawing.Point(267, 213);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(63, 36);
            this.button22.TabIndex = 42;
            this.button22.Text = "-";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.OperandCals_Click);
            // 
            // button17
            // 
            this.button17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button17.ForeColor = System.Drawing.Color.DarkOrange;
            this.button17.Location = new System.Drawing.Point(267, 171);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(63, 36);
            this.button17.TabIndex = 46;
            this.button17.Text = "+";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.OperandCals_Click);
            // 
            // button27
            // 
            this.button27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button27.ForeColor = System.Drawing.Color.DarkOrange;
            this.button27.Location = new System.Drawing.Point(267, 129);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(63, 36);
            this.button27.TabIndex = 38;
            this.button27.Text = "*";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.OperandCals_Click);
            // 
            // button32
            // 
            this.button32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button32.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button32.ForeColor = System.Drawing.Color.DarkOrange;
            this.button32.Location = new System.Drawing.Point(267, 87);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(63, 36);
            this.button32.TabIndex = 34;
            this.button32.Text = "/";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.OperandCals_Click);
            // 
            // btnLn
            // 
            this.btnLn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnLn.Location = new System.Drawing.Point(135, 45);
            this.btnLn.Name = "btnLn";
            this.btnLn.Size = new System.Drawing.Size(63, 36);
            this.btnLn.TabIndex = 30;
            this.btnLn.Text = "ln";
            this.btnLn.UseVisualStyleBackColor = true;
            this.btnLn.Click += new System.EventHandler(this.MathOperation_Click);
            // 
            // btnClearC
            // 
            this.btnClearC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnClearC.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnClearC.Location = new System.Drawing.Point(69, 87);
            this.btnClearC.Name = "btnClearC";
            this.btnClearC.Size = new System.Drawing.Size(60, 36);
            this.btnClearC.TabIndex = 31;
            this.btnClearC.Text = "C";
            this.btnClearC.UseVisualStyleBackColor = true;
            this.btnClearC.Click += new System.EventHandler(this.ClearField_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.DarkOrange;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button12.ForeColor = System.Drawing.SystemColors.Window;
            this.button12.Location = new System.Drawing.Point(267, 255);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(63, 39);
            this.button12.TabIndex = 50;
            this.button12.Text = "=";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.ButtonEquals_Click);
            // 
            // button23
            // 
            this.button23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button23.Location = new System.Drawing.Point(204, 171);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(57, 36);
            this.button23.TabIndex = 41;
            this.button23.Text = "6";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.OperandCals_Click);
            // 
            // button24
            // 
            this.button24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button24.Location = new System.Drawing.Point(135, 171);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(63, 36);
            this.button24.TabIndex = 40;
            this.button24.Text = "5";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.OperandCals_Click);
            // 
            // button25
            // 
            this.button25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button25.Location = new System.Drawing.Point(69, 171);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(60, 36);
            this.button25.TabIndex = 39;
            this.button25.Text = "4";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.OperandCals_Click);
            // 
            // button14
            // 
            this.button14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button14.Location = new System.Drawing.Point(135, 255);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(63, 39);
            this.button14.TabIndex = 48;
            this.button14.Text = "0";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.OperandCals_Click);
            // 
            // button33
            // 
            this.button33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button33.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button33.ForeColor = System.Drawing.Color.DarkOrange;
            this.button33.Location = new System.Drawing.Point(204, 87);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(57, 36);
            this.button33.TabIndex = 33;
            this.button33.Text = "%";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.MathOperation_Click);
            // 
            // StandartModeButton
            // 
            this.StandartModeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StandartModeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.StandartModeButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.StandartModeButton.Location = new System.Drawing.Point(3, 255);
            this.StandartModeButton.Name = "StandartModeButton";
            this.StandartModeButton.Size = new System.Drawing.Size(60, 39);
            this.StandartModeButton.TabIndex = 47;
            this.StandartModeButton.Text = "f";
            this.StandartModeButton.UseVisualStyleBackColor = true;
            this.StandartModeButton.Click += new System.EventHandler(this.BntF_Click);
            // 
            // btnPM
            // 
            this.btnPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnPM.Location = new System.Drawing.Point(3, 3);
            this.btnPM.Name = "btnPM";
            this.btnPM.Size = new System.Drawing.Size(60, 36);
            this.btnPM.TabIndex = 0;
            this.btnPM.Text = "±";
            this.btnPM.UseVisualStyleBackColor = true;
            this.btnPM.Click += new System.EventHandler(this.MathOperation_Click);
            // 
            // btnPow
            // 
            this.btnPow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnPow.Location = new System.Drawing.Point(3, 45);
            this.btnPow.Name = "btnPow";
            this.btnPow.Size = new System.Drawing.Size(60, 36);
            this.btnPow.TabIndex = 5;
            this.btnPow.Text = "Xⁿ";
            this.btnPow.UseVisualStyleBackColor = true;
            this.btnPow.Click += new System.EventHandler(this.MathOperation_Click);
            // 
            // bntlg
            // 
            this.bntlg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bntlg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.bntlg.Location = new System.Drawing.Point(69, 45);
            this.bntlg.Name = "bntlg";
            this.bntlg.Size = new System.Drawing.Size(60, 36);
            this.bntlg.TabIndex = 6;
            this.bntlg.Text = "lg";
            this.bntlg.UseVisualStyleBackColor = true;
            this.bntlg.Click += new System.EventHandler(this.MathOperation_Click);
            // 
            // btnBracket
            // 
            this.btnBracket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnBracket.Location = new System.Drawing.Point(204, 45);
            this.btnBracket.Name = "btnBracket";
            this.btnBracket.Size = new System.Drawing.Size(57, 36);
            this.btnBracket.TabIndex = 8;
            this.btnBracket.Text = "(";
            this.btnBracket.UseVisualStyleBackColor = true;
            this.btnBracket.Click += new System.EventHandler(this.OperandCals_Click);
            // 
            // bthBrecket1
            // 
            this.bthBrecket1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bthBrecket1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.bthBrecket1.Location = new System.Drawing.Point(267, 45);
            this.bthBrecket1.Name = "bthBrecket1";
            this.bthBrecket1.Size = new System.Drawing.Size(63, 36);
            this.bthBrecket1.TabIndex = 9;
            this.bthBrecket1.Text = ")";
            this.bthBrecket1.UseVisualStyleBackColor = true;
            this.bthBrecket1.Click += new System.EventHandler(this.OperandCals_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnSqrt.Location = new System.Drawing.Point(3, 87);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(60, 36);
            this.btnSqrt.TabIndex = 10;
            this.btnSqrt.Text = "√";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.MathOperation_Click);
            // 
            // button16
            // 
            this.button16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button16.Location = new System.Drawing.Point(3, 129);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(60, 36);
            this.button16.TabIndex = 15;
            this.button16.Text = "X!";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.MathOperation_Click);
            // 
            // button21
            // 
            this.button21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button21.Location = new System.Drawing.Point(3, 171);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(60, 36);
            this.button21.TabIndex = 20;
            this.button21.Text = "1/X";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.MathOperation_Click);
            // 
            // button26
            // 
            this.button26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button26.Location = new System.Drawing.Point(3, 213);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(60, 36);
            this.button26.TabIndex = 25;
            this.button26.Text = "Pi";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.MathOperation_Click);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button8.Location = new System.Drawing.Point(69, 255);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 39);
            this.button8.TabIndex = 7;
            this.button8.Text = "e";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.MathOperation_Click);
            // 
            // fieldScience
            // 
            this.fieldScience.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fieldScience.ColumnCount = 5;
            this.fieldScience.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.fieldScience.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.fieldScience.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.72072F));
            this.fieldScience.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.91892F));
            this.fieldScience.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.fieldScience.Controls.Add(this.button8, 1, 6);
            this.fieldScience.Controls.Add(this.button26, 0, 5);
            this.fieldScience.Controls.Add(this.button21, 0, 4);
            this.fieldScience.Controls.Add(this.button16, 0, 3);
            this.fieldScience.Controls.Add(this.btnSqrt, 0, 2);
            this.fieldScience.Controls.Add(this.bthBrecket1, 4, 1);
            this.fieldScience.Controls.Add(this.btnBracket, 3, 1);
            this.fieldScience.Controls.Add(this.bntlg, 1, 1);
            this.fieldScience.Controls.Add(this.btnPow, 0, 1);
            this.fieldScience.Controls.Add(this.btnPM, 0, 0);
            this.fieldScience.Controls.Add(this.StandartModeButton, 0, 6);
            this.fieldScience.Controls.Add(this.button33, 3, 2);
            this.fieldScience.Controls.Add(this.button14, 2, 6);
            this.fieldScience.Controls.Add(this.button25, 1, 4);
            this.fieldScience.Controls.Add(this.button24, 2, 4);
            this.fieldScience.Controls.Add(this.button23, 3, 4);
            this.fieldScience.Controls.Add(this.button12, 4, 6);
            this.fieldScience.Controls.Add(this.btnClearC, 1, 2);
            this.fieldScience.Controls.Add(this.btnLn, 2, 1);
            this.fieldScience.Controls.Add(this.button32, 4, 2);
            this.fieldScience.Controls.Add(this.button27, 4, 3);
            this.fieldScience.Controls.Add(this.button17, 4, 4);
            this.fieldScience.Controls.Add(this.button22, 4, 5);
            this.fieldScience.Controls.Add(this.button34, 2, 2);
            this.fieldScience.Controls.Add(this.button13, 3, 6);
            this.fieldScience.Controls.Add(this.button30, 1, 3);
            this.fieldScience.Controls.Add(this.button20, 1, 5);
            this.fieldScience.Controls.Add(this.button29, 2, 3);
            this.fieldScience.Controls.Add(this.button19, 2, 5);
            this.fieldScience.Controls.Add(this.button28, 3, 3);
            this.fieldScience.Controls.Add(this.button18, 3, 5);
            this.fieldScience.Controls.Add(this.btnSin, 1, 0);
            this.fieldScience.Controls.Add(this.btnCos, 2, 0);
            this.fieldScience.Controls.Add(this.btnDeg, 4, 0);
            this.fieldScience.Controls.Add(this.btnTan, 3, 0);
            this.fieldScience.Location = new System.Drawing.Point(0, 100);
            this.fieldScience.Name = "fieldScience";
            this.fieldScience.RowCount = 7;
            this.fieldScience.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.2853F));
            this.fieldScience.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.fieldScience.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.fieldScience.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.fieldScience.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.fieldScience.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.fieldScience.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28816F));
            this.fieldScience.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.fieldScience.Size = new System.Drawing.Size(333, 297);
            this.fieldScience.TabIndex = 4;
            this.fieldScience.Visible = false;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(333, 399);
            this.Controls.Add(this.FullScreenHistoryBar);
            this.Controls.Add(this.HistoryBar);
            this.Controls.Add(this.fieldScience);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.IntermediateResultString);
            this.Controls.Add(this.field);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(349, 438);
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Culculator";
            this.field.ResumeLayout(false);
            this.fieldScience.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox panel;
        private System.Windows.Forms.TableLayoutPanel field;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button ScienceModeButton;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnFloat;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnMultip;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnProcent;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.ListBox HistoryBar;
        private System.Windows.Forms.Label FullScreenHistoryBar;
        private System.Windows.Forms.TextBox IntermediateResultString;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnDeg;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button btnLn;
        private System.Windows.Forms.Button btnClearC;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button StandartModeButton;
        private System.Windows.Forms.Button btnPM;
        private System.Windows.Forms.Button btnPow;
        private System.Windows.Forms.Button bntlg;
        private System.Windows.Forms.Button btnBracket;
        private System.Windows.Forms.Button bthBrecket1;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TableLayoutPanel fieldScience;
    }
}

