namespace MatchStat.UI
{
    partial class Players
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
            this.playerFName = new System.Windows.Forms.Label();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playerFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.playerLName = new System.Windows.Forms.Label();
            this.playerLastName = new System.Windows.Forms.TextBox();
            this.createPlayerButton = new System.Windows.Forms.Button();
            this.deletePlayerButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goalsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamCbo = new System.Windows.Forms.ComboBox();
            this.teamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // playerFName
            // 
            this.playerFName.AutoSize = true;
            this.playerFName.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.playerFName.Location = new System.Drawing.Point(12, 16);
            this.playerFName.Name = "playerFName";
            this.playerFName.Size = new System.Drawing.Size(83, 17);
            this.playerFName.TabIndex = 0;
            this.playerFName.Text = "First Name :";
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(MatchStat.DataModel.DataModels.Player);
            // 
            // playerFirstName
            // 
            this.playerFirstName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.playerFirstName.Location = new System.Drawing.Point(101, 16);
            this.playerFirstName.Name = "playerFirstName";
            this.playerFirstName.Size = new System.Drawing.Size(253, 23);
            this.playerFirstName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(384, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date of Birth :";
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.dateOfBirth.Location = new System.Drawing.Point(485, 16);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(211, 23);
            this.dateOfBirth.TabIndex = 4;
            // 
            // playerLName
            // 
            this.playerLName.AutoSize = true;
            this.playerLName.Font = new System.Drawing.Font("Times New Roman", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.playerLName.Location = new System.Drawing.Point(12, 52);
            this.playerLName.Name = "playerLName";
            this.playerLName.Size = new System.Drawing.Size(81, 17);
            this.playerLName.TabIndex = 5;
            this.playerLName.Text = "Last Name :";
            // 
            // playerLastName
            // 
            this.playerLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.playerLastName.Location = new System.Drawing.Point(99, 50);
            this.playerLastName.Name = "playerLastName";
            this.playerLastName.Size = new System.Drawing.Size(148, 23);
            this.playerLastName.TabIndex = 6;
            // 
            // createPlayerButton
            // 
            this.createPlayerButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.createPlayerButton.Location = new System.Drawing.Point(485, 47);
            this.createPlayerButton.Name = "createPlayerButton";
            this.createPlayerButton.Size = new System.Drawing.Size(108, 28);
            this.createPlayerButton.TabIndex = 7;
            this.createPlayerButton.Text = "Create";
            this.createPlayerButton.UseVisualStyleBackColor = true;
            this.createPlayerButton.Click += new System.EventHandler(this.createPlayerButton_Click);
            // 
            // deletePlayerButton
            // 
            this.deletePlayerButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.deletePlayerButton.Location = new System.Drawing.Point(599, 49);
            this.deletePlayerButton.Name = "deletePlayerButton";
            this.deletePlayerButton.Size = new System.Drawing.Size(143, 28);
            this.deletePlayerButton.TabIndex = 8;
            this.deletePlayerButton.Text = "Delete Selected";
            this.deletePlayerButton.UseVisualStyleBackColor = true;
            this.deletePlayerButton.Click += new System.EventHandler(this.deletePlayerButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.teamIdDataGridViewTextBoxColumn,
            this.goalsDataGridViewTextBoxColumn,
            this.teamDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.playerBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(753, 331);
            this.dataGridView1.TabIndex = 9;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "Dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "Dob";
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            // 
            // teamIdDataGridViewTextBoxColumn
            // 
            this.teamIdDataGridViewTextBoxColumn.DataPropertyName = "TeamId";
            this.teamIdDataGridViewTextBoxColumn.HeaderText = "TeamId";
            this.teamIdDataGridViewTextBoxColumn.Name = "teamIdDataGridViewTextBoxColumn";
            // 
            // goalsDataGridViewTextBoxColumn
            // 
            this.goalsDataGridViewTextBoxColumn.DataPropertyName = "Goals";
            this.goalsDataGridViewTextBoxColumn.HeaderText = "Goals";
            this.goalsDataGridViewTextBoxColumn.Name = "goalsDataGridViewTextBoxColumn";
            this.goalsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teamDataGridViewTextBoxColumn
            // 
            this.teamDataGridViewTextBoxColumn.DataPropertyName = "Team";
            this.teamDataGridViewTextBoxColumn.HeaderText = "Team";
            this.teamDataGridViewTextBoxColumn.Name = "teamDataGridViewTextBoxColumn";
            // 
            // teamCbo
            // 
            this.teamCbo.DataSource = this.teamBindingSource;
            this.teamCbo.DisplayMember = "Name";
            this.teamCbo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.teamCbo.FormattingEnabled = true;
            this.teamCbo.Location = new System.Drawing.Point(310, 51);
            this.teamCbo.Name = "teamCbo";
            this.teamCbo.Size = new System.Drawing.Size(151, 23);
            this.teamCbo.TabIndex = 10;
            this.teamCbo.ValueMember = "Id";
            // 
            // teamBindingSource
            // 
            this.teamBindingSource.DataSource = typeof(MatchStat.DataModel.DataModels.Team);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(263, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Team";
            // 
            // Players
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(753, 423);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teamCbo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deletePlayerButton);
            this.Controls.Add(this.createPlayerButton);
            this.Controls.Add(this.playerLastName);
            this.Controls.Add(this.playerLName);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playerFirstName);
            this.Controls.Add(this.playerFName);
            this.Location = new System.Drawing.Point(592, 400);
            this.MaximumSize = new System.Drawing.Size(769, 462);
            this.MinimumSize = new System.Drawing.Size(769, 462);
            this.Name = "Players";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PlayerInfo";
            this.Load += new System.EventHandler(this.Players_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Button createPlayerButton;
        private Button deletePlayerButton;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn teamIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn goalsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn teamDataGridViewTextBoxColumn;
        private ComboBox teamCbo;
        private Label label1;
        private BindingSource teamBindingSource;
    }
}