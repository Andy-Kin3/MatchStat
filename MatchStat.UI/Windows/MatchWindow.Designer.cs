namespace MatchStat.UI
{
    partial class MatchWindow
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
            this.matchDate = new System.Windows.Forms.Label();
            this.matchDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.team2Id = new System.Windows.Forms.Label();
            this.tournamentId = new System.Windows.Forms.Label();
            this.tourCbo = new System.Windows.Forms.ComboBox();
            this.tournamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.team1Cbo = new System.Windows.Forms.ComboBox();
            this.teamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.team2Cbo = new System.Windows.Forms.ComboBox();
            this.teamBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.createMatchButton = new System.Windows.Forms.Button();
            this.deleteMatchButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.DateOfMatch = new System.Windows.Forms.ColumnHeader();
            this.MatchName = new System.Windows.Forms.ColumnHeader();
            this.tournament = new System.Windows.Forms.ColumnHeader();
            this.currentfield = new System.Windows.Forms.ColumnHeader();
            this.fieldcbo = new System.Windows.Forms.ComboBox();
            this.fieldsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.field = new System.Windows.Forms.Label();
            this.matchDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamTwoScore = new System.Windows.Forms.NumericUpDown();
            this.teamOneScore = new System.Windows.Forms.NumericUpDown();
            this.MatchID = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamTwoScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamOneScore)).BeginInit();
            this.SuspendLayout();
            // 
            // matchDate
            // 
            this.matchDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchDate.AutoSize = true;
            this.matchDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.matchDate.Location = new System.Drawing.Point(0, 9);
            this.matchDate.Name = "matchDate";
            this.matchDate.Size = new System.Drawing.Size(102, 19);
            this.matchDate.TabIndex = 0;
            this.matchDate.Text = "Maktch Date :";
            // 
            // matchDateTimePicker
            // 
            this.matchDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchDateTimePicker.CustomFormat = "dd-mm-yyyy hh:mm:ss";
            this.matchDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.matchDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.matchDateTimePicker.Location = new System.Drawing.Point(108, 6);
            this.matchDateTimePicker.Name = "matchDateTimePicker";
            this.matchDateTimePicker.Size = new System.Drawing.Size(185, 23);
            this.matchDateTimePicker.TabIndex = 1;
            // 
            // team2Id
            // 
            this.team2Id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.team2Id.AutoSize = true;
            this.team2Id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.team2Id.Location = new System.Drawing.Point(496, 10);
            this.team2Id.Name = "team2Id";
            this.team2Id.Size = new System.Drawing.Size(27, 19);
            this.team2Id.TabIndex = 3;
            this.team2Id.Text = "VS";
            // 
            // tournamentId
            // 
            this.tournamentId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tournamentId.AutoSize = true;
            this.tournamentId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tournamentId.Location = new System.Drawing.Point(6, 41);
            this.tournamentId.Name = "tournamentId";
            this.tournamentId.Size = new System.Drawing.Size(96, 19);
            this.tournamentId.TabIndex = 4;
            this.tournamentId.Text = "Tournament :";
            // 
            // tourCbo
            // 
            this.tourCbo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tourCbo.DataSource = this.tournamentBindingSource;
            this.tourCbo.DisplayMember = "Name";
            this.tourCbo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tourCbo.FormattingEnabled = true;
            this.tourCbo.Location = new System.Drawing.Point(108, 38);
            this.tourCbo.Name = "tourCbo";
            this.tourCbo.Size = new System.Drawing.Size(185, 27);
            this.tourCbo.TabIndex = 5;
            this.tourCbo.ValueMember = "Id";
            // 
            // tournamentBindingSource
            // 
            this.tournamentBindingSource.DataSource = typeof(MatchStat.DataModel.DataModels.Tournament);
            // 
            // team1Cbo
            // 
            this.team1Cbo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.team1Cbo.DataSource = this.teamBindingSource;
            this.team1Cbo.DisplayMember = "Name";
            this.team1Cbo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.team1Cbo.FormattingEnabled = true;
            this.team1Cbo.Location = new System.Drawing.Point(299, 4);
            this.team1Cbo.Name = "team1Cbo";
            this.team1Cbo.Size = new System.Drawing.Size(145, 27);
            this.team1Cbo.TabIndex = 6;
            this.team1Cbo.ValueMember = "Id";
            // 
            // teamBindingSource
            // 
            this.teamBindingSource.DataSource = typeof(MatchStat.DataModel.DataModels.Team);
            // 
            // team2Cbo
            // 
            this.team2Cbo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.team2Cbo.DataSource = this.teamBindingSource1;
            this.team2Cbo.DisplayMember = "Name";
            this.team2Cbo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.team2Cbo.FormattingEnabled = true;
            this.team2Cbo.Location = new System.Drawing.Point(575, 5);
            this.team2Cbo.Name = "team2Cbo";
            this.team2Cbo.Size = new System.Drawing.Size(200, 27);
            this.team2Cbo.TabIndex = 7;
            this.team2Cbo.ValueMember = "Id";
            // 
            // teamBindingSource1
            // 
            this.teamBindingSource1.DataSource = typeof(MatchStat.DataModel.DataModels.Team);
            // 
            // createMatchButton
            // 
            this.createMatchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createMatchButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.createMatchButton.Location = new System.Drawing.Point(547, 37);
            this.createMatchButton.Name = "createMatchButton";
            this.createMatchButton.Size = new System.Drawing.Size(115, 28);
            this.createMatchButton.TabIndex = 8;
            this.createMatchButton.Text = "Save";
            this.createMatchButton.UseVisualStyleBackColor = true;
            this.createMatchButton.Click += new System.EventHandler(this.CreateMatchButton_Click);
            // 
            // deleteMatchButton
            // 
            this.deleteMatchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteMatchButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.deleteMatchButton.Location = new System.Drawing.Point(668, 38);
            this.deleteMatchButton.Name = "deleteMatchButton";
            this.deleteMatchButton.Size = new System.Drawing.Size(132, 27);
            this.deleteMatchButton.TabIndex = 9;
            this.deleteMatchButton.Text = "Delete Selected";
            this.deleteMatchButton.UseVisualStyleBackColor = true;
            this.deleteMatchButton.Click += new System.EventHandler(this.DeleteMatchButton_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MatchID,
            this.DateOfMatch,
            this.MatchName,
            this.tournament,
            this.currentfield});
            this.listView1.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 71);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(800, 379);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listciew1_clicked);
            // 
            // DateOfMatch
            // 
            this.DateOfMatch.Text = "Date";
            this.DateOfMatch.Width = 160;
            // 
            // MatchName
            // 
            this.MatchName.Text = "Match";
            this.MatchName.Width = 260;
            // 
            // tournament
            // 
            this.tournament.Text = "Tournament";
            this.tournament.Width = 160;
            // 
            // currentfield
            // 
            this.currentfield.Text = "Field";
            this.currentfield.Width = 160;
            // 
            // fieldcbo
            // 
            this.fieldcbo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fieldcbo.DataSource = this.fieldsBindingSource;
            this.fieldcbo.DisplayMember = "Name";
            this.fieldcbo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.fieldcbo.FormattingEnabled = true;
            this.fieldcbo.Location = new System.Drawing.Point(356, 37);
            this.fieldcbo.Name = "fieldcbo";
            this.fieldcbo.Size = new System.Drawing.Size(177, 27);
            this.fieldcbo.TabIndex = 12;
            this.fieldcbo.ValueMember = "Id";
            // 
            // fieldsBindingSource
            // 
            this.fieldsBindingSource.DataSource = typeof(MatchStat.DataModel.DataModels.Field);
            // 
            // field
            // 
            this.field.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.field.AutoSize = true;
            this.field.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.field.Location = new System.Drawing.Point(299, 41);
            this.field.Name = "field";
            this.field.Size = new System.Drawing.Size(51, 19);
            this.field.TabIndex = 11;
            this.field.Text = "Field :";
            // 
            // matchDetailBindingSource
            // 
            this.matchDetailBindingSource.DataSource = typeof(MatchStat.DataModel.DataModels.MatchDetail);
            // 
            // teamTwoScore
            // 
            this.teamTwoScore.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamTwoScore.Location = new System.Drawing.Point(527, 7);
            this.teamTwoScore.Name = "teamTwoScore";
            this.teamTwoScore.Size = new System.Drawing.Size(44, 23);
            this.teamTwoScore.TabIndex = 15;
            // 
            // teamOneScore
            // 
            this.teamOneScore.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamOneScore.Location = new System.Drawing.Point(450, 7);
            this.teamOneScore.Name = "teamOneScore";
            this.teamOneScore.Size = new System.Drawing.Size(44, 23);
            this.teamOneScore.TabIndex = 16;
            // 
            // MatchID
            // 
            this.MatchID.Text = "MatchId";
            // 
            // MatchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.teamOneScore);
            this.Controls.Add(this.teamTwoScore);
            this.Controls.Add(this.fieldcbo);
            this.Controls.Add(this.field);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.deleteMatchButton);
            this.Controls.Add(this.createMatchButton);
            this.Controls.Add(this.team2Cbo);
            this.Controls.Add(this.team1Cbo);
            this.Controls.Add(this.tourCbo);
            this.Controls.Add(this.tournamentId);
            this.Controls.Add(this.team2Id);
            this.Controls.Add(this.matchDateTimePicker);
            this.Controls.Add(this.matchDate);
            this.Location = new System.Drawing.Point(592, 400);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MatchWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Match";
            this.Load += new System.EventHandler(this.Match_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tournamentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamTwoScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamOneScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label matchDate;
        private DateTimePicker matchDateTimePicker;
        private Label team2Id;
        private Label tournamentId;
        private ComboBox tourCbo;
        private ComboBox team1Cbo;
        private ComboBox team2Cbo;
        private Button createMatchButton;
        private Button deleteMatchButton;
        private ListView listView1;
        private BindingSource matchBindingSource;
        private ColumnHeader DateOfMatch;
        private ColumnHeader MatchName;
        private ColumnHeader tournament;
        private BindingSource tournamentBindingSource;
        private BindingSource teamBindingSource;
        private BindingSource teamBindingSource1;
        private ComboBox fieldcbo;
        private Label field;
        private BindingSource fieldsBindingSource;
        private ColumnHeader currentfield;
        private BindingSource matchDetailBindingSource;
        private NumericUpDown teamTwoScore;
        private NumericUpDown teamOneScore;
        private ColumnHeader MatchID;
    }
}