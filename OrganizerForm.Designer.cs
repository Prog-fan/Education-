using System;
using System.Windows.Forms;

namespace Organizer
{
    partial class OrganizerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SortingGroupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.AccountContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AccoutName = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitTool = new System.Windows.Forms.ToolStripMenuItem();
            this.AllEventRadioButton = new System.Windows.Forms.RadioButton();
            this.AllByCategoryRadioButton = new System.Windows.Forms.RadioButton();
            this.CategoryEventComboBox = new System.Windows.Forms.ComboBox();
            this.ListEventDataGrid = new System.Windows.Forms.DataGridView();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ChangeTool = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteTool = new System.Windows.Forms.ToolStripMenuItem();
            this.TimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TablePanel = new System.Windows.Forms.Panel();
            this.SortButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.AddEventButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SortingGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.AccountContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListEventDataGrid)).BeginInit();
            this.ContextMenu.SuspendLayout();
            this.TablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SortingGroupBox
            // 
            this.SortingGroupBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SortingGroupBox.Controls.Add(this.pictureBox2);
            this.SortingGroupBox.Controls.Add(this.AllEventRadioButton);
            this.SortingGroupBox.Controls.Add(this.AllByCategoryRadioButton);
            this.SortingGroupBox.Controls.Add(this.CategoryEventComboBox);
            this.SortingGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.SortingGroupBox.Location = new System.Drawing.Point(0, 0);
            this.SortingGroupBox.Name = "SortingGroupBox";
            this.SortingGroupBox.Size = new System.Drawing.Size(674, 77);
            this.SortingGroupBox.TabIndex = 0;
            this.SortingGroupBox.TabStop = false;
            this.SortingGroupBox.Text = "Вид";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.ContextMenuStrip = this.AccountContextMenu;
            this.pictureBox2.Image = global::Organizer.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(622, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // AccountContextMenu
            // 
            this.AccountContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AccoutName,
            this.ExitTool});
            this.AccountContextMenu.Name = "AccountContextMenu";
            this.AccountContextMenu.Size = new System.Drawing.Size(110, 48);
            // 
            // AccoutName
            // 
            this.AccoutName.Name = "AccoutName";
            this.AccoutName.Size = new System.Drawing.Size(109, 22);
            // 
            // ExitTool
            // 
            this.ExitTool.Name = "ExitTool";
            this.ExitTool.Size = new System.Drawing.Size(109, 22);
            this.ExitTool.Text = "Выйти";
            this.ExitTool.Click += new System.EventHandler(this.ExitTool_Click);
            // 
            // AllEventRadioButton
            // 
            this.AllEventRadioButton.AutoSize = true;
            this.AllEventRadioButton.Checked = true;
            this.AllEventRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllEventRadioButton.Location = new System.Drawing.Point(12, 37);
            this.AllEventRadioButton.Name = "AllEventRadioButton";
            this.AllEventRadioButton.Size = new System.Drawing.Size(106, 20);
            this.AllEventRadioButton.TabIndex = 4;
            this.AllEventRadioButton.TabStop = true;
            this.AllEventRadioButton.Text = "Все события";
            this.AllEventRadioButton.UseVisualStyleBackColor = true;
            // 
            // AllByCategoryRadioButton
            // 
            this.AllByCategoryRadioButton.AutoSize = true;
            this.AllByCategoryRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllByCategoryRadioButton.Location = new System.Drawing.Point(12, 14);
            this.AllByCategoryRadioButton.Name = "AllByCategoryRadioButton";
            this.AllByCategoryRadioButton.Size = new System.Drawing.Size(138, 20);
            this.AllByCategoryRadioButton.TabIndex = 3;
            this.AllByCategoryRadioButton.Text = "Все с категорией";
            this.AllByCategoryRadioButton.UseVisualStyleBackColor = true;
            this.AllByCategoryRadioButton.CheckedChanged += new System.EventHandler(this.LoadDataFromResource);
            // 
            // CategoryEventComboBox
            // 
            this.CategoryEventComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryEventComboBox.Enabled = false;
            this.CategoryEventComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryEventComboBox.FormattingEnabled = true;
            this.CategoryEventComboBox.Items.AddRange(new object[] {
            "Работа",
            "Здоровье",
            "Дом",
            "Путешествие",
            "Хобби"});
            this.CategoryEventComboBox.Location = new System.Drawing.Point(156, 12);
            this.CategoryEventComboBox.Name = "CategoryEventComboBox";
            this.CategoryEventComboBox.Size = new System.Drawing.Size(130, 24);
            this.CategoryEventComboBox.TabIndex = 2;
            this.CategoryEventComboBox.SelectedIndexChanged += new System.EventHandler(this.LoadDataFromResource);
            // 
            // ListEventDataGrid
            // 
            this.ListEventDataGrid.AllowUserToAddRows = false;
            this.ListEventDataGrid.AllowUserToResizeColumns = false;
            this.ListEventDataGrid.AllowUserToResizeRows = false;
            this.ListEventDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListEventDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListEventDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ListEventDataGrid.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.ListEventDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ListEventDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListEventDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ListEventDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListEventDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateColumn,
            this.TimeColumn,
            this.EventColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListEventDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.ListEventDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.ListEventDataGrid.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.ListEventDataGrid.Location = new System.Drawing.Point(0, 112);
            this.ListEventDataGrid.MultiSelect = false;
            this.ListEventDataGrid.Name = "ListEventDataGrid";
            this.ListEventDataGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListEventDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ListEventDataGrid.RowHeadersVisible = false;
            this.ListEventDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListEventDataGrid.Size = new System.Drawing.Size(674, 403);
            this.ListEventDataGrid.TabIndex = 2;
            // 
            // DateColumn
            // 
            this.DateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DateColumn.ContextMenuStrip = this.ContextMenu;
            this.DateColumn.FillWeight = 0.736241F;
            this.DateColumn.HeaderText = "Дата";
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.ReadOnly = true;
            this.DateColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DateColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DateColumn.Width = 45;
            // 
            // ContextMenu
            // 
            this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeTool,
            this.DeleteTool});
            this.ContextMenu.Name = "Cmenu";
            this.ContextMenu.Size = new System.Drawing.Size(129, 48);
            // 
            // ChangeTool
            // 
            this.ChangeTool.Name = "ChangeTool";
            this.ChangeTool.Size = new System.Drawing.Size(128, 22);
            this.ChangeTool.Text = "Изменить";
            this.ChangeTool.Click += new System.EventHandler(this.UpdateRow);
            // 
            // DeleteTool
            // 
            this.DeleteTool.Name = "DeleteTool";
            this.DeleteTool.Size = new System.Drawing.Size(128, 22);
            this.DeleteTool.Text = "Удалить";
            this.DeleteTool.Click += new System.EventHandler(this.DeleteSelectedRow);
            // 
            // TimeColumn
            // 
            this.TimeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TimeColumn.ContextMenuStrip = this.ContextMenu;
            this.TimeColumn.FillWeight = 14.49218F;
            this.TimeColumn.HeaderText = "Время";
            this.TimeColumn.Name = "TimeColumn";
            this.TimeColumn.ReadOnly = true;
            this.TimeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TimeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TimeColumn.Width = 54;
            // 
            // EventColumn
            // 
            this.EventColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EventColumn.ContextMenuStrip = this.ContextMenu;
            this.EventColumn.FillWeight = 284.7715F;
            this.EventColumn.HeaderText = "Событие";
            this.EventColumn.Name = "EventColumn";
            this.EventColumn.ReadOnly = true;
            this.EventColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EventColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TablePanel
            // 
            this.TablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablePanel.BackColor = System.Drawing.SystemColors.Window;
            this.TablePanel.Controls.Add(this.SortButton);
            this.TablePanel.Controls.Add(this.SearchTextBox);
            this.TablePanel.Controls.Add(this.AddEventButton);
            this.TablePanel.Controls.Add(this.pictureBox1);
            this.TablePanel.Location = new System.Drawing.Point(0, 77);
            this.TablePanel.Name = "TablePanel";
            this.TablePanel.Size = new System.Drawing.Size(674, 36);
            this.TablePanel.TabIndex = 3;
            // 
            // SortButton
            // 
            this.SortButton.BackgroundImage = global::Organizer.Properties.Resources.filters;
            this.SortButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SortButton.Location = new System.Drawing.Point(45, 3);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(36, 30);
            this.SortButton.TabIndex = 2;
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortByDate);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTextBox.Location = new System.Drawing.Point(507, 3);
            this.SearchTextBox.Multiline = true;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(155, 30);
            this.SearchTextBox.TabIndex = 1;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // AddEventButton
            // 
            this.AddEventButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AddEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddEventButton.Location = new System.Drawing.Point(3, 3);
            this.AddEventButton.Name = "AddEventButton";
            this.AddEventButton.Size = new System.Drawing.Size(36, 30);
            this.AddEventButton.TabIndex = 0;
            this.AddEventButton.Text = "+";
            this.AddEventButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AddEventButton.UseVisualStyleBackColor = true;
            this.AddEventButton.Click += new System.EventHandler(this.ShowAddEventForm);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Organizer.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(472, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // OrganizerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(674, 515);
            this.Controls.Add(this.TablePanel);
            this.Controls.Add(this.ListEventDataGrid);
            this.Controls.Add(this.SortingGroupBox);
            this.MinimumSize = new System.Drawing.Size(690, 554);
            this.Name = "OrganizerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Органайзер";
            this.Activated += new System.EventHandler(this.LoadDataFromResource);
            this.Load += new System.EventHandler(this.LoadDataFromResource);
            this.SortingGroupBox.ResumeLayout(false);
            this.SortingGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.AccountContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListEventDataGrid)).EndInit();
            this.ContextMenu.ResumeLayout(false);
            this.TablePanel.ResumeLayout(false);
            this.TablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SortingGroupBox;
        private System.Windows.Forms.DataGridView ListEventDataGrid;
        private System.Windows.Forms.ComboBox CategoryEventComboBox;
        private RadioButton AllEventRadioButton;
        private RadioButton AllByCategoryRadioButton;
        private Panel TablePanel;
        private Button AddEventButton;
        private new ContextMenuStrip ContextMenu;
        private ToolStripMenuItem ChangeTool;
        private ToolStripMenuItem DeleteTool;
        private DataGridViewTextBoxColumn DateColumn;
        private DataGridViewTextBoxColumn TimeColumn;
        private DataGridViewTextBoxColumn EventColumn;
        private TextBox SearchTextBox;
        private Button SortButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ContextMenuStrip AccountContextMenu;
        private ToolStripMenuItem AccoutName;
        private ToolStripMenuItem ExitTool;
    }
}