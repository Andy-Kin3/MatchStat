namespace MatchStat.UI
{
    partial class Teams
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
            this.label1 = new System.Windows.Forms.Label();
            this.teamName = new System.Windows.Forms.TextBox();
            this.createbutton = new System.Windows.Forms.Button();
            this.deleteTeamButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchTeam1sDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchTeam2sDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(2, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team :";
            // 
            // teamName
            // 
            this.teamName.Location = new System.Drawing.Point(75, 12);
            this.teamName.Multiline = true;
            this.teamName.Name = "teamName";
            this.teamName.Size = new System.Drawing.Size(377, 29);
            this.teamName.TabIndex = 1;
            // 
            // createbutton
            // 
            this.createbutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createbutton.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createbutton.Location = new System.Drawing.Point(467, 14);
            this.createbutton.Name = "createbutton";
            this.createbutton.Size = new System.Drawing.Size(104, 27);
            this.createbutton.TabIndex = 2;
            this.createbutton.Text = "Create";
            this.createbutton.UseVisualStyleBackColor = true;
            this.createbutton.Click += new System.EventHandler(this.createbutton_Click);
            // 
            // deleteTeamButton
            // 
            this.deleteTeamButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteTeamButton.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteTeamButton.Location = new System.Drawing.Point(582, 13);
            this.deleteTeamButton.Name = "deleteTeamButton";
            this.deleteTeamButton.Size = new System.Drawing.Size(138, 27);
            this.deleteTeamButton.TabIndex = 3;
            this.deleteTeamButton.Text = "Delete Selected";
            this.deleteTeamButton.UseVisualStyleBackColor = true;
            this.deleteTeamButton.Click += new System.EventHandler(this.deleteTeamButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.matchTeam1sDataGridViewTextBoxColumn,
            this.matchTeam2sDataGridViewTextBoxColumn,
            this.playersDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.teamBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(731, 352);
            this.dataGridView1.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // matchTeam1sDataGridViewTextBoxColumn
            // 
            this.matchTeam1sDataGridViewTextBoxColumn.DataPropertyName = "MatchTeam1s";
            this.matchTeam1sDataGridViewTextBoxColumn.HeaderText = "MatchTeam1s";
            this.matchTeam1sDataGridViewTextBoxColumn.Name = "matchTeam1sDataGridViewTextBoxColumn";
            this.matchTeam1sDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matchTeam2sDataGridViewTextBoxColumn
            // 
            this.matchTeam2sDataGridViewTextBoxColumn.DataPropertyName = "MatchTeam2s";
            this.matchTeam2sDataGridViewTextBoxColumn.HeaderText = "MatchTeam2s";
            this.matchTeam2sDataGridViewTextBoxColumn.Name = "matchTeam2sDataGridViewTextBoxColumn";
            this.matchTeam2sDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // playersDataGridViewTextBoxColumn
            // 
            this.playersDataGridViewTextBoxColumn.DataPropertyName = "Players";
            this.playersDataGridViewTextBoxColumn.HeaderText = "Players";
            this.playersDataGridViewTextBoxColumn.Name = "playersDataGridViewTextBoxColumn";
            this.playersDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teamBindingSource
            // 
            this.teamBindingSource.DataSource = typeof(MatchStat.DataModel.DataModels.Team);
            // 
            // Teams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(731, 410);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deleteTeamButton);
            this.Controls.Add(this.createbutton);
            this.Controls.Add(this.teamName);
            this.Controls.Add(this.label1);
            this.Name = "Teams";
            this.Text = "Teams";
            this.Load += new System.EventHandler(this.Teams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox teamName;
        private Button createbutton;
        private Button deleteTeamButton;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn matchTeam1sDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn matchTeam2sDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn playersDataGridViewTextBoxColumn;
        private BindingSource teamBindingSource;
    }
}