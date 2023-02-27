namespace MatchStat.UI
{
    partial class Match
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Match));
            this.matchDate = new System.Windows.Forms.Label();
            this.matchDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.team1ID = new System.Windows.Forms.Label();
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
            this.matchD = new System.Windows.Forms.ColumnHeader();
            this.firstTeam = new System.Windows.Forms.ColumnHeader();
            this.secondTeam = new System.Windows.Forms.ColumnHeader();
            this.tour = new System.Windows.Forms.ColumnHeader();
            this.myfield = new System.Windows.Forms.ColumnHeader();
            this.fieldcbo = new System.Windows.Forms.ComboBox();
            this.fieldsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.field = new System.Windows.Forms.Label();
            this.previewButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // matchDate
            // 
            this.matchDate.AutoSize = true;
            this.matchDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.matchDate.Location = new System.Drawing.Point(14, 9);
            this.matchDate.Name = "matchDate";
            this.matchDate.Size = new System.Drawing.Size(102, 19);
            this.matchDate.TabIndex = 0;
            this.matchDate.Text = "Maktch Date :";
            // 
            // matchDateTimePicker
            // 
            this.matchDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.matchDateTimePicker.Location = new System.Drawing.Point(119, 3);
            this.matchDateTimePicker.Name = "matchDateTimePicker";
            this.matchDateTimePicker.Size = new System.Drawing.Size(242, 26);
            this.matchDateTimePicker.TabIndex = 1;
            // 
            // team1ID
            // 
            this.team1ID.AutoSize = true;
            this.team1ID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.team1ID.Location = new System.Drawing.Point(367, 9);
            this.team1ID.Name = "team1ID";
            this.team1ID.Size = new System.Drawing.Size(65, 19);
            this.team1ID.TabIndex = 2;
            this.team1ID.Text = "Team 1 :";
            // 
            // team2Id
            // 
            this.team2Id.AutoSize = true;
            this.team2Id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.team2Id.Location = new System.Drawing.Point(579, 9);
            this.team2Id.Name = "team2Id";
            this.team2Id.Size = new System.Drawing.Size(65, 19);
            this.team2Id.TabIndex = 3;
            this.team2Id.Text = "Team 2 :";
            // 
            // tournamentId
            // 
            this.tournamentId.AutoSize = true;
            this.tournamentId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tournamentId.Location = new System.Drawing.Point(14, 41);
            this.tournamentId.Name = "tournamentId";
            this.tournamentId.Size = new System.Drawing.Size(96, 19);
            this.tournamentId.TabIndex = 4;
            this.tournamentId.Text = "Tournament :";
            // 
            // tourCbo
            // 
            this.tourCbo.DataSource = this.tournamentBindingSource;
            this.tourCbo.DisplayMember = "Name";
            this.tourCbo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tourCbo.FormattingEnabled = true;
            this.tourCbo.Location = new System.Drawing.Point(116, 37);
            this.tourCbo.Name = "tourCbo";
            this.tourCbo.Size = new System.Drawing.Size(177, 27);
            this.tourCbo.TabIndex = 5;
            this.tourCbo.ValueMember = "Id";
            // 
            // tournamentBindingSource
            // 
            this.tournamentBindingSource.DataSource = typeof(MatchStat.DataModel.DataModels.Tournament);
            // 
            // team1Cbo
            // 
            this.team1Cbo.DataSource = this.teamBindingSource;
            this.team1Cbo.DisplayMember = "Name";
            this.team1Cbo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.team1Cbo.FormattingEnabled = true;
            this.team1Cbo.Location = new System.Drawing.Point(438, 3);
            this.team1Cbo.Name = "team1Cbo";
            this.team1Cbo.Size = new System.Drawing.Size(121, 27);
            this.team1Cbo.TabIndex = 6;
            this.team1Cbo.ValueMember = "Id";
            // 
            // teamBindingSource
            // 
            this.teamBindingSource.DataSource = typeof(MatchStat.DataModel.DataModels.Team);
            // 
            // team2Cbo
            // 
            this.team2Cbo.DataSource = this.teamBindingSource1;
            this.team2Cbo.DisplayMember = "Name";
            this.team2Cbo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.team2Cbo.FormattingEnabled = true;
            this.team2Cbo.Location = new System.Drawing.Point(650, 3);
            this.team2Cbo.Name = "team2Cbo";
            this.team2Cbo.Size = new System.Drawing.Size(121, 27);
            this.team2Cbo.TabIndex = 7;
            this.team2Cbo.ValueMember = "Id";
            // 
            // teamBindingSource1
            // 
            this.teamBindingSource1.DataSource = typeof(MatchStat.DataModel.DataModels.Team);
            // 
            // createMatchButton
            // 
            this.createMatchButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.createMatchButton.Location = new System.Drawing.Point(547, 39);
            this.createMatchButton.Name = "createMatchButton";
            this.createMatchButton.Size = new System.Drawing.Size(115, 32);
            this.createMatchButton.TabIndex = 8;
            this.createMatchButton.Text = "Create";
            this.createMatchButton.UseVisualStyleBackColor = true;
            this.createMatchButton.Click += new System.EventHandler(this.createMatchButton_Click);
            // 
            // deleteMatchButton
            // 
            this.deleteMatchButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.deleteMatchButton.Location = new System.Drawing.Point(668, 39);
            this.deleteMatchButton.Name = "deleteMatchButton";
            this.deleteMatchButton.Size = new System.Drawing.Size(122, 30);
            this.deleteMatchButton.TabIndex = 9;
            this.deleteMatchButton.Text = "Delete Selected";
            this.deleteMatchButton.UseVisualStyleBackColor = true;
            this.deleteMatchButton.Click += new System.EventHandler(this.deleteMatchButton_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.matchD,
            this.firstTeam,
            this.secondTeam,
            this.tour,
            this.myfield});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 104);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(800, 346);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // matchD
            // 
            this.matchD.Text = "Match Date";
            this.matchD.Width = 160;
            // 
            // firstTeam
            // 
            this.firstTeam.Text = "Team 1";
            this.firstTeam.Width = 160;
            // 
            // secondTeam
            // 
            this.secondTeam.Text = "Team 2";
            this.secondTeam.Width = 160;
            // 
            // tour
            // 
            this.tour.Text = "Tournament";
            this.tour.Width = 160;
            // 
            // myfield
            // 
            this.myfield.Text = "Field";
            this.myfield.Width = 160;
            // 
            // fieldcbo
            // 
            this.fieldcbo.DataSource = this.fieldsBindingSource;
            this.fieldcbo.DisplayMember = "Name";
            this.fieldcbo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.fieldcbo.FormattingEnabled = true;
            this.fieldcbo.Location = new System.Drawing.Point(356, 38);
            this.fieldcbo.Name = "fieldcbo";
            this.fieldcbo.Size = new System.Drawing.Size(177, 27);
            this.fieldcbo.TabIndex = 12;
            this.fieldcbo.ValueMember = "Id";
            // 
            // fieldsBindingSource
            // 
            this.fieldsBindingSource.DataSource = typeof(MatchStat.DataModel.DataModels.Fields);
            // 
            // field
            // 
            this.field.AutoSize = true;
            this.field.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.field.Location = new System.Drawing.Point(299, 41);
            this.field.Name = "field";
            this.field.Size = new System.Drawing.Size(51, 19);
            this.field.TabIndex = 11;
            this.field.Text = "Field :";
            // 
            // previewButton
            // 
            this.previewButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("previewButton.BackgroundImage")));
            this.previewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.previewButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.previewButton.Image = ((System.Drawing.Image)(resources.GetObject("previewButton.Image")));
            this.previewButton.Location = new System.Drawing.Point(14, 72);
            this.previewButton.Name = "previewButton";
            this.previewButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.previewButton.Size = new System.Drawing.Size(96, 31);
            this.previewButton.TabIndex = 13;
            this.previewButton.Text = "Preview";
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // Match
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.previewButton);
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
            this.Controls.Add(this.team1ID);
            this.Controls.Add(this.matchDateTimePicker);
            this.Controls.Add(this.matchDate);
            this.Location = new System.Drawing.Point(592, 400);
            this.Name = "Match";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Match";
            this.Load += new System.EventHandler(this.Match_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tournamentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label matchDate;
        private DateTimePicker matchDateTimePicker;
        private Label team1ID;
        private Label team2Id;
        private Label tournamentId;
        private ComboBox tourCbo;
        private ComboBox team1Cbo;
        private ComboBox team2Cbo;
        private Button createMatchButton;
        private Button deleteMatchButton;
        private ListView listView1;
        private BindingSource matchBindingSource;
        private ColumnHeader matchD;
        private ColumnHeader firstTeam;
        private ColumnHeader secondTeam;
        private ColumnHeader tour;
        private BindingSource tournamentBindingSource;
        private BindingSource teamBindingSource;
        private BindingSource teamBindingSource1;
        private ComboBox fieldcbo;
        private Label field;
        private BindingSource fieldsBindingSource;
        private ColumnHeader myfield;
        private Button previewButton;
    }
}