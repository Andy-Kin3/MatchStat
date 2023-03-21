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
            button_saveGoal = new Button();
            ucSingleGoal1 = new UserControls.UcSingleGoal();
            SuspendLayout();
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
            // ucSingleGoal1
            // 
            ucSingleGoal1.Location = new Point(-3, -5);
            ucSingleGoal1.Name = "ucSingleGoal1";
            ucSingleGoal1.Size = new Size(751, 105);
            ucSingleGoal1.TabIndex = 2;
            // 
            // GoalRecordInput
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 163);
            Controls.Add(ucSingleGoal1);
            Controls.Add(button_saveGoal);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "GoalRecordInput";
            Text = "Goal Record Input";
            Load += GoalRecordInput_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button button_saveGoal;
        private UserControls.UcSingleGoal ucSingleGoal1;
    }
}