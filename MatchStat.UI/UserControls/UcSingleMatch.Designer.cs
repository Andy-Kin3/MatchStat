﻿namespace MatchStat.UI.UserControls
{
    partial class UcSingleMatch
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

        #region Component Designer generated code

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
            comboBox_team1 = new ComboBox();
            matchDetailBindingSource = new BindingSource(components);
            teamBindingSource = new BindingSource(components);
            comboBox_tournament = new ComboBox();
            tournamentBindingSource = new BindingSource(components);
            comboBox_field = new ComboBox();
            fieldsBindingSource = new BindingSource(components);
            comboBox_team2 = new ComboBox();
            team_BindingSource = new BindingSource(components);
            dateTimePicker1 = new DateTimePicker();
            numericUpDown_team1 = new NumericUpDown();
            numericUpDown_team2 = new NumericUpDown();
            label5 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)matchDetailBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teamBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tournamentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fieldsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)team_BindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_team1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_team2).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.7447968F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.6601772F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.312999F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.312999F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.308859F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.6601772F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(comboBox_team1, 1, 1);
            tableLayoutPanel1.Controls.Add(comboBox_tournament, 1, 2);
            tableLayoutPanel1.Controls.Add(comboBox_field, 1, 3);
            tableLayoutPanel1.Controls.Add(comboBox_team2, 5, 1);
            tableLayoutPanel1.Controls.Add(dateTimePicker1, 1, 0);
            tableLayoutPanel1.Controls.Add(numericUpDown_team1, 2, 1);
            tableLayoutPanel1.Controls.Add(numericUpDown_team2, 4, 1);
            tableLayoutPanel1.Controls.Add(label5, 3, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(649, 132);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 33);
            label1.TabIndex = 0;
            label1.Text = "Date";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 33);
            label2.Name = "label2";
            label2.Size = new Size(96, 33);
            label2.TabIndex = 1;
            label2.Text = "Match";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 66);
            label3.Name = "label3";
            label3.Size = new Size(96, 33);
            label3.TabIndex = 2;
            label3.Text = "Tournament";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 99);
            label4.Name = "label4";
            label4.Size = new Size(96, 33);
            label4.TabIndex = 3;
            label4.Text = "Field";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBox_team1
            // 
            comboBox_team1.DataBindings.Add(new Binding("SelectedValue", matchDetailBindingSource, "Team1Id", true));
            comboBox_team1.DataSource = teamBindingSource;
            comboBox_team1.DisplayMember = "Name";
            comboBox_team1.Dock = DockStyle.Fill;
            comboBox_team1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_team1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_team1.FormattingEnabled = true;
            comboBox_team1.Location = new Point(105, 36);
            comboBox_team1.Name = "comboBox_team1";
            comboBox_team1.Size = new Size(186, 29);
            comboBox_team1.TabIndex = 5;
            comboBox_team1.ValueMember = "Id";
            // 
            // matchDetailBindingSource
            // 
            matchDetailBindingSource.DataSource = typeof(DataModel.DataModels.MatchDetail);
            // 
            // teamBindingSource
            // 
            teamBindingSource.DataSource = typeof(DataModel.DataModels.Team);
            // 
            // comboBox_tournament
            // 
            tableLayoutPanel1.SetColumnSpan(comboBox_tournament, 5);
            comboBox_tournament.DataBindings.Add(new Binding("SelectedValue", matchDetailBindingSource, "TournamentId", true));
            comboBox_tournament.DataSource = tournamentBindingSource;
            comboBox_tournament.DisplayMember = "Name";
            comboBox_tournament.Dock = DockStyle.Fill;
            comboBox_tournament.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_tournament.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_tournament.FormattingEnabled = true;
            comboBox_tournament.Location = new Point(105, 69);
            comboBox_tournament.Name = "comboBox_tournament";
            comboBox_tournament.Size = new Size(541, 29);
            comboBox_tournament.TabIndex = 6;
            // 
            // tournamentBindingSource
            // 
            tournamentBindingSource.DataSource = typeof(DataModel.DataModels.Tournament);
            // 
            // comboBox_field
            // 
            tableLayoutPanel1.SetColumnSpan(comboBox_field, 5);
            comboBox_field.DataBindings.Add(new Binding("SelectedValue", matchDetailBindingSource, "FieldId", true));
            comboBox_field.DataSource = fieldsBindingSource;
            comboBox_field.DisplayMember = "Name";
            comboBox_field.Dock = DockStyle.Fill;
            comboBox_field.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_field.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_field.FormattingEnabled = true;
            comboBox_field.Location = new Point(105, 102);
            comboBox_field.Name = "comboBox_field";
            comboBox_field.Size = new Size(541, 29);
            comboBox_field.TabIndex = 7;
            comboBox_field.ValueMember = "Id";
            // 
            // comboBox_team2
            // 
            comboBox_team2.DataBindings.Add(new Binding("SelectedValue", matchDetailBindingSource, "Team2Id", true));
            comboBox_team2.DataSource = team_BindingSource;
            comboBox_team2.DisplayMember = "Name";
            comboBox_team2.Dock = DockStyle.Fill;
            comboBox_team2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_team2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_team2.FormattingEnabled = true;
            comboBox_team2.Location = new Point(456, 36);
            comboBox_team2.Name = "comboBox_team2";
            comboBox_team2.Size = new Size(190, 29);
            comboBox_team2.TabIndex = 8;
            comboBox_team2.ValueMember = "Id";
            // 
            // team_BindingSource
            // 
            team_BindingSource.DataSource = typeof(DataModel.DataModels.Team);
            // 
            // dateTimePicker1
            // 
            tableLayoutPanel1.SetColumnSpan(dateTimePicker1, 5);
            dateTimePicker1.DataBindings.Add(new Binding("Value", matchDetailBindingSource, "Date", true));
            dateTimePicker1.Dock = DockStyle.Fill;
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(105, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(541, 29);
            dateTimePicker1.TabIndex = 9;
            // 
            // numericUpDown_team1
            // 
            numericUpDown_team1.DataBindings.Add(new Binding("Value", matchDetailBindingSource, "TeamOneScore", true));
            numericUpDown_team1.Dock = DockStyle.Fill;
            numericUpDown_team1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown_team1.Location = new Point(297, 36);
            numericUpDown_team1.Name = "numericUpDown_team1";
            numericUpDown_team1.Size = new Size(47, 29);
            numericUpDown_team1.TabIndex = 10;
            // 
            // numericUpDown_team2
            // 
            numericUpDown_team2.DataBindings.Add(new Binding("Value", matchDetailBindingSource, "TeamTwoScore", true));
            numericUpDown_team2.Dock = DockStyle.Fill;
            numericUpDown_team2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown_team2.Location = new Point(403, 36);
            numericUpDown_team2.Name = "numericUpDown_team2";
            numericUpDown_team2.Size = new Size(47, 29);
            numericUpDown_team2.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(350, 33);
            label5.Name = "label5";
            label5.Size = new Size(47, 33);
            label5.TabIndex = 12;
            label5.Text = "VS";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UcSingleMatch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UcSingleMatch";
            Size = new Size(649, 132);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)matchDetailBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)teamBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)tournamentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)fieldsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)team_BindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_team1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_team2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox_team1;
        private ComboBox comboBox_tournament;
        private ComboBox comboBox_field;
        private ComboBox comboBox_team2;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown numericUpDown_team1;
        private NumericUpDown numericUpDown_team2;
        private Label label5;
        private BindingSource matchDetailBindingSource;
        private BindingSource teamBindingSource;
        private BindingSource tournamentBindingSource;
        private BindingSource fieldsBindingSource;
        private BindingSource team_BindingSource;
    }
}
