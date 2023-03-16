namespace MatchStat.UI
{
    partial class PlayersWindow
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            playerFName = new Label();
            playerBindingSource = new BindingSource(components);
            playerFirstName = new TextBox();
            label2 = new Label();
            dateOfBirth = new DateTimePicker();
            playerLName = new Label();
            playerLastName = new TextBox();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dobDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            TeamName = new DataGridViewTextBoxColumn();
            teamBindingSource = new BindingSource(components);
            teamCbo = new ComboBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            deletePlayerButton = new Button();
            createPlayerButton = new Button();
            ((System.ComponentModel.ISupportInitialize)playerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teamBindingSource).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // playerFName
            // 
            playerFName.AutoSize = true;
            playerFName.Dock = DockStyle.Fill;
            playerFName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            playerFName.Location = new Point(3, 0);
            playerFName.Name = "playerFName";
            playerFName.Size = new Size(94, 37);
            playerFName.TabIndex = 0;
            playerFName.Text = "First Name :";
            playerFName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playerBindingSource
            // 
            playerBindingSource.DataSource = typeof(DataModel.DataModels.Player);
            // 
            // playerFirstName
            // 
            playerFirstName.Dock = DockStyle.Fill;
            playerFirstName.Font = new Font("Times New Roman", 10F, FontStyle.Italic, GraphicsUnit.Point);
            playerFirstName.Location = new Point(103, 3);
            playerFirstName.Name = "playerFirstName";
            playerFirstName.Size = new Size(265, 23);
            playerFirstName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(374, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 37);
            label2.TabIndex = 3;
            label2.Text = "Date of Birth :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateOfBirth
            // 
            dateOfBirth.Dock = DockStyle.Fill;
            dateOfBirth.Font = new Font("Times New Roman", 10F, FontStyle.Italic, GraphicsUnit.Point);
            dateOfBirth.Location = new Point(484, 3);
            dateOfBirth.Name = "dateOfBirth";
            dateOfBirth.Size = new Size(266, 23);
            dateOfBirth.TabIndex = 4;
            // 
            // playerLName
            // 
            playerLName.AutoSize = true;
            playerLName.Dock = DockStyle.Fill;
            playerLName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            playerLName.Location = new Point(3, 37);
            playerLName.Name = "playerLName";
            playerLName.Size = new Size(94, 37);
            playerLName.TabIndex = 5;
            playerLName.Text = "Last Name :";
            playerLName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playerLastName
            // 
            playerLastName.Dock = DockStyle.Fill;
            playerLastName.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Italic, GraphicsUnit.Point);
            playerLastName.Location = new Point(103, 40);
            playerLastName.Multiline = true;
            playerLastName.Name = "playerLastName";
            playerLastName.Size = new Size(265, 31);
            playerLastName.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(128, 255, 255);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, dobDataGridViewTextBoxColumn, TeamName });
            dataGridView1.DataSource = playerBindingSource;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 129);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(753, 294);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.Frozen = true;
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 55;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // dobDataGridViewTextBoxColumn
            // 
            dobDataGridViewTextBoxColumn.DataPropertyName = "Dob";
            dobDataGridViewTextBoxColumn.HeaderText = "Date Of Birth";
            dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            // 
            // TeamName
            // 
            TeamName.DataPropertyName = "TeamId";
            TeamName.HeaderText = "Team Name";
            TeamName.Name = "TeamName";
            // 
            // teamBindingSource
            // 
            teamBindingSource.DataSource = typeof(DataModel.DataModels.Team);
            // 
            // teamCbo
            // 
            teamCbo.DataBindings.Add(new Binding("SelectedValue", playerBindingSource, "TeamId", true));
            teamCbo.DataSource = teamBindingSource;
            teamCbo.DisplayMember = "Name";
            teamCbo.Dock = DockStyle.Fill;
            teamCbo.Font = new Font("Times New Roman", 10F, FontStyle.Italic, GraphicsUnit.Point);
            teamCbo.FormattingEnabled = true;
            teamCbo.Location = new Point(484, 40);
            teamCbo.Name = "teamCbo";
            teamCbo.Size = new Size(266, 23);
            teamCbo.TabIndex = 10;
            teamCbo.ValueMember = "Id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(374, 37);
            label1.Name = "label1";
            label1.Size = new Size(104, 37);
            label1.TabIndex = 11;
            label1.Text = "Team :";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(playerFName, 0, 0);
            tableLayoutPanel1.Controls.Add(teamCbo, 3, 1);
            tableLayoutPanel1.Controls.Add(label1, 2, 1);
            tableLayoutPanel1.Controls.Add(playerLName, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 2, 0);
            tableLayoutPanel1.Controls.Add(playerFirstName, 1, 0);
            tableLayoutPanel1.Controls.Add(dateOfBirth, 3, 0);
            tableLayoutPanel1.Controls.Add(playerLastName, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(753, 74);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // deletePlayerButton
            // 
            deletePlayerButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deletePlayerButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            deletePlayerButton.Location = new Point(582, 81);
            deletePlayerButton.Name = "deletePlayerButton";
            deletePlayerButton.Size = new Size(157, 42);
            deletePlayerButton.TabIndex = 14;
            deletePlayerButton.Text = "Delete Selected";
            deletePlayerButton.UseVisualStyleBackColor = true;
            deletePlayerButton.Click += deletePlayerButton_Click;
            // 
            // createPlayerButton
            // 
            createPlayerButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            createPlayerButton.Location = new Point(103, 81);
            createPlayerButton.Name = "createPlayerButton";
            createPlayerButton.Size = new Size(131, 42);
            createPlayerButton.TabIndex = 13;
            createPlayerButton.Text = "Create";
            createPlayerButton.UseVisualStyleBackColor = true;
            createPlayerButton.Click += createPlayerButton_Click;
            // 
            // PlayersWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(753, 423);
            Controls.Add(deletePlayerButton);
            Controls.Add(createPlayerButton);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dataGridView1);
            Location = new Point(592, 400);
            MinimumSize = new Size(769, 462);
            Name = "PlayersWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PlayerInfo";
            Load += Players_Load;
            ((System.ComponentModel.ISupportInitialize)playerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)teamBindingSource).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label playerFName;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private BindingSource playerBindingSource;
        private TextBox playerFirstName;
        private TextBox playerLastName;
        private Label label2;
        private DateTimePicker dateOfBirth;
        private Label playerLName;
        private DataGridView dataGridView1;
        private ComboBox teamCbo;
        private Label label1;
        private BindingSource teamBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn TeamName;
        private TableLayoutPanel tableLayoutPanel1;
        private Button deletePlayerButton;
        private Button createPlayerButton;
    }
}