namespace MatchStat.UI.Windows
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tournamentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bindingSource_matchDetail = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.team1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.team2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.tournamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.fieldsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.idvalue = new System.Windows.Forms.NumericUpDown();
            this.saveButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.matchesMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editButton = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteButton2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchDetailBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_matchDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.team1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.team2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idvalue)).BeginInit();
            this.matchesMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.dateDataGridViewTextBoxColumn,
            this.matchNameDataGridViewTextBoxColumn,
            this.tournamentNameDataGridViewTextBoxColumn,
            this.fieldNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.matchDetailBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 180);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(885, 379);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseUp);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matchNameDataGridViewTextBoxColumn
            // 
            this.matchNameDataGridViewTextBoxColumn.DataPropertyName = "MatchName";
            this.matchNameDataGridViewTextBoxColumn.HeaderText = "MatchName";
            this.matchNameDataGridViewTextBoxColumn.Name = "matchNameDataGridViewTextBoxColumn";
            this.matchNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tournamentNameDataGridViewTextBoxColumn
            // 
            this.tournamentNameDataGridViewTextBoxColumn.DataPropertyName = "TournamentName";
            this.tournamentNameDataGridViewTextBoxColumn.HeaderText = "TournamentName";
            this.tournamentNameDataGridViewTextBoxColumn.Name = "tournamentNameDataGridViewTextBoxColumn";
            this.tournamentNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fieldNameDataGridViewTextBoxColumn
            // 
            this.fieldNameDataGridViewTextBoxColumn.DataPropertyName = "FieldName";
            this.fieldNameDataGridViewTextBoxColumn.HeaderText = "FieldName";
            this.fieldNameDataGridViewTextBoxColumn.Name = "fieldNameDataGridViewTextBoxColumn";
            this.fieldNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matchDetailBindingSource
            // 
            this.matchDetailBindingSource.DataSource = typeof(MatchStat.DataModel.DataModels.MatchDetail);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox2, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown2, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBox4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.idvalue, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(872, 131);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Match Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(4, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Match";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(4, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tournament";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(4, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Field";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.dateTimePicker1, 5);
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource_matchDetail, "Date", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Location = new System.Drawing.Point(135, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(733, 23);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // bindingSource_matchDetail
            // 
            this.bindingSource_matchDetail.DataSource = typeof(MatchStat.DataModel.DataModels.MatchDetail);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource_matchDetail, "Team1Id", true));
            this.comboBox1.DataSource = this.team1BindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(135, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(296, 23);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "Id";
            // 
            // team1BindingSource
            // 
            this.team1BindingSource.DataSource = typeof(MatchStat.DataModel.DataModels.Team);
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource_matchDetail, "Team2Id", true));
            this.comboBox2.DataSource = this.team2BindingSource;
            this.comboBox2.DisplayMember = "Name";
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(571, 31);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(297, 23);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.ValueMember = "Id";
            // 
            // team2BindingSource
            // 
            this.team2BindingSource.DataSource = typeof(MatchStat.DataModel.DataModels.Team);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource_matchDetail, "TeamOneScore", true));
            this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown1.Location = new System.Drawing.Point(438, 31);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(44, 23);
            this.numericUpDown1.TabIndex = 3;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource_matchDetail, "TeamTwoScore", true));
            this.numericUpDown2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown2.Location = new System.Drawing.Point(520, 31);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(44, 23);
            this.numericUpDown2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(489, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 26);
            this.label6.TabIndex = 4;
            this.label6.Text = "VS";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.comboBox3, 5);
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource_matchDetail, "TournamentId", true));
            this.comboBox3.DataSource = this.tournamentBindingSource;
            this.comboBox3.DisplayMember = "Name";
            this.comboBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(135, 58);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(733, 23);
            this.comboBox3.TabIndex = 5;
            this.comboBox3.ValueMember = "Id";
            // 
            // tournamentBindingSource
            // 
            this.tournamentBindingSource.DataSource = typeof(MatchStat.DataModel.DataModels.Tournament);
            // 
            // comboBox4
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.comboBox4, 5);
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource_matchDetail, "FieldId", true));
            this.comboBox4.DataSource = this.fieldsBindingSource;
            this.comboBox4.DisplayMember = "Name";
            this.comboBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(135, 85);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(733, 23);
            this.comboBox4.TabIndex = 6;
            this.comboBox4.ValueMember = "Id";
            // 
            // fieldsBindingSource
            // 
            this.fieldsBindingSource.DataSource = typeof(MatchStat.DataModel.DataModels.Fields);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "ID";
            // 
            // idvalue
            // 
            this.idvalue.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.matchDetailBindingSource, "Id", true));
            this.idvalue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idvalue.Location = new System.Drawing.Point(135, 112);
            this.idvalue.Name = "idvalue";
            this.idvalue.Size = new System.Drawing.Size(296, 23);
            this.idvalue.TabIndex = 8;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(719, 140);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(167, 34);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.Location = new System.Drawing.Point(136, 139);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(171, 34);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Creat New Match";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // matchesMenu
            // 
            this.matchesMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editButton,
            this.deleteButton2});
            this.matchesMenu.Name = "matchesMenu";
            this.matchesMenu.Size = new System.Drawing.Size(108, 48);
            // 
            // editButton
            // 
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(107, 22);
            this.editButton.Text = "Edit";
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton2
            // 
            this.deleteButton2.Name = "deleteButton2";
            this.deleteButton2.Size = new System.Drawing.Size(107, 22);
            this.deleteButton2.Text = "Delete";
            this.deleteButton2.Click += new System.EventHandler(this.deleteButton2_Click);
            // 
            // MatchesWindow2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 559);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MatchesWindow2";
            this.Text = "Match";
            this.Load += new System.EventHandler(this.MatchesWindow2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchDetailBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_matchDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.team1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.team2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idvalue)).EndInit();
            this.matchesMenu.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private Label label5;
        private NumericUpDown idvalue;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn matchNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tournamentNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fieldNameDataGridViewTextBoxColumn;
    }
}