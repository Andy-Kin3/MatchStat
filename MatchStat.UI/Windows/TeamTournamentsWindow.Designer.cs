namespace MatchStat.UI
{
    partial class TeamTournamentsWindow
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
            label1 = new Label();
            label2 = new Label();
            comboTeam = new ComboBox();
            teamBindingSource = new BindingSource(components);
            teamTournamentBindingSource = new BindingSource(components);
            comboTournament = new ComboBox();
            tournamentBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            teamIdColumn = new DataGridViewTextBoxColumn();
            tournamentIdColumn = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            removeButton = new Button();
            assignButton = new Button();
            teamTourMenu = new ContextMenuStrip(components);
            editButton = new ToolStripMenuItem();
            updateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)teamBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teamTournamentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tournamentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            teamTourMenu.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(131, 32);
            label1.TabIndex = 1;
            label1.Text = "Team :";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 32);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(137, 32);
            label2.TabIndex = 3;
            label2.Text = "Tournament :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboTeam
            // 
            comboTeam.DataBindings.Add(new Binding("Text", teamBindingSource, "Name", true));
            comboTeam.DataBindings.Add(new Binding("SelectedValue", teamBindingSource, "Name", true));
            comboTeam.DataSource = teamBindingSource;
            comboTeam.DisplayMember = "Name";
            comboTeam.Dock = DockStyle.Fill;
            comboTeam.Font = new Font("Times New Roman", 15F, FontStyle.Italic, GraphicsUnit.Point);
            comboTeam.FormattingEnabled = true;
            comboTeam.Location = new Point(140, 3);
            comboTeam.Name = "comboTeam";
            comboTeam.Size = new Size(595, 30);
            comboTeam.TabIndex = 6;
            comboTeam.ValueMember = "Id";
            // 
            // teamBindingSource
            // 
            teamBindingSource.DataSource = typeof(DataModel.DataModels.Team);
            // 
            // teamTournamentBindingSource
            // 
            teamTournamentBindingSource.DataSource = typeof(DataModel.DataModels.TeamTournament);
            // 
            // comboTournament
            // 
            comboTournament.AllowDrop = true;
            comboTournament.DataBindings.Add(new Binding("Text", teamTournamentBindingSource, "TournamentId", true));
            comboTournament.DataBindings.Add(new Binding("SelectedValue", tournamentBindingSource, "Name", true));
            comboTournament.DataSource = tournamentBindingSource;
            comboTournament.DisplayMember = "Name";
            comboTournament.Dock = DockStyle.Fill;
            comboTournament.Font = new Font("Times New Roman", 15F, FontStyle.Italic, GraphicsUnit.Point);
            comboTournament.FormattingEnabled = true;
            comboTournament.Location = new Point(140, 35);
            comboTournament.MaxDropDownItems = 30;
            comboTournament.MinimumSize = new Size(255, 0);
            comboTournament.Name = "comboTournament";
            comboTournament.Size = new Size(595, 30);
            comboTournament.TabIndex = 7;
            comboTournament.ValueMember = "Id";
            // 
            // tournamentBindingSource
            // 
            tournamentBindingSource.DataSource = typeof(DataModel.DataModels.Tournament);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { teamIdColumn, tournamentIdColumn });
            dataGridView1.DataSource = teamTournamentBindingSource;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(738, 348);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellFormatting += DataGridView_CellFormatting;
            // 
            // teamIdColumn
            // 
            teamIdColumn.DataPropertyName = "TeamId";
            teamIdColumn.HeaderText = "Team";
            teamIdColumn.Name = "teamIdColumn";
            teamIdColumn.ReadOnly = true;
            // 
            // tournamentIdColumn
            // 
            tournamentIdColumn.DataPropertyName = "TournamentId";
            tournamentIdColumn.HeaderText = "Tournament";
            tournamentIdColumn.Name = "tournamentIdColumn";
            tournamentIdColumn.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.5800343F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.41997F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(comboTournament, 1, 1);
            tableLayoutPanel1.Controls.Add(comboTeam, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(738, 64);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // removeButton
            // 
            removeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            removeButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            removeButton.Location = new Point(548, 71);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(178, 34);
            removeButton.TabIndex = 11;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // assignButton
            // 
            assignButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            assignButton.Location = new Point(12, 71);
            assignButton.Name = "assignButton";
            assignButton.Size = new Size(185, 34);
            assignButton.TabIndex = 10;
            assignButton.Text = "Add";
            assignButton.UseVisualStyleBackColor = true;
            assignButton.Click += assignButton_Click;
            // 
            // teamTourMenu
            // 
            teamTourMenu.Items.AddRange(new ToolStripItem[] { editButton });
            teamTourMenu.Name = "matchesMenu";
            teamTourMenu.Size = new Size(95, 26);
            // 
            // editButton
            // 
            editButton.Name = "editButton";
            editButton.Size = new Size(94, 22);
            editButton.Text = "Edit";
            editButton.Click += editButton_Click;
            // 
            // updateButton
            // 
            updateButton.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            updateButton.Location = new Point(279, 70);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(186, 34);
            updateButton.TabIndex = 12;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // TeamTournamentsWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(738, 459);
            Controls.Add(updateButton);
            Controls.Add(removeButton);
            Controls.Add(assignButton);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dataGridView1);
            Location = new Point(592, 400);
            MinimumSize = new Size(754, 498);
            Name = "TeamTournamentsWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TeamTournaments";
            Load += TeamTournaments_Load;
            ((System.ComponentModel.ISupportInitialize)teamBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)teamTournamentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)tournamentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            teamTourMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private ComboBox comboTeam;
        private ComboBox comboTournament;
        private BindingSource teamBindingSource;
        private BindingSource tournamentBindingSource;
        private BindingSource teamTournamentBindingSource;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button removeButton;
        private Button assignButton;
        private ContextMenuStrip teamTourMenu;
        private ToolStripMenuItem editButton;
        private DataGridViewTextBoxColumn teamIdColumn;
        private DataGridViewTextBoxColumn tournamentIdColumn;
        private Button updateButton;
    }
}