namespace MatchStat.UI
{
    partial class TournamentStatisticsWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tournamentName = new TextBox();
            tournamentBindingSource = new BindingSource(components);
            label2 = new Label();
            label3 = new Label();
            startDate = new DateTimePicker();
            endDate = new DateTimePicker();
            label4 = new Label();
            createButton = new Button();
            deleteButton = new Button();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)tournamentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tournamentName
            // 
            tournamentName.Dock = DockStyle.Fill;
            tournamentName.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentName.Location = new Point(128, 3);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(542, 30);
            tournamentName.TabIndex = 1;
            // 
            // tournamentBindingSource
            // 
            tournamentBindingSource.DataSource = typeof(DataModel.DataModels.Tournament);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Times New Roman", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 33);
            label2.TabIndex = 2;
            label2.Text = "Name :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 33);
            label3.Name = "label3";
            label3.Size = new Size(119, 33);
            label3.TabIndex = 4;
            label3.Text = "Start Date :";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // startDate
            // 
            startDate.DataBindings.Add(new Binding("Value", tournamentBindingSource, "StartDate", true));
            startDate.Dock = DockStyle.Fill;
            startDate.Font = new Font("Times New Roman", 10F, FontStyle.Italic, GraphicsUnit.Point);
            startDate.Location = new Point(128, 36);
            startDate.Name = "startDate";
            startDate.Size = new Size(542, 23);
            startDate.TabIndex = 5;
            // 
            // endDate
            // 
            endDate.DataBindings.Add(new Binding("Value", tournamentBindingSource, "EndDate", true));
            endDate.Dock = DockStyle.Fill;
            endDate.Font = new Font("Times New Roman", 10F, FontStyle.Italic, GraphicsUnit.Point);
            endDate.Location = new Point(128, 69);
            endDate.Name = "endDate";
            endDate.Size = new Size(542, 23);
            endDate.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 66);
            label4.Name = "label4";
            label4.Size = new Size(119, 34);
            label4.TabIndex = 6;
            label4.Text = "End Date :";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // createButton
            // 
            createButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            createButton.BackColor = SystemColors.ActiveCaptionText;
            createButton.Font = new Font("Times New Roman", 13.25F, FontStyle.Bold, GraphicsUnit.Point);
            createButton.ForeColor = SystemColors.Control;
            createButton.Location = new Point(676, -1);
            createButton.Name = "createButton";
            createButton.Size = new Size(124, 72);
            createButton.TabIndex = 8;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = false;
            createButton.Click += createButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deleteButton.BackColor = SystemColors.ActiveCaptionText;
            deleteButton.BackgroundImageLayout = ImageLayout.Stretch;
            deleteButton.Font = new Font("Times New Roman", 13.25F, FontStyle.Regular, GraphicsUnit.Point);
            deleteButton.ForeColor = SystemColors.Control;
            deleteButton.ImageAlign = ContentAlignment.MiddleLeft;
            deleteButton.Location = new Point(676, 68);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(121, 39);
            deleteButton.TabIndex = 9;
            deleteButton.Text = "Delete Selected";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.Cyan;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(128, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, startDateDataGridViewTextBoxColumn, endDateDataGridViewTextBoxColumn });
            dataGridView1.DataSource = tournamentBindingSource;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Cyan;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.MintCream;
            dataGridViewCellStyle4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 337);
            dataGridView1.TabIndex = 11;
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
            // startDateDataGridViewTextBoxColumn
            // 
            startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.5834846F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.41652F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(tournamentName, 1, 0);
            tableLayoutPanel1.Controls.Add(endDate, 1, 2);
            tableLayoutPanel1.Controls.Add(startDate, 1, 1);
            tableLayoutPanel1.Location = new Point(0, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(673, 100);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // TournamentStatisticsWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dataGridView1);
            Controls.Add(deleteButton);
            Controls.Add(createButton);
            Location = new Point(592, 400);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimumSize = new Size(816, 489);
            Name = "TournamentStatisticsWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tournament Statistics";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)tournamentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox tournamentName;
        private Label label2;
        private Label label3;
        private DateTimePicker startDate;
        private DateTimePicker endDate;
        private Label label4;
        private Button createButton;
        private Button deleteButton;
        private DataGridView dataGridView1;
        private BindingSource tournamentBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private TableLayoutPanel tableLayoutPanel1;
    }
}