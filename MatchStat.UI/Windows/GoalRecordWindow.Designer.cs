namespace MatchStat.UI.Windows
{
    partial class GoalRecordWindow
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
            dataGridView1 = new DataGridView();
            playerIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            matchIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numberOfGoalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            goalBindingSource = new BindingSource(components);
            button_CreateGoal = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)goalBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { playerIdDataGridViewTextBoxColumn, matchIdDataGridViewTextBoxColumn, numberOfGoalDataGridViewTextBoxColumn });
            dataGridView1.DataSource = goalBindingSource;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 394);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellFormatting += DataGridView1_cellFormatting;
            // 
            // playerIdDataGridViewTextBoxColumn
            // 
            playerIdDataGridViewTextBoxColumn.DataPropertyName = "PlayerId";
            playerIdDataGridViewTextBoxColumn.HeaderText = "PlayerId";
            playerIdDataGridViewTextBoxColumn.Name = "playerIdDataGridViewTextBoxColumn";
            playerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matchIdDataGridViewTextBoxColumn
            // 
            matchIdDataGridViewTextBoxColumn.DataPropertyName = "MatchId";
            matchIdDataGridViewTextBoxColumn.HeaderText = "MatchId";
            matchIdDataGridViewTextBoxColumn.Name = "matchIdDataGridViewTextBoxColumn";
            matchIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberOfGoalDataGridViewTextBoxColumn
            // 
            numberOfGoalDataGridViewTextBoxColumn.DataPropertyName = "NumberOfGoal";
            numberOfGoalDataGridViewTextBoxColumn.HeaderText = "NumberOfGoal";
            numberOfGoalDataGridViewTextBoxColumn.Name = "numberOfGoalDataGridViewTextBoxColumn";
            numberOfGoalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goalBindingSource
            // 
            goalBindingSource.DataSource = typeof(DataModel.DataModels.Goal);
            // 
            // button_CreateGoal
            // 
            button_CreateGoal.Location = new Point(12, 2);
            button_CreateGoal.Name = "button_CreateGoal";
            button_CreateGoal.Size = new Size(192, 44);
            button_CreateGoal.TabIndex = 1;
            button_CreateGoal.Text = "Create New";
            button_CreateGoal.UseVisualStyleBackColor = true;
            button_CreateGoal.Click += button_CreateGoal_Click;
            // 
            // GoalRecordWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_CreateGoal);
            Controls.Add(dataGridView1);
            Name = "GoalRecordWindow";
            Text = "GoalRecordWindow";
            Load += GoalRecordWindow_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)goalBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn playerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn matchIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numberOfGoalDataGridViewTextBoxColumn;
        private BindingSource goalBindingSource;
        private Button button_CreateGoal;
    }
}