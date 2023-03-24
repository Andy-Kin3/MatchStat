namespace MatchStat.UI.Windows
{
    partial class MatchRecordInput
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
            matchDetailBindingSource = new BindingSource(components);
            teamBindingSource = new BindingSource(components);
            teamBindingSource1 = new BindingSource(components);
            tournamentBindingSource = new BindingSource(components);
            fieldsBindingSource = new BindingSource(components);
            button_SaveMatch = new Button();
            ucSingleMatch = new UserControls.UcSingleMatch(this._teamsRepository, this._turnamentsRepository, this._fieldsRepository);
            ((System.ComponentModel.ISupportInitialize)matchDetailBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teamBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teamBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tournamentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fieldsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // matchDetailBindingSource
            // 
            matchDetailBindingSource.DataSource = typeof(DataModel.DataModels.MatchDetail);
            // 
            // teamBindingSource
            // 
            teamBindingSource.DataSource = typeof(DataModel.DataModels.Team);
            // 
            // teamBindingSource1
            // 
            teamBindingSource1.DataSource = typeof(DataModel.DataModels.Team);
            // 
            // tournamentBindingSource
            // 
            tournamentBindingSource.DataSource = typeof(DataModel.DataModels.Tournament);
            // 
            // fieldsBindingSource
            // 
            fieldsBindingSource.DataSource = typeof(DataModel.DataModels.Field);
            // 
            // button_SaveMatch
            // 
            button_SaveMatch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_SaveMatch.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button_SaveMatch.Location = new Point(585, 138);
            button_SaveMatch.Name = "button_SaveMatch";
            button_SaveMatch.Size = new Size(188, 56);
            button_SaveMatch.TabIndex = 1;
            button_SaveMatch.Text = "Save Match";
            button_SaveMatch.UseVisualStyleBackColor = true;
            button_SaveMatch.Click += saveMatchButton_Click;
            // 
            // ucSingleMatch
            // 
            ucSingleMatch.Dock = DockStyle.Top;
            ucSingleMatch.Location = new Point(0, 0);
            ucSingleMatch.Name = "ucSingleMatch";
            ucSingleMatch.Size = new Size(777, 132);
            ucSingleMatch.TabIndex = 2;
            // 
            // MatchRecordInput
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(777, 207);
            Controls.Add(ucSingleMatch);
            Controls.Add(button_SaveMatch);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "MatchRecordInput";
            Text = "Match Record Input";
            Load += MatchRecordInput_Load;
            ((System.ComponentModel.ISupportInitialize)matchDetailBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)teamBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)teamBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tournamentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)fieldsBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource matchDetailBindingSource;
        private BindingSource teamBindingSource;
        private BindingSource teamBindingSource1;
        private BindingSource tournamentBindingSource;
        private BindingSource fieldsBindingSource;
        private Button button_SaveMatch;
        private UserControls.UcSingleMatch ucSingleMatch;
    }
}