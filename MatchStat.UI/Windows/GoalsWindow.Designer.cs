namespace MatchStat.UI
{
    partial class GoalsWindow
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            NumberOfGoal = new DataGridViewTextBoxColumn();
            playerNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            matchNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            goalBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            playerCbox = new ComboBox();
            playerBindingSource1 = new BindingSource(components);
            matchCbox = new ComboBox();
            matchDetailsBindingSource = new BindingSource(components);
            matchBindingSource = new BindingSource(components);
            numberOfGoals = new NumericUpDown();
            tableLayoutPanel1 = new TableLayoutPanel();
            removeButton = new Button();
            createButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)goalBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)matchDetailsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)matchBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberOfGoals).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(128, 255, 255);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NumberOfGoal, playerNameDataGridViewTextBoxColumn, matchNameDataGridViewTextBoxColumn });
            dataGridView1.DataSource = goalBindingSource;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.GridColor = SystemColors.Info;
            dataGridView1.Location = new Point(0, 156);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(128, 255, 255);
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(800, 294);
            dataGridView1.TabIndex = 0;
            // 
            // NumberOfGoal
            // 
            NumberOfGoal.DataPropertyName = "NumberOfGoal";
            NumberOfGoal.HeaderText = "Number Of Goals";
            NumberOfGoal.Name = "NumberOfGoal";
            NumberOfGoal.ReadOnly = true;
            // 
            // playerNameDataGridViewTextBoxColumn
            // 
            playerNameDataGridViewTextBoxColumn.DataPropertyName = "PlayerName";
            playerNameDataGridViewTextBoxColumn.HeaderText = "PlayerName";
            playerNameDataGridViewTextBoxColumn.Name = "playerNameDataGridViewTextBoxColumn";
            playerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matchNameDataGridViewTextBoxColumn
            // 
            matchNameDataGridViewTextBoxColumn.DataPropertyName = "MatchName";
            matchNameDataGridViewTextBoxColumn.HeaderText = "MatchName";
            matchNameDataGridViewTextBoxColumn.Name = "matchNameDataGridViewTextBoxColumn";
            matchNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goalBindingSource
            // 
            goalBindingSource.DataSource = typeof(DataModel.DataModels.Goal);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(194, 37);
            label1.TabIndex = 3;
            label1.Text = "Player :";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 74);
            label2.Name = "label2";
            label2.Size = new Size(194, 38);
            label2.TabIndex = 4;
            label2.Text = "Number Of Goals :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 37);
            label3.Name = "label3";
            label3.Size = new Size(194, 37);
            label3.TabIndex = 5;
            label3.Text = "Match :";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playerCbox
            // 
            tableLayoutPanel1.SetColumnSpan(playerCbox, 3);
            playerCbox.DataBindings.Add(new Binding("SelectedValue", goalBindingSource, "PlayerId", true));
            playerCbox.DataSource = playerBindingSource1;
            playerCbox.DisplayMember = "FullName";
            playerCbox.Dock = DockStyle.Fill;
            playerCbox.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            playerCbox.FormattingEnabled = true;
            playerCbox.Location = new Point(203, 3);
            playerCbox.Name = "playerCbox";
            playerCbox.Size = new Size(594, 27);
            playerCbox.TabIndex = 6;
            playerCbox.ValueMember = "Id";
            // 
            // playerBindingSource1
            // 
            playerBindingSource1.DataSource = typeof(DataModel.DataModels.Player);
            // 
            // matchCbox
            // 
            tableLayoutPanel1.SetColumnSpan(matchCbox, 3);
            matchCbox.DataBindings.Add(new Binding("SelectedValue", goalBindingSource, "MatchId", true));
            matchCbox.DataSource = matchDetailsBindingSource;
            matchCbox.DisplayMember = "MatchName";
            matchCbox.Dock = DockStyle.Fill;
            matchCbox.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            matchCbox.FormattingEnabled = true;
            matchCbox.Location = new Point(203, 40);
            matchCbox.Name = "matchCbox";
            matchCbox.Size = new Size(594, 27);
            matchCbox.TabIndex = 7;
            matchCbox.ValueMember = "Id";
            // 
            // matchDetailsBindingSource
            // 
            matchDetailsBindingSource.DataSource = typeof(DataModel.DataModels.MatchDetail);
            // 
            // matchBindingSource
            // 
            matchBindingSource.DataSource = typeof(DataModel.DataModels.Match);
            // 
            // numberOfGoals
            // 
            tableLayoutPanel1.SetColumnSpan(numberOfGoals, 3);
            numberOfGoals.DataBindings.Add(new Binding("Value", goalBindingSource, "NumberOfGoal", true));
            numberOfGoals.Dock = DockStyle.Fill;
            numberOfGoals.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            numberOfGoals.Location = new Point(203, 77);
            numberOfGoals.Name = "numberOfGoals";
            numberOfGoals.Size = new Size(594, 27);
            numberOfGoals.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(playerCbox, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(matchCbox, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(numberOfGoals, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 112);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // removeButton
            // 
            removeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            removeButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            removeButton.Location = new Point(637, 118);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(163, 32);
            removeButton.TabIndex = 11;
            removeButton.Text = "Remove Selected";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // createButton
            // 
            createButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            createButton.Location = new Point(203, 118);
            createButton.Name = "createButton";
            createButton.Size = new Size(120, 32);
            createButton.TabIndex = 10;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click_1;
            // 
            // GoalsWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(removeButton);
            Controls.Add(createButton);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dataGridView1);
            Location = new Point(592, 400);
            MinimumSize = new Size(816, 489);
            Name = "GoalsWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Goal Window";
            Load += Goals_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)goalBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)matchDetailsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)matchBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberOfGoals).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private DataGridView dataGridView1;
        private BindingSource goalBindingSource;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox playerCbox;
        private ComboBox matchCbox;
        private NumericUpDown numberOfGoals;
        private BindingSource matchDetailsBindingSource;
        private TableLayoutPanel tableLayoutPanel1;
        private Button removeButton;
        private Button createButton;
        private BindingSource playerBindingSource1;
        private BindingSource matchBindingSource;
        private DataGridViewTextBoxColumn NumberOfGoal;
        private DataGridViewTextBoxColumn playerNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn matchNameDataGridViewTextBoxColumn;
    }
}