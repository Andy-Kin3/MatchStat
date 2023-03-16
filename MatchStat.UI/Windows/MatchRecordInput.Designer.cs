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
            comboBox1 = new ComboBox();
            matchDetailBindingSource = new BindingSource(components);
            teamBindingSource = new BindingSource(components);
            comboBox2 = new ComboBox();
            teamBindingSource1 = new BindingSource(components);
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            comboBox3 = new ComboBox();
            tournamentBindingSource = new BindingSource(components);
            comboBox4 = new ComboBox();
            fieldsBindingSource = new BindingSource(components);
            label5 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)matchDetailBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teamBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teamBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
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
            tableLayoutPanel1.Controls.Add(comboBox1, 1, 1);
            tableLayoutPanel1.Controls.Add(comboBox2, 5, 1);
            tableLayoutPanel1.Controls.Add(numericUpDown1, 2, 1);
            tableLayoutPanel1.Controls.Add(numericUpDown2, 4, 1);
            tableLayoutPanel1.Controls.Add(comboBox3, 1, 2);
            tableLayoutPanel1.Controls.Add(comboBox4, 1, 3);
            tableLayoutPanel1.Controls.Add(label5, 3, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 4, 4, 4);
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
            dateTimePicker1.Margin = new Padding(4, 4, 4, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(631, 26);
            dateTimePicker1.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.DataBindings.Add(new Binding("SelectedValue", matchDetailBindingSource, "Team1Id", true));
            comboBox1.DataSource = teamBindingSource;
            comboBox1.DisplayMember = "Name";
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(142, 44);
            comboBox1.Margin = new Padding(4, 4, 4, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(243, 27);
            comboBox1.TabIndex = 5;
            // 
            // matchDetailBindingSource
            // 
            matchDetailBindingSource.DataSource = typeof(DataModel.DataModels.MatchDetail);
            // 
            // teamBindingSource
            // 
            teamBindingSource.DataSource = typeof(DataModel.DataModels.Team);
            // 
            // comboBox2
            // 
            comboBox2.DataBindings.Add(new Binding("SelectedValue", matchDetailBindingSource, "Team2Id", true));
            comboBox2.DataSource = teamBindingSource1;
            comboBox2.DisplayMember = "Name";
            comboBox2.Dock = DockStyle.Fill;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(528, 44);
            comboBox2.Margin = new Padding(4, 4, 4, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(245, 27);
            comboBox2.TabIndex = 6;
            comboBox2.ValueMember = "Id";
            // 
            // teamBindingSource1
            // 
            teamBindingSource1.DataSource = typeof(DataModel.DataModels.Team);
            // 
            // numericUpDown1
            // 
            numericUpDown1.DataBindings.Add(new Binding("Value", matchDetailBindingSource, "TeamOneScore", true));
            numericUpDown1.Dock = DockStyle.Fill;
            numericUpDown1.Location = new Point(393, 44);
            numericUpDown1.Margin = new Padding(4, 4, 4, 4);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(37, 26);
            numericUpDown1.TabIndex = 7;
            // 
            // numericUpDown2
            // 
            numericUpDown2.DataBindings.Add(new Binding("Value", matchDetailBindingSource, "TeamTwoScore", true));
            numericUpDown2.Dock = DockStyle.Fill;
            numericUpDown2.Location = new Point(483, 44);
            numericUpDown2.Margin = new Padding(4, 4, 4, 4);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(37, 26);
            numericUpDown2.TabIndex = 8;
            // 
            // comboBox3
            // 
            tableLayoutPanel1.SetColumnSpan(comboBox3, 5);
            comboBox3.DataBindings.Add(new Binding("Text", matchDetailBindingSource, "TournamentId", true));
            comboBox3.DataBindings.Add(new Binding("SelectedValue", matchDetailBindingSource, "TournamentId", true));
            comboBox3.DataSource = tournamentBindingSource;
            comboBox3.DisplayMember = "Name";
            comboBox3.Dock = DockStyle.Fill;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(142, 84);
            comboBox3.Margin = new Padding(4, 4, 4, 4);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(631, 27);
            comboBox3.TabIndex = 9;
            comboBox3.ValueMember = "Id";
            // 
            // tournamentBindingSource
            // 
            tournamentBindingSource.DataSource = typeof(DataModel.DataModels.Tournament);
            // 
            // comboBox4
            // 
            tableLayoutPanel1.SetColumnSpan(comboBox4, 5);
            comboBox4.DataBindings.Add(new Binding("Text", matchDetailBindingSource, "FieldId", true));
            comboBox4.DataBindings.Add(new Binding("SelectedValue", matchDetailBindingSource, "FieldId", true));
            comboBox4.DataSource = fieldsBindingSource;
            comboBox4.DisplayMember = "Name";
            comboBox4.Dock = DockStyle.Fill;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(142, 124);
            comboBox4.Margin = new Padding(4, 4, 4, 4);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(631, 27);
            comboBox4.TabIndex = 10;
            comboBox4.ValueMember = "Id";
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
            Margin = new Padding(4, 4, 4, 4);
            Name = "MatchRecordInput";
            Text = "Match Record Input";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)matchDetailBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)teamBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)teamBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
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
        private ComboBox comboBox1;
        private BindingSource matchDetailBindingSource;
        private BindingSource teamBindingSource;
        private ComboBox comboBox2;
        private BindingSource teamBindingSource1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private ComboBox comboBox3;
        private BindingSource tournamentBindingSource;
        private ComboBox comboBox4;
        private BindingSource fieldsBindingSource;
        private Label label5;
    }
}