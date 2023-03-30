namespace MatchStat.UI
{
    partial class MatchesWindow2
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
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            matchNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tournamentNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fieldNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            matchDetailBindingSource = new BindingSource(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            bindingSource_matchDetail = new BindingSource(components);
            comboBox1 = new ComboBox();
            team1BindingSource = new BindingSource(components);
            comboBox2 = new ComboBox();
            team2BindingSource = new BindingSource(components);
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label6 = new Label();
            comboBox3 = new ComboBox();
            tournamentBindingSource = new BindingSource(components);
            comboBox4 = new ComboBox();
            fieldsBindingSource = new BindingSource(components);
            saveButton = new Button();
            addButton = new Button();
            matchesMenu = new ContextMenuStrip(components);
            editButton = new ToolStripMenuItem();
            deleteButton2 = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)matchDetailBindingSource).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource_matchDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)team1BindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)team2BindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tournamentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fieldsBindingSource).BeginInit();
            matchesMenu.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, dateDataGridViewTextBoxColumn, matchNameDataGridViewTextBoxColumn, tournamentNameDataGridViewTextBoxColumn, fieldNameDataGridViewTextBoxColumn });
            dataGridView1.DataSource = matchDetailBindingSource;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 180);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(885, 379);
            dataGridView1.TabIndex = 0;
            dataGridView1.MouseUp += dataGridView1_MouseUp;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dateDataGridViewTextBoxColumn.HeaderText = "Date";
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matchNameDataGridViewTextBoxColumn
            // 
            matchNameDataGridViewTextBoxColumn.DataPropertyName = "MatchName";
            matchNameDataGridViewTextBoxColumn.HeaderText = "Match Name";
            matchNameDataGridViewTextBoxColumn.Name = "matchNameDataGridViewTextBoxColumn";
            matchNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tournamentNameDataGridViewTextBoxColumn
            // 
            tournamentNameDataGridViewTextBoxColumn.DataPropertyName = "TournamentName";
            tournamentNameDataGridViewTextBoxColumn.HeaderText = "Tournament Name";
            tournamentNameDataGridViewTextBoxColumn.Name = "tournamentNameDataGridViewTextBoxColumn";
            tournamentNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fieldNameDataGridViewTextBoxColumn
            // 
            fieldNameDataGridViewTextBoxColumn.DataPropertyName = "FieldName";
            fieldNameDataGridViewTextBoxColumn.HeaderText = "Field Name";
            fieldNameDataGridViewTextBoxColumn.Name = "fieldNameDataGridViewTextBoxColumn";
            fieldNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matchDetailBindingSource
            // 
            matchDetailBindingSource.DataSource = typeof(DataModel.DataModels.MatchDetail);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(dateTimePicker1, 1, 0);
            tableLayoutPanel1.Controls.Add(comboBox1, 1, 1);
            tableLayoutPanel1.Controls.Add(comboBox2, 5, 1);
            tableLayoutPanel1.Controls.Add(numericUpDown1, 2, 1);
            tableLayoutPanel1.Controls.Add(numericUpDown2, 4, 1);
            tableLayoutPanel1.Controls.Add(label6, 3, 1);
            tableLayoutPanel1.Controls.Add(comboBox3, 1, 2);
            tableLayoutPanel1.Controls.Add(comboBox4, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(885, 131);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(4, 1);
            label1.Name = "label1";
            label1.Size = new Size(124, 31);
            label1.TabIndex = 0;
            label1.Text = "Match Date";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(4, 33);
            label2.Name = "label2";
            label2.Size = new Size(124, 31);
            label2.TabIndex = 0;
            label2.Text = "Match";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(4, 65);
            label3.Name = "label3";
            label3.Size = new Size(124, 31);
            label3.TabIndex = 0;
            label3.Text = "Tournament";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(4, 97);
            label4.Name = "label4";
            label4.Size = new Size(124, 33);
            label4.TabIndex = 0;
            label4.Text = "Field";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker1
            // 
            tableLayoutPanel1.SetColumnSpan(dateTimePicker1, 5);
            dateTimePicker1.DataBindings.Add(new Binding("Value", bindingSource_matchDetail, "Date", true, DataSourceUpdateMode.OnPropertyChanged));
            dateTimePicker1.Dock = DockStyle.Fill;
            dateTimePicker1.Location = new Point(135, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(746, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // bindingSource_matchDetail
            // 
            bindingSource_matchDetail.DataSource = typeof(DataModel.DataModels.MatchDetail);
            // 
            // comboBox1
            // 
            comboBox1.DataBindings.Add(new Binding("SelectedValue", bindingSource_matchDetail, "Team1Id", true));
            comboBox1.DataSource = team1BindingSource;
            comboBox1.DisplayMember = "Name";
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(135, 36);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(303, 23);
            comboBox1.TabIndex = 2;
            comboBox1.ValueMember = "Id";
            // 
            // team1BindingSource
            // 
            team1BindingSource.DataSource = typeof(DataModel.DataModels.Team);
            // 
            // comboBox2
            // 
            comboBox2.DataBindings.Add(new Binding("SelectedValue", bindingSource_matchDetail, "Team2Id", true));
            comboBox2.DataSource = team2BindingSource;
            comboBox2.DisplayMember = "Name";
            comboBox2.Dock = DockStyle.Fill;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(578, 36);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(303, 23);
            comboBox2.TabIndex = 2;
            comboBox2.ValueMember = "Id";
            // 
            // team2BindingSource
            // 
            team2BindingSource.DataSource = typeof(DataModel.DataModels.Team);
            // 
            // numericUpDown1
            // 
            numericUpDown1.DataBindings.Add(new Binding("Value", bindingSource_matchDetail, "TeamOneScore", true));
            numericUpDown1.Dock = DockStyle.Fill;
            numericUpDown1.Location = new Point(445, 36);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(44, 23);
            numericUpDown1.TabIndex = 3;
            // 
            // numericUpDown2
            // 
            numericUpDown2.DataBindings.Add(new Binding("Value", bindingSource_matchDetail, "TeamTwoScore", true));
            numericUpDown2.Dock = DockStyle.Fill;
            numericUpDown2.Location = new Point(527, 36);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(44, 23);
            numericUpDown2.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(496, 33);
            label6.Name = "label6";
            label6.Size = new Size(24, 31);
            label6.TabIndex = 4;
            label6.Text = "VS";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox3
            // 
            tableLayoutPanel1.SetColumnSpan(comboBox3, 5);
            comboBox3.DataBindings.Add(new Binding("SelectedValue", bindingSource_matchDetail, "TournamentId", true));
            comboBox3.DataSource = tournamentBindingSource;
            comboBox3.DisplayMember = "Name";
            comboBox3.Dock = DockStyle.Fill;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(135, 68);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(746, 23);
            comboBox3.TabIndex = 5;
            comboBox3.ValueMember = "Id";
            // 
            // tournamentBindingSource
            // 
            tournamentBindingSource.DataSource = typeof(DataModel.DataModels.Tournament);
            // 
            // comboBox4
            // 
            tableLayoutPanel1.SetColumnSpan(comboBox4, 5);
            comboBox4.DataBindings.Add(new Binding("SelectedValue", bindingSource_matchDetail, "FieldId", true));
            comboBox4.DataSource = fieldsBindingSource;
            comboBox4.DisplayMember = "Name";
            comboBox4.Dock = DockStyle.Fill;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(135, 100);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(746, 23);
            comboBox4.TabIndex = 6;
            comboBox4.ValueMember = "Id";
            // 
            // fieldsBindingSource
            // 
            fieldsBindingSource.DataSource = typeof(DataModel.DataModels.Field);
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            saveButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            saveButton.Location = new Point(719, 140);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(167, 34);
            saveButton.TabIndex = 2;
            saveButton.Text = "Save Changes";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // addButton
            // 
            addButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addButton.Location = new Point(136, 139);
            addButton.Name = "addButton";
            addButton.Size = new Size(171, 34);
            addButton.TabIndex = 3;
            addButton.Text = "Create New Match";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // matchesMenu
            // 
            matchesMenu.Items.AddRange(new ToolStripItem[] { editButton, deleteButton2 });
            matchesMenu.Name = "matchesMenu";
            matchesMenu.Size = new Size(108, 48);
            // 
            // editButton
            // 
            editButton.Name = "editButton";
            editButton.Size = new Size(107, 22);
            editButton.Text = "Edit";
            editButton.Click += editButton_Click;
            // 
            // deleteButton2
            // 
            deleteButton2.Name = "deleteButton2";
            deleteButton2.Size = new Size(107, 22);
            deleteButton2.Text = "Delete";
            deleteButton2.Click += deleteButton2_Click;
            // 
            // MatchesWindow2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 559);
            Controls.Add(addButton);
            Controls.Add(saveButton);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dataGridView1);
            Name = "MatchesWindow2";
            Text = " ";
            Load += MatchesWindow2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)matchDetailBindingSource).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource_matchDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)team1BindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)team2BindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)tournamentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)fieldsBindingSource).EndInit();
            matchesMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource matchDetailBindingSource;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label6;
        private ComboBox comboBox3;
        private Button saveButton;
        private Button addButton;
        private ComboBox comboBox4;
        private BindingSource bindingSource_matchDetail;
        private BindingSource team1BindingSource;
        private BindingSource team2BindingSource;
        private BindingSource tournamentBindingSource;
        private BindingSource fieldsBindingSource;
        private ContextMenuStrip matchesMenu;
        private ToolStripMenuItem editButton;
        private ToolStripMenuItem deleteButton2;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn matchNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tournamentNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fieldNameDataGridViewTextBoxColumn;
    }
}