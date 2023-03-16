namespace MatchStat.UI
{
    partial class FieldsWindow
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            stadiumTextBox = new TextBox();
            fieldBindingSource = new BindingSource(components);
            countryTextBox = new TextBox();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            deleteButton = new Button();
            createButton = new Button();
            ((System.ComponentModel.ISupportInitialize)fieldBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 34);
            label1.TabIndex = 0;
            label1.Text = "Stadium Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(3, 34);
            label2.Name = "label2";
            label2.Size = new Size(148, 34);
            label2.TabIndex = 1;
            label2.Text = "Country :";
            // 
            // stadiumTextBox
            // 
            stadiumTextBox.Dock = DockStyle.Fill;
            stadiumTextBox.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            stadiumTextBox.Location = new Point(157, 3);
            stadiumTextBox.Name = "stadiumTextBox";
            stadiumTextBox.Size = new Size(485, 26);
            stadiumTextBox.TabIndex = 2;
            // 
            // fieldBindingSource
            // 
            fieldBindingSource.DataSource = typeof(DataModel.DataModels.Fields);
            // 
            // countryTextBox
            // 
            countryTextBox.Dock = DockStyle.Fill;
            countryTextBox.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            countryTextBox.Location = new Point(157, 37);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(485, 26);
            countryTextBox.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(128, 255, 255);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, countryDataGridViewTextBoxColumn });
            dataGridView1.DataSource = fieldBindingSource;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(645, 331);
            dataGridView1.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.Frozen = true;
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 55;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // countryDataGridViewTextBoxColumn
            // 
            countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            countryDataGridViewTextBoxColumn.HeaderText = "Country";
            countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.91657F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.08343F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(stadiumTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(countryTextBox, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(645, 68);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deleteButton.Font = new Font("Times New Roman", 14F, FontStyle.Italic, GraphicsUnit.Point);
            deleteButton.Location = new Point(519, 71);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(126, 31);
            deleteButton.TabIndex = 11;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // createButton
            // 
            createButton.Font = new Font("Times New Roman", 14F, FontStyle.Italic, GraphicsUnit.Point);
            createButton.Location = new Point(3, 71);
            createButton.Name = "createButton";
            createButton.Size = new Size(125, 31);
            createButton.TabIndex = 10;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = true;
            // 
            // FieldsWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(645, 434);
            Controls.Add(deleteButton);
            Controls.Add(createButton);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dataGridView1);
            Location = new Point(592, 400);
            MinimumSize = new Size(661, 473);
            Name = "FieldsWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Field";
            Load += Field_Load;
            ((System.ComponentModel.ISupportInitialize)fieldBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox stadiumTextBox;
        private TextBox countryTextBox;
        private DataGridView dataGridView1;
        private BindingSource fieldBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private TableLayoutPanel tableLayoutPanel1;
        private Button deleteButton;
        private Button createButton;
    }
}