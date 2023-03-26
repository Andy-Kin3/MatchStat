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
            goalBindingSource = new BindingSource(components);
            button_CreateGoal = new Button();
            contextMenuStrip_goal = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            playerIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            matchIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numberOfGoalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)goalBindingSource).BeginInit();
            contextMenuStrip_goal.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.InactiveBorder;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { playerIdDataGridViewTextBoxColumn, matchIdDataGridViewTextBoxColumn, numberOfGoalDataGridViewTextBoxColumn });
            dataGridView1.DataSource = goalBindingSource;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.GridColor = SystemColors.InactiveBorder;
            dataGridView1.Location = new Point(0, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(800, 398);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.CellFormatting += DataGridView1_cellFormatting;
            dataGridView1.MouseUp += dataGridView1_MouseUp;
            // 
            // goalBindingSource
            // 
            goalBindingSource.DataSource = typeof(DataModel.DataModels.Goal);
            // 
            // button_CreateGoal
            // 
            button_CreateGoal.Location = new Point(2, 3);
            button_CreateGoal.Name = "button_CreateGoal";
            button_CreateGoal.Size = new Size(192, 44);
            button_CreateGoal.TabIndex = 1;
            button_CreateGoal.Text = "Create New";
            button_CreateGoal.UseVisualStyleBackColor = true;
            button_CreateGoal.Click += button_CreateGoal_Click;
            // 
            // contextMenuStrip_goal
            // 
            contextMenuStrip_goal.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip_goal.Name = "contextMenuStrip1";
            contextMenuStrip_goal.Size = new Size(108, 48);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(107, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(107, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // playerIdDataGridViewTextBoxColumn
            // 
            playerIdDataGridViewTextBoxColumn.DataPropertyName = "PlayerId";
            playerIdDataGridViewTextBoxColumn.HeaderText = "Players";
            playerIdDataGridViewTextBoxColumn.Name = "playerIdDataGridViewTextBoxColumn";
            playerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matchIdDataGridViewTextBoxColumn
            // 
            matchIdDataGridViewTextBoxColumn.DataPropertyName = "MatchId";
            matchIdDataGridViewTextBoxColumn.HeaderText = "Matches";
            matchIdDataGridViewTextBoxColumn.Name = "matchIdDataGridViewTextBoxColumn";
            matchIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberOfGoalDataGridViewTextBoxColumn
            // 
            numberOfGoalDataGridViewTextBoxColumn.DataPropertyName = "NumberOfGoal";
            numberOfGoalDataGridViewTextBoxColumn.HeaderText = "Number Of Goal";
            numberOfGoalDataGridViewTextBoxColumn.Name = "numberOfGoalDataGridViewTextBoxColumn";
            numberOfGoalDataGridViewTextBoxColumn.ReadOnly = true;
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
            contextMenuStrip_goal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource goalBindingSource;
        private Button button_CreateGoal;
        private ContextMenuStrip contextMenuStrip_goal;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private DataGridViewTextBoxColumn playerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn matchIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numberOfGoalDataGridViewTextBoxColumn;
    }
}