namespace MatchStat.UI.Windows
{
    partial class GoalRecordInput
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
            comboBox_player = new ComboBox();
            goalBindingSource = new BindingSource(components);
            playerBindingSource = new BindingSource(components);
            comboBox_match = new ComboBox();
            matchBindingSource = new BindingSource(components);
            numericUpDown_Goals = new NumericUpDown();
            matchDetailBindingSource = new BindingSource(components);
            button_saveGoal = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)goalBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)matchBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Goals).BeginInit();
            ((System.ComponentModel.ISupportInitialize)matchDetailBindingSource).BeginInit();
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
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(746, 99);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(145, 32);
            label1.TabIndex = 0;
            label1.Text = "Player";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 32);
            label2.Name = "label2";
            label2.Size = new Size(147, 32);
            label2.TabIndex = 1;
            label2.Text = "Match";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 64);
            label3.Name = "label3";
            label3.Size = new Size(147, 35);
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
            comboBox_player.Location = new Point(156, 3);
            comboBox_player.Name = "comboBox_player";
            comboBox_player.Size = new Size(587, 27);
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
            comboBox_match.Location = new Point(156, 35);
            comboBox_match.Name = "comboBox_match";
            comboBox_match.Size = new Size(587, 27);
            comboBox_match.TabIndex = 4;
            comboBox_match.ValueMember = "Id";
            // 
            // matchBindingSource
            // 
            matchBindingSource.DataSource = typeof(DataModel.DataModels.Match);
            // 
            // numericUpDown_Goals
            // 
            numericUpDown_Goals.Dock = DockStyle.Fill;
            numericUpDown_Goals.Location = new Point(156, 67);
            numericUpDown_Goals.Name = "numericUpDown_Goals";
            numericUpDown_Goals.Size = new Size(587, 26);
            numericUpDown_Goals.TabIndex = 5;
            // 
            // matchDetailBindingSource
            // 
            matchDetailBindingSource.DataSource = typeof(DataModel.DataModels.MatchDetail);
            // 
            // button_saveGoal
            // 
            button_saveGoal.Location = new Point(548, 106);
            button_saveGoal.Name = "button_saveGoal";
            button_saveGoal.Size = new Size(186, 44);
            button_saveGoal.TabIndex = 1;
            button_saveGoal.Text = "Save Goal";
            button_saveGoal.UseVisualStyleBackColor = true;
            button_saveGoal.Click += button_saveGoal_Click;
            // 
            // GoalRecordInput
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 156);
            Controls.Add(button_saveGoal);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "GoalRecordInput";
            Text = "GoalRecordInput";
            Load += GoalRecordInput_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)goalBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)matchBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Goals).EndInit();
            ((System.ComponentModel.ISupportInitialize)matchDetailBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox_player;
        private ComboBox comboBox_match;
        private BindingSource goalBindingSource;
        private NumericUpDown numericUpDown_Goals;
        private BindingSource playerBindingSource;
        private Button button_saveGoal;
        private BindingSource matchBindingSource;
        private BindingSource matchDetailBindingSource;
    }
}