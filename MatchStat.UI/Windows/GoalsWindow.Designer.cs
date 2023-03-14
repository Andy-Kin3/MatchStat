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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NumberOfGoal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.playerCbox = new System.Windows.Forms.ComboBox();
            this.playerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.matchCbox = new System.Windows.Forms.ComboBox();
            this.matchDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numberOfGoals = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.removeButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfGoals)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberOfGoal,
            this.playerNameDataGridViewTextBoxColumn,
            this.matchNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.goalBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.Location = new System.Drawing.Point(0, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(800, 294);
            this.dataGridView1.TabIndex = 0;
            // 
            // NumberOfGoal
            // 
            this.NumberOfGoal.DataPropertyName = "NumberOfGoal";
            this.NumberOfGoal.HeaderText = "Number Of Goals";
            this.NumberOfGoal.Name = "NumberOfGoal";
            this.NumberOfGoal.ReadOnly = true;
            // 
            // playerNameDataGridViewTextBoxColumn
            // 
            this.playerNameDataGridViewTextBoxColumn.DataPropertyName = "PlayerName";
            this.playerNameDataGridViewTextBoxColumn.HeaderText = "PlayerName";
            this.playerNameDataGridViewTextBoxColumn.Name = "playerNameDataGridViewTextBoxColumn";
            this.playerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matchNameDataGridViewTextBoxColumn
            // 
            this.matchNameDataGridViewTextBoxColumn.DataPropertyName = "MatchName";
            this.matchNameDataGridViewTextBoxColumn.HeaderText = "MatchName";
            this.matchNameDataGridViewTextBoxColumn.Name = "matchNameDataGridViewTextBoxColumn";
            this.matchNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goalBindingSource
            // 
            this.goalBindingSource.DataSource = typeof(MatchStat.DataModel.DataModels.Goal);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Player :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number Of Goals :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Match :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerCbox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.playerCbox, 3);
            this.playerCbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playerBindingSource1, "FullName", true));
            this.playerCbox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.playerBindingSource1, "FullName", true));
            this.playerCbox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.playerBindingSource1, "FullName", true));
            this.playerCbox.DataBindings.Add(new System.Windows.Forms.Binding("DataContext", this.playerBindingSource1, "FullName", true));
            this.playerCbox.DataSource = this.playerBindingSource1;
            this.playerCbox.DisplayMember = "FullName";
            this.playerCbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerCbox.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playerCbox.FormattingEnabled = true;
            this.playerCbox.Location = new System.Drawing.Point(203, 3);
            this.playerCbox.Name = "playerCbox";
            this.playerCbox.Size = new System.Drawing.Size(594, 27);
            this.playerCbox.TabIndex = 6;
            this.playerCbox.ValueMember = "Id";
            // 
            // playerBindingSource1
            // 
            this.playerBindingSource1.DataSource = typeof(MatchStat.DataModel.DataModels.Player);
            // 
            // matchCbox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.matchCbox, 3);
            this.matchCbox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.goalBindingSource, "MatchId", true));
            this.matchCbox.DataSource = this.matchDetailsBindingSource;
            this.matchCbox.DisplayMember = "MatchName";
            this.matchCbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matchCbox.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.matchCbox.FormattingEnabled = true;
            this.matchCbox.Location = new System.Drawing.Point(203, 40);
            this.matchCbox.Name = "matchCbox";
            this.matchCbox.Size = new System.Drawing.Size(594, 27);
            this.matchCbox.TabIndex = 7;
            this.matchCbox.ValueMember = "Id";
            // 
            // matchDetailsBindingSource
            // 
            this.matchDetailsBindingSource.DataSource = typeof(MatchStat.DataModel.DataModels.MatchDetail);
            // 
            // matchBindingSource
            // 
            this.matchBindingSource.DataSource = typeof(MatchStat.DataModel.DataModels.Match);
            // 
            // numberOfGoals
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.numberOfGoals, 3);
            this.numberOfGoals.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.goalBindingSource, "NumberOfGoal", true));
            this.numberOfGoals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberOfGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberOfGoals.Location = new System.Drawing.Point(203, 77);
            this.numberOfGoals.Name = "numberOfGoals";
            this.numberOfGoals.Size = new System.Drawing.Size(594, 27);
            this.numberOfGoals.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.playerCbox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.matchCbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.numberOfGoals, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 112);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeButton.Location = new System.Drawing.Point(637, 118);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(163, 32);
            this.removeButton.TabIndex = 11;
            this.removeButton.Text = "Remove Selected";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createButton.Location = new System.Drawing.Point(203, 118);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(120, 32);
            this.createButton.TabIndex = 10;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click_1);
            // 
            // GoalsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Location = new System.Drawing.Point(592, 400);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "GoalsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Goal Window";
            this.Load += new System.EventHandler(this.Goals_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfGoals)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

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