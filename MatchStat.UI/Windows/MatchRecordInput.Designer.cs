namespace MatchStat.UI.Windows
{
    partial class MatchRecordInput
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            matchDetailBindingSource = new BindingSource(components);
            team1Combobox = new ComboBox();
            teamBindingSource = new BindingSource(components);
            team2comboBox = new ComboBox();
            teamBindingSource1 = new BindingSource(components);
            teamScoreOne = new NumericUpDown();
            teamScoreTwo = new NumericUpDown();
            tournamentCbox = new ComboBox();
            tournamentBindingSource = new BindingSource(components);
            fieldcomboBox = new ComboBox();
            fieldsBindingSource = new BindingSource(components);
            label5 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)matchDetailBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teamBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teamBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teamScoreOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teamScoreTwo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tournamentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fieldsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.8324738F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.3800125F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.80250168F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.80250168F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.80250168F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.3800125F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(dateTimePicker1, 1, 0);
            tableLayoutPanel1.Controls.Add(team1Combobox, 1, 1);
            tableLayoutPanel1.Controls.Add(team2comboBox, 5, 1);
            tableLayoutPanel1.Controls.Add(teamScoreOne, 2, 1);
            tableLayoutPanel1.Controls.Add(teamScoreTwo, 4, 1);
            tableLayoutPanel1.Controls.Add(tournamentCbox, 1, 2);
            tableLayoutPanel1.Controls.Add(fieldcomboBox, 1, 3);
            tableLayoutPanel1.Controls.Add(label5, 3, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(777, 161);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(130, 40);
            label1.TabIndex = 0;
            label1.Text = "Match Date";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(4, 40);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(130, 40);
            label2.TabIndex = 1;
            label2.Text = "Match";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(4, 80);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(130, 40);
            label3.TabIndex = 2;
            label3.Text = "Tournament";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(4, 120);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(130, 41);
            label4.TabIndex = 3;
            label4.Text = "Field";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker1
            // 
            tableLayoutPanel1.SetColumnSpan(dateTimePicker1, 5);
            dateTimePicker1.DataBindings.Add(new Binding("Value", matchDetailBindingSource, "Date", true));
            dateTimePicker1.Dock = DockStyle.Fill;
            dateTimePicker1.Location = new Point(142, 4);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(631, 26);
            dateTimePicker1.TabIndex = 4;
            // 
            // matchDetailBindingSource
            // 
            matchDetailBindingSource.DataSource = typeof(DataModel.DataModels.MatchDetail);
            // 
            // team1Combobox
            // 
            team1Combobox.DataBindings.Add(new Binding("SelectedValue", matchDetailBindingSource, "Team1Name", true));
            team1Combobox.DataSource = teamBindingSource;
            team1Combobox.DisplayMember = "Name";
            team1Combobox.Dock = DockStyle.Fill;
            team1Combobox.FormattingEnabled = true;
            team1Combobox.Location = new Point(142, 44);
            team1Combobox.Margin = new Padding(4);
            team1Combobox.Name = "team1Combobox";
            team1Combobox.Size = new Size(243, 27);
            team1Combobox.TabIndex = 5;
            team1Combobox.ValueMember = "Id";
            // 
            // teamBindingSource
            // 
            teamBindingSource.DataSource = typeof(DataModel.DataModels.Team);
            // 
            // team2comboBox
            // 
            team2comboBox.DataBindings.Add(new Binding("SelectedValue", matchDetailBindingSource, "Team2Name", true));
            team2comboBox.DataSource = teamBindingSource1;
            team2comboBox.DisplayMember = "Name";
            team2comboBox.Dock = DockStyle.Fill;
            team2comboBox.FormattingEnabled = true;
            team2comboBox.Location = new Point(528, 44);
            team2comboBox.Margin = new Padding(4);
            team2comboBox.Name = "team2comboBox";
            team2comboBox.Size = new Size(245, 27);
            team2comboBox.TabIndex = 6;
            team2comboBox.ValueMember = "Id";
            // 
            // teamBindingSource1
            // 
            teamBindingSource1.DataSource = typeof(DataModel.DataModels.Team);
            // 
            // teamScoreOne
            // 
            teamScoreOne.DataBindings.Add(new Binding("Value", matchDetailBindingSource, "TeamOneScore", true));
            teamScoreOne.Dock = DockStyle.Fill;
            teamScoreOne.Location = new Point(393, 44);
            teamScoreOne.Margin = new Padding(4);
            teamScoreOne.Name = "teamScoreOne";
            teamScoreOne.Size = new Size(37, 26);
            teamScoreOne.TabIndex = 7;
            // 
            // teamScoreTwo
            // 
            teamScoreTwo.DataBindings.Add(new Binding("Value", matchDetailBindingSource, "TeamTwoScore", true));
            teamScoreTwo.Dock = DockStyle.Fill;
            teamScoreTwo.Location = new Point(483, 44);
            teamScoreTwo.Margin = new Padding(4);
            teamScoreTwo.Name = "teamScoreTwo";
            teamScoreTwo.Size = new Size(37, 26);
            teamScoreTwo.TabIndex = 8;
            // 
            // tournamentCbox
            // 
            tableLayoutPanel1.SetColumnSpan(tournamentCbox, 5);
            tournamentCbox.DataBindings.Add(new Binding("SelectedValue", matchDetailBindingSource, "TournamentName", true));
            tournamentCbox.DataSource = tournamentBindingSource;
            tournamentCbox.DisplayMember = "Name";
            tournamentCbox.Dock = DockStyle.Fill;
            tournamentCbox.FormattingEnabled = true;
            tournamentCbox.Location = new Point(142, 84);
            tournamentCbox.Margin = new Padding(4);
            tournamentCbox.Name = "tournamentCbox";
            tournamentCbox.Size = new Size(631, 27);
            tournamentCbox.TabIndex = 9;
            tournamentCbox.ValueMember = "Id";
            // 
            // tournamentBindingSource
            // 
            tournamentBindingSource.DataSource = typeof(DataModel.DataModels.Tournament);
            // 
            // fieldcomboBox
            // 
            tableLayoutPanel1.SetColumnSpan(fieldcomboBox, 5);
            fieldcomboBox.DataBindings.Add(new Binding("SelectedValue", matchDetailBindingSource, "FieldName", true));
            fieldcomboBox.DataSource = fieldsBindingSource;
            fieldcomboBox.DisplayMember = "Name";
            fieldcomboBox.Dock = DockStyle.Fill;
            fieldcomboBox.FormattingEnabled = true;
            fieldcomboBox.Location = new Point(142, 124);
            fieldcomboBox.Margin = new Padding(4);
            fieldcomboBox.Name = "fieldcomboBox";
            fieldcomboBox.Size = new Size(631, 27);
            fieldcomboBox.TabIndex = 10;
            fieldcomboBox.ValueMember = "Id";
            // 
            // fieldsBindingSource
            // 
            fieldsBindingSource.DataSource = typeof(DataModel.DataModels.Fields);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(437, 40);
            label5.Name = "label5";
            label5.Size = new Size(39, 40);
            label5.TabIndex = 11;
            label5.Text = "VS";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MatchRecordInput
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(777, 161);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "MatchRecordInput";
            Text = "Match Record Input";
            Load += MatchRecordInput_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)matchDetailBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)teamBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)teamBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)teamScoreOne).EndInit();
            ((System.ComponentModel.ISupportInitialize)teamScoreTwo).EndInit();
            ((System.ComponentModel.ISupportInitialize)tournamentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)fieldsBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private ComboBox team1Combobox;
        private BindingSource matchDetailBindingSource;
        private BindingSource teamBindingSource;
        private ComboBox team2comboBox;
        private BindingSource teamBindingSource1;
        private NumericUpDown teamScoreOne;
        private NumericUpDown teamScoreTwo;
        private ComboBox tournamentCbox;
        private BindingSource tournamentBindingSource;
        private ComboBox fieldcomboBox;
        private BindingSource fieldsBindingSource;
        private Label label5;
    }
}