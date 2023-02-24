namespace MatchStat.UI
{
    partial class Goals
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.goalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfGoalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.playerCbox = new System.Windows.Forms.ComboBox();
            this.matchCbox = new System.Windows.Forms.ComboBox();
            this.numberOfGoals = new System.Windows.Forms.NumericUpDown();
            this.matchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfGoals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.playerIdDataGridViewTextBoxColumn,
            this.matchIdDataGridViewTextBoxColumn,
            this.numberOfGoalDataGridViewTextBoxColumn,
            this.playerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.goalBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(800, 362);
            this.dataGridView1.TabIndex = 0;
            // 
            // goalBindingSource
            // 
            this.goalBindingSource.DataSource = typeof(MatchStat.DataModel.DataModels.Goal);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // playerIdDataGridViewTextBoxColumn
            // 
            this.playerIdDataGridViewTextBoxColumn.DataPropertyName = "PlayerId";
            this.playerIdDataGridViewTextBoxColumn.HeaderText = "PlayerId";
            this.playerIdDataGridViewTextBoxColumn.Name = "playerIdDataGridViewTextBoxColumn";
            // 
            // matchIdDataGridViewTextBoxColumn
            // 
            this.matchIdDataGridViewTextBoxColumn.DataPropertyName = "MatchId";
            this.matchIdDataGridViewTextBoxColumn.HeaderText = "MatchId";
            this.matchIdDataGridViewTextBoxColumn.Name = "matchIdDataGridViewTextBoxColumn";
            // 
            // numberOfGoalDataGridViewTextBoxColumn
            // 
            this.numberOfGoalDataGridViewTextBoxColumn.DataPropertyName = "NumberOfGoal";
            this.numberOfGoalDataGridViewTextBoxColumn.HeaderText = "NumberOfGoal";
            this.numberOfGoalDataGridViewTextBoxColumn.Name = "numberOfGoalDataGridViewTextBoxColumn";
            // 
            // playerDataGridViewTextBoxColumn
            // 
            this.playerDataGridViewTextBoxColumn.DataPropertyName = "Player";
            this.playerDataGridViewTextBoxColumn.HeaderText = "Player";
            this.playerDataGridViewTextBoxColumn.Name = "playerDataGridViewTextBoxColumn";
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.createButton.Location = new System.Drawing.Point(482, 50);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(120, 32);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click_1);
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.removeButton.Location = new System.Drawing.Point(625, 50);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(163, 32);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "Remove Selected";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Player :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number Of Goals :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(375, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Match :";
            // 
            // playerCbox
            // 
            this.playerCbox.DataSource = this.playerBindingSource;
            this.playerCbox.DisplayMember = "LastName";
            this.playerCbox.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.playerCbox.FormattingEnabled = true;
            this.playerCbox.Location = new System.Drawing.Point(91, 14);
            this.playerCbox.Name = "playerCbox";
            this.playerCbox.Size = new System.Drawing.Size(278, 27);
            this.playerCbox.TabIndex = 6;
            this.playerCbox.ValueMember = "Id";
            // 
            // matchCbox
            // 
            this.matchCbox.DataSource = this.matchesBindingSource;
            this.matchCbox.DisplayMember = "TournamentId";
            this.matchCbox.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.matchCbox.FormattingEnabled = true;
            this.matchCbox.Location = new System.Drawing.Point(447, 13);
            this.matchCbox.Name = "matchCbox";
            this.matchCbox.Size = new System.Drawing.Size(329, 27);
            this.matchCbox.TabIndex = 7;
            this.matchCbox.ValueMember = "Id";
            // 
            // numberOfGoals
            // 
            this.numberOfGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.numberOfGoals.Location = new System.Drawing.Point(166, 53);
            this.numberOfGoals.Name = "numberOfGoals";
            this.numberOfGoals.Size = new System.Drawing.Size(279, 27);
            this.numberOfGoals.TabIndex = 8;
            // 
            // matchesBindingSource
            // 
            this.matchesBindingSource.DataSource = typeof(MatchStat.DataModel.DataModels.Matches);
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(MatchStat.DataModel.DataModels.Player);
            // 
            // Goals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numberOfGoals);
            this.Controls.Add(this.matchCbox);
            this.Controls.Add(this.playerCbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Goals";
            this.Text = "Goal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfGoals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn playerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn matchIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numberOfGoalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn playerDataGridViewTextBoxColumn;
        private BindingSource goalBindingSource;
        private Button createButton;
        private Button removeButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox playerCbox;
        private ComboBox matchCbox;
        private NumericUpDown numberOfGoals;
        private BindingSource playerBindingSource;
        private BindingSource matchesBindingSource;
    }
}