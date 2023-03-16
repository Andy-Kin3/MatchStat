namespace MatchStat.UI
{
    partial class TeamsWindow
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
            teamName = new TextBox();
            teamBindingSource = new BindingSource(components);
            createbutton = new Button();
            deleteTeamButton = new Button();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)teamBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(2, 9);
            label1.Name = "label1";
            label1.Size = new Size(67, 23);
            label1.TabIndex = 0;
            label1.Text = "Team :";
            // 
            // teamName
            // 
            teamName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            teamName.Location = new Point(75, 7);
            teamName.Multiline = true;
            teamName.Name = "teamName";
            teamName.Size = new Size(377, 29);
            teamName.TabIndex = 1;
            // 
            // teamBindingSource
            // 
            teamBindingSource.DataSource = typeof(DataModel.DataModels.Team);
            // 
            // createbutton
            // 
            createbutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            createbutton.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            createbutton.Location = new Point(467, 9);
            createbutton.Name = "createbutton";
            createbutton.Size = new Size(104, 27);
            createbutton.TabIndex = 2;
            createbutton.Text = "Create";
            createbutton.UseVisualStyleBackColor = true;
            createbutton.Click += createbutton_Click;
            // 
            // deleteTeamButton
            // 
            deleteTeamButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deleteTeamButton.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            deleteTeamButton.Location = new Point(582, 8);
            deleteTeamButton.Name = "deleteTeamButton";
            deleteTeamButton.Size = new Size(138, 27);
            deleteTeamButton.TabIndex = 3;
            deleteTeamButton.Text = "Delete Selected";
            deleteTeamButton.UseVisualStyleBackColor = true;
            deleteTeamButton.Click += deleteTeamButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn });
            dataGridView1.DataSource = teamBindingSource;
            dataGridView1.Location = new Point(0, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(731, 368);
            dataGridView1.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.FillWeight = 45.68528F;
            idDataGridViewTextBoxColumn.Frozen = true;
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 55;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.FillWeight = 127.1574F;
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // TeamsWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(731, 410);
            Controls.Add(dataGridView1);
            Controls.Add(deleteTeamButton);
            Controls.Add(createbutton);
            Controls.Add(teamName);
            Controls.Add(label1);
            Location = new Point(592, 400);
            MinimumSize = new Size(747, 449);
            Name = "TeamsWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teams";
            Load += Teams_Load;
            ((System.ComponentModel.ISupportInitialize)teamBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox teamName;
        private Button createbutton;
        private Button deleteTeamButton;
        private DataGridView dataGridView1;
        private BindingSource teamBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}