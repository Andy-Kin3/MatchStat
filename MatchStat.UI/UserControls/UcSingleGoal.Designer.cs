namespace MatchStat.UI.UserControls
{
    partial class UcSingleGoal
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
            comboBox_player = new ComboBox();
            goalBindingSource = new BindingSource(components);
            playerBindingSource = new BindingSource(components);
            comboBox_match = new ComboBox();
            matchDetailBindingSource = new BindingSource(components);
            numericUpDown_Goals = new NumericUpDown();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)goalBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)matchDetailBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Goals).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.6097145F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.39029F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(comboBox_player, 1, 0);
            tableLayoutPanel1.Controls.Add(comboBox_match, 1, 1);
            tableLayoutPanel1.Controls.Add(numericUpDown_Goals, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(602, 82);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 27);
            label1.TabIndex = 0;
            label1.Text = "Player";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 27);
            label2.Name = "label2";
            label2.Size = new Size(118, 27);
            label2.TabIndex = 1;
            label2.Text = "Match";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 54);
            label3.Name = "label3";
            label3.Size = new Size(118, 28);
            label3.TabIndex = 2;
            label3.Text = "Goal";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox_player
            // 
            comboBox_player.DataBindings.Add(new Binding("SelectedValue", goalBindingSource, "PlayerId", true));
            comboBox_player.DataSource = playerBindingSource;
            comboBox_player.DisplayMember = "FullName";
            comboBox_player.Dock = DockStyle.Fill;
            comboBox_player.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_player.FormattingEnabled = true;
            comboBox_player.Location = new Point(127, 3);
            comboBox_player.Name = "comboBox_player";
            comboBox_player.Size = new Size(472, 23);
            comboBox_player.TabIndex = 3;
            comboBox_player.ValueMember = "Id";
            // 
            // goalBindingSource
            // 
            goalBindingSource.DataSource = typeof(DataModel.DataModels.Goal);
            // 
            // playerBindingSource
            // 
            playerBindingSource.DataSource = typeof(DataModel.DataModels.Player);
            // 
            // comboBox_match
            // 
            comboBox_match.DataBindings.Add(new Binding("SelectedValue", goalBindingSource, "MatchId", true));
            comboBox_match.DataSource = matchDetailBindingSource;
            comboBox_match.DisplayMember = "MatchName";
            comboBox_match.Dock = DockStyle.Fill;
            comboBox_match.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_match.FormattingEnabled = true;
            comboBox_match.Location = new Point(127, 30);
            comboBox_match.Name = "comboBox_match";
            comboBox_match.Size = new Size(472, 23);
            comboBox_match.TabIndex = 4;
            comboBox_match.ValueMember = "Id";
            // 
            // matchDetailBindingSource
            // 
            matchDetailBindingSource.DataSource = typeof(DataModel.DataModels.MatchDetail);
            // 
            // numericUpDown_Goals
            // 
            numericUpDown_Goals.DataBindings.Add(new Binding("Value", goalBindingSource, "NumberOfGoal", true));
            numericUpDown_Goals.Dock = DockStyle.Fill;
            numericUpDown_Goals.Location = new Point(127, 57);
            numericUpDown_Goals.Name = "numericUpDown_Goals";
            numericUpDown_Goals.Size = new Size(472, 23);
            numericUpDown_Goals.TabIndex = 5;
            // 
            // UcSingleGoal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UcSingleGoal";
            Size = new Size(602, 82);
            Load += UcSingleGoal_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)goalBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)matchDetailBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Goals).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox_player;
        private BindingSource goalBindingSource;
        private BindingSource playerBindingSource;
        private ComboBox comboBox_match;
        private BindingSource matchDetailBindingSource;
        private NumericUpDown numericUpDown_Goals;
    }
}
