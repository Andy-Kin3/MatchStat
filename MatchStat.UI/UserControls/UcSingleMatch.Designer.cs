namespace MatchStat.UI.UserControls
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
            dateTimePicker1 = new DateTimePicker();
            matchDetailBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox_team1 = new ComboBox();
            teamBindingSource = new BindingSource(components);
            numericUpDown_team1 = new NumericUpDown();
            numericUpDown_team2 = new NumericUpDown();
            label5 = new Label();
            comboBox_team2 = new ComboBox();
            teamBindingSource1 = new BindingSource(components);
            comboBox_tournament = new ComboBox();
            tournamentBindingSource = new BindingSource(components);
            comboBox_field = new ComboBox();
            fieldsBindingSource = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)matchDetailBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teamBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_team1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_team2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teamBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tournamentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fieldsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.0528F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.0678711F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.274175F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.27074F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.270739F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.0636787F));
            tableLayoutPanel1.Controls.Add(dateTimePicker1, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(comboBox_team1, 1, 1);
            tableLayoutPanel1.Controls.Add(numericUpDown_team1, 2, 1);
            tableLayoutPanel1.Controls.Add(numericUpDown_team2, 4, 1);
            tableLayoutPanel1.Controls.Add(label5, 3, 1);
            tableLayoutPanel1.Controls.Add(comboBox_team2, 5, 1);
            tableLayoutPanel1.Controls.Add(comboBox_tournament, 1, 2);
            tableLayoutPanel1.Controls.Add(comboBox_field, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(730, 142);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel1.SetColumnSpan(dateTimePicker1, 5);
            dateTimePicker1.DataBindings.Add(new Binding("Value", matchDetailBindingSource, "Date", true));
            dateTimePicker1.Dock = DockStyle.Fill;
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(156, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(571, 29);
            dateTimePicker1.TabIndex = 0;
            // 
            // matchDetailBindingSource
            // 
            matchDetailBindingSource.DataSource = typeof(DataModel.DataModels.MatchDetail);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 35);
            label1.TabIndex = 1;
            label1.Text = "Date";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 35);
            label2.Name = "label2";
            label2.Size = new Size(147, 35);
            label2.TabIndex = 2;
            label2.Text = "Match";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 70);
            label3.Name = "label3";
            label3.Size = new Size(147, 35);
            label3.TabIndex = 3;
            label3.Text = "Tournament";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 105);
            label4.Name = "label4";
            label4.Size = new Size(147, 37);
            label4.TabIndex = 4;
            label4.Text = "Field";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBox_team1
            // 
            comboBox_team1.DataBindings.Add(new Binding("SelectedValue", matchDetailBindingSource, "Team1Id", true));
            comboBox_team1.DataSource = teamBindingSource;
            comboBox_team1.DisplayMember = "Name";
            comboBox_team1.Dock = DockStyle.Fill;
            comboBox_team1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_team1.FormattingEnabled = true;
            comboBox_team1.Location = new Point(156, 38);
            comboBox_team1.Name = "comboBox_team1";
            comboBox_team1.Size = new Size(191, 29);
            comboBox_team1.TabIndex = 5;
            comboBox_team1.ValueMember = "Id";
            // 
            // teamBindingSource
            // 
            teamBindingSource.DataSource = typeof(DataModel.DataModels.Team);
            // 
            // numericUpDown_team1
            // 
            numericUpDown_team1.DataBindings.Add(new Binding("Value", matchDetailBindingSource, "TeamOneScore", true));
            numericUpDown_team1.Dock = DockStyle.Fill;
            numericUpDown_team1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown_team1.Location = new Point(353, 38);
            numericUpDown_team1.Name = "numericUpDown_team1";
            numericUpDown_team1.Size = new Size(54, 29);
            numericUpDown_team1.TabIndex = 6;
            // 
            // numericUpDown_team2
            // 
            numericUpDown_team2.DataBindings.Add(new Binding("Value", matchDetailBindingSource, "TeamTwoScore", true));
            numericUpDown_team2.Dock = DockStyle.Fill;
            numericUpDown_team2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown_team2.Location = new Point(473, 38);
            numericUpDown_team2.Name = "numericUpDown_team2";
            numericUpDown_team2.Size = new Size(54, 29);
            numericUpDown_team2.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(413, 35);
            label5.Name = "label5";
            label5.Size = new Size(54, 35);
            label5.TabIndex = 8;
            label5.Text = "VS";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox_team2
            // 
            comboBox_team2.DataBindings.Add(new Binding("SelectedValue", matchDetailBindingSource, "Team2Id", true));
            comboBox_team2.DataSource = teamBindingSource1;
            comboBox_team2.DisplayMember = "Name";
            comboBox_team2.Dock = DockStyle.Fill;
            comboBox_team2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_team2.FormattingEnabled = true;
            comboBox_team2.Location = new Point(533, 38);
            comboBox_team2.Name = "comboBox_team2";
            comboBox_team2.Size = new Size(194, 29);
            comboBox_team2.TabIndex = 9;
            comboBox_team2.ValueMember = "Id";
            // 
            // teamBindingSource1
            // 
            teamBindingSource1.DataSource = typeof(DataModel.DataModels.Team);
            // 
            // comboBox_tournament
            // 
            tableLayoutPanel1.SetColumnSpan(comboBox_tournament, 5);
            comboBox_tournament.DataBindings.Add(new Binding("SelectedValue", matchDetailBindingSource, "TournamentId", true));
            comboBox_tournament.DataSource = tournamentBindingSource;
            comboBox_tournament.DisplayMember = "Name";
            comboBox_tournament.Dock = DockStyle.Fill;
            comboBox_tournament.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_tournament.FormattingEnabled = true;
            comboBox_tournament.Location = new Point(156, 73);
            comboBox_tournament.Name = "comboBox_tournament";
            comboBox_tournament.Size = new Size(571, 29);
            comboBox_tournament.TabIndex = 10;
            comboBox_tournament.ValueMember = "Id";
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
            comboBox_field.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_field.FormattingEnabled = true;
            comboBox_field.Location = new Point(156, 108);
            comboBox_field.Name = "comboBox_field";
            comboBox_field.Size = new Size(571, 29);
            comboBox_field.TabIndex = 11;
            comboBox_field.ValueMember = "Id";
            // 
            // fieldsBindingSource
            // 
            fieldsBindingSource.DataSource = typeof(DataModel.DataModels.Fields);
            // 
            // UcSingleMatch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UcSingleMatch";
            Size = new Size(730, 142);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)matchDetailBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)teamBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_team1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_team2).EndInit();
            ((System.ComponentModel.ISupportInitialize)teamBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tournamentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)fieldsBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox_team1;
        private NumericUpDown numericUpDown_team1;
        private NumericUpDown numericUpDown_team2;
        private Label label5;
        private ComboBox comboBox_team2;
        private ComboBox comboBox_tournament;
        private ComboBox comboBox_field;
        private BindingSource tournamentBindingSource;
        private BindingSource fieldsBindingSource;
        private BindingSource matchDetailBindingSource;
        private BindingSource teamBindingSource;
        private BindingSource teamBindingSource1;
    }
}
