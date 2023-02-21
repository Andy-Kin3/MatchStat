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
            this.matchDate = new System.Windows.Forms.Label();
            this.matchDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.team1ID = new System.Windows.Forms.Label();
            this.team2Id = new System.Windows.Forms.Label();
            this.tournamentId = new System.Windows.Forms.Label();
            this.tourCbo = new System.Windows.Forms.ComboBox();
            this.matchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.team1Cbo = new System.Windows.Forms.ComboBox();
            this.team2Cbo = new System.Windows.Forms.ComboBox();
            this.createMatchButton = new System.Windows.Forms.Button();
            this.deleteMatchButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // matchDate
            // 
            this.matchDate.AutoSize = true;
            this.matchDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.matchDate.Location = new System.Drawing.Point(12, 11);
            this.matchDate.Name = "matchDate";
            this.matchDate.Size = new System.Drawing.Size(102, 19);
            this.matchDate.TabIndex = 0;
            this.matchDate.Text = "Maktch Date :";
            // 
            // matchDateTimePicker
            // 
            this.matchDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.matchDateTimePicker.Location = new System.Drawing.Point(117, 5);
            this.matchDateTimePicker.Name = "matchDateTimePicker";
            this.matchDateTimePicker.Size = new System.Drawing.Size(242, 26);
            this.matchDateTimePicker.TabIndex = 1;
            // 
            // team1ID
            // 
            this.team1ID.AutoSize = true;
            this.team1ID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.team1ID.Location = new System.Drawing.Point(365, 11);
            this.team1ID.Name = "team1ID";
            this.team1ID.Size = new System.Drawing.Size(81, 19);
            this.team1ID.TabIndex = 2;
            this.team1ID.Text = "Team1 ID :";
            // 
            // team2Id
            // 
            this.team2Id.AutoSize = true;
            this.team2Id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.team2Id.Location = new System.Drawing.Point(577, 11);
            this.team2Id.Name = "team2Id";
            this.team2Id.Size = new System.Drawing.Size(81, 19);
            this.team2Id.TabIndex = 3;
            this.team2Id.Text = "Team2 ID :";
            // 
            // tournamentId
            // 
            this.tournamentId.AutoSize = true;
            this.tournamentId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tournamentId.Location = new System.Drawing.Point(12, 43);
            this.tournamentId.Name = "tournamentId";
            this.tournamentId.Size = new System.Drawing.Size(116, 19);
            this.tournamentId.TabIndex = 4;
            this.tournamentId.Text = "Tournament ID :";
            // 
            // tourCbo
            // 
            this.tourCbo.DataSource = this.matchBindingSource;
            this.tourCbo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tourCbo.FormattingEnabled = true;
            this.tourCbo.Location = new System.Drawing.Point(131, 40);
            this.tourCbo.Name = "tourCbo";
            this.tourCbo.Size = new System.Drawing.Size(315, 27);
            this.tourCbo.TabIndex = 5;
            // 
            // matchBindingSource
            // 
            this.matchBindingSource.DataSource = typeof(MatchStat.DataModel.DataModels.Match);
            // 
            // team1Cbo
            // 
            this.team1Cbo.DataSource = this.matchBindingSource;
            this.team1Cbo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.team1Cbo.FormattingEnabled = true;
            this.team1Cbo.Location = new System.Drawing.Point(450, 8);
            this.team1Cbo.Name = "team1Cbo";
            this.team1Cbo.Size = new System.Drawing.Size(121, 27);
            this.team1Cbo.TabIndex = 6;
            // 
            // team2Cbo
            // 
            this.team2Cbo.DataSource = this.matchBindingSource;
            this.team2Cbo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.team2Cbo.FormattingEnabled = true;
            this.team2Cbo.Location = new System.Drawing.Point(667, 8);
            this.team2Cbo.Name = "team2Cbo";
            this.team2Cbo.Size = new System.Drawing.Size(121, 27);
            this.team2Cbo.TabIndex = 7;
            // 
            // createMatchButton
            // 
            this.createMatchButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.createMatchButton.Location = new System.Drawing.Point(471, 39);
            this.createMatchButton.Name = "createMatchButton";
            this.createMatchButton.Size = new System.Drawing.Size(149, 32);
            this.createMatchButton.TabIndex = 8;
            this.createMatchButton.Text = "Create";
            this.createMatchButton.UseVisualStyleBackColor = true;
            this.createMatchButton.Click += new System.EventHandler(this.createMatchButton_Click);
            // 
            // deleteMatchButton
            // 
            this.deleteMatchButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.deleteMatchButton.Location = new System.Drawing.Point(638, 41);
            this.deleteMatchButton.Name = "deleteMatchButton";
            this.deleteMatchButton.Size = new System.Drawing.Size(150, 30);
            this.deleteMatchButton.TabIndex = 9;
            this.deleteMatchButton.Text = "Delete Selected";
            this.deleteMatchButton.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listView1.Location = new System.Drawing.Point(12, 73);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 365);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // Match
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Match";
            this.Text = "Match";
            this.Load += new System.EventHandler(this.Match_Load);
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).EndInit();
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
    }
}