﻿namespace MatchStat.UI.Windows
{
    partial class MatchRecordWindow
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
            contextMenuStrip1 = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            createMatchButton = new Button();
            SaveMatchButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)matchDetailBindingSource).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, dateDataGridViewTextBoxColumn, matchNameDataGridViewTextBoxColumn, tournamentNameDataGridViewTextBoxColumn, fieldNameDataGridViewTextBoxColumn });
            dataGridView1.DataSource = matchDetailBindingSource;
            dataGridView1.Location = new Point(0, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(800, 398);
            dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
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
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(108, 48);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(107, 22);
            editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(107, 22);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // createMatchButton
            // 
            createMatchButton.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            createMatchButton.Location = new Point(12, 10);
            createMatchButton.Name = "createMatchButton";
            createMatchButton.Size = new Size(187, 34);
            createMatchButton.TabIndex = 2;
            createMatchButton.Text = "Create New Match";
            createMatchButton.UseVisualStyleBackColor = true;
            createMatchButton.Click += createMatchButton_Click;
            // 
            // SaveMatchButton
            // 
            SaveMatchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SaveMatchButton.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SaveMatchButton.Location = new Point(580, 10);
            SaveMatchButton.Name = "SaveMatchButton";
            SaveMatchButton.Size = new Size(195, 38);
            SaveMatchButton.TabIndex = 3;
            SaveMatchButton.Text = "Save Matches";
            SaveMatchButton.UseVisualStyleBackColor = true;
            // 
            // MatchRecordWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SaveMatchButton);
            Controls.Add(createMatchButton);
            Controls.Add(dataGridView1);
            Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "MatchRecordWindow";
            Text = "Match Record Window";
            Load += MatchRecordWindow_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)matchDetailBindingSource).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource matchDetailBindingSource;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn matchNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tournamentNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fieldNameDataGridViewTextBoxColumn;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Button createMatchButton;
        private Button SaveMatchButton;
    }
}