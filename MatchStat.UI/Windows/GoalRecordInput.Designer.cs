using MatchStat.DataModel.DataModels;

namespace MatchStat.UI
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
            Goal goal1 = new Goal();
            button_saveGoal = new Button();
            ucSingleGoal2 = new UserControls.UcSingleGoal(_matchesRepo, _playersRepo);
            SuspendLayout();
            // 
            // button_saveGoal
            // 
            button_saveGoal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_saveGoal.Location = new Point(538, 111);
            button_saveGoal.Name = "button_saveGoal";
            button_saveGoal.Size = new Size(186, 44);
            button_saveGoal.TabIndex = 1;
            button_saveGoal.Text = "Save Goal";
            button_saveGoal.UseVisualStyleBackColor = true;
            button_saveGoal.Click += button_saveGoal_Click;
            // 
            // ucSingleGoal2
            // 
            ucSingleGoal2.Dock = DockStyle.Top;
            goal1.Id = 0;
            goal1.MatchId = 0;
            goal1.MatchName = null;
            goal1.NumberOfGoal = 0;
            goal1.Player = null;
            goal1.PlayerId = 0;
            goal1.PlayerName = null;
            ucSingleGoal2.Goal = goal1;
            ucSingleGoal2.Location = new Point(0, 0);
            ucSingleGoal2.Name = "ucSingleGoal2";
            ucSingleGoal2.Size = new Size(736, 105);
            ucSingleGoal2.TabIndex = 2;
            // 
            // GoalRecordInput
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 163);
            Controls.Add(ucSingleGoal2);
            Controls.Add(button_saveGoal);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "GoalRecordInput";
            Text = "Goal Window";
            Load += GoalRecordInput_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button button_saveGoal;
        private UserControls.UcSingleGoal ucSingleGoal1;
        private UserControls.UcSingleGoal ucSingleGoal2;
    }
}