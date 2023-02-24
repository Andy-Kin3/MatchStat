namespace MatchStat.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tournamentbutton = new System.Windows.Forms.Button();
            this.tournamentTeamsButton = new System.Windows.Forms.Button();
            this.teamButton = new System.Windows.Forms.Button();
            this.fieldButton = new System.Windows.Forms.Button();
            this.goalsButton = new System.Windows.Forms.Button();
            this.playerButton = new System.Windows.Forms.Button();
            this.MatchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tournamentbutton
            // 
            this.tournamentbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tournamentbutton.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tournamentbutton.Location = new System.Drawing.Point(398, 83);
            this.tournamentbutton.Name = "tournamentbutton";
            this.tournamentbutton.Size = new System.Drawing.Size(261, 55);
            this.tournamentbutton.TabIndex = 0;
            this.tournamentbutton.Text = "Set Tournaments";
            this.tournamentbutton.UseVisualStyleBackColor = true;
            this.tournamentbutton.Click += new System.EventHandler(this.tournamentbutton_Click);
            // 
            // tournamentTeamsButton
            // 
            this.tournamentTeamsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tournamentTeamsButton.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tournamentTeamsButton.Location = new System.Drawing.Point(723, 224);
            this.tournamentTeamsButton.Name = "tournamentTeamsButton";
            this.tournamentTeamsButton.Size = new System.Drawing.Size(270, 55);
            this.tournamentTeamsButton.TabIndex = 1;
            this.tournamentTeamsButton.Text = "Registered Teams(Tournaments)";
            this.tournamentTeamsButton.UseVisualStyleBackColor = true;
            this.tournamentTeamsButton.Click += new System.EventHandler(this.tournamentTeamsButton_Click);
            // 
            // teamButton
            // 
            this.teamButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.teamButton.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.teamButton.Location = new System.Drawing.Point(73, 224);
            this.teamButton.Name = "teamButton";
            this.teamButton.Size = new System.Drawing.Size(270, 55);
            this.teamButton.TabIndex = 2;
            this.teamButton.Text = "Competing Teams";
            this.teamButton.UseVisualStyleBackColor = true;
            this.teamButton.Click += new System.EventHandler(this.teamButton_Click);
            // 
            // fieldButton
            // 
            this.fieldButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fieldButton.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fieldButton.Location = new System.Drawing.Point(723, 83);
            this.fieldButton.Name = "fieldButton";
            this.fieldButton.Size = new System.Drawing.Size(270, 55);
            this.fieldButton.TabIndex = 3;
            this.fieldButton.Text = "Selected Fields";
            this.fieldButton.UseVisualStyleBackColor = true;
            this.fieldButton.Click += new System.EventHandler(this.fieldButton_Click);
            // 
            // goalsButton
            // 
            this.goalsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.goalsButton.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.goalsButton.Location = new System.Drawing.Point(73, 83);
            this.goalsButton.Name = "goalsButton";
            this.goalsButton.Size = new System.Drawing.Size(270, 55);
            this.goalsButton.TabIndex = 4;
            this.goalsButton.Text = "Goals";
            this.goalsButton.UseVisualStyleBackColor = true;
            this.goalsButton.Click += new System.EventHandler(this.goalsButton_Click);
            // 
            // playerButton
            // 
            this.playerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.playerButton.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playerButton.Location = new System.Drawing.Point(74, 369);
            this.playerButton.Name = "playerButton";
            this.playerButton.Size = new System.Drawing.Size(270, 55);
            this.playerButton.TabIndex = 5;
            this.playerButton.Text = "Participating Player";
            this.playerButton.UseVisualStyleBackColor = true;
            this.playerButton.Click += new System.EventHandler(this.playerButton_Click);
            // 
            // MatchButton
            // 
            this.MatchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MatchButton.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MatchButton.Location = new System.Drawing.Point(721, 369);
            this.MatchButton.Name = "MatchButton";
            this.MatchButton.Size = new System.Drawing.Size(270, 55);
            this.MatchButton.TabIndex = 6;
            this.MatchButton.Text = "Matches";
            this.MatchButton.UseVisualStyleBackColor = true;
            this.MatchButton.Click += new System.EventHandler(this.MatchButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1053, 505);
            this.Controls.Add(this.MatchButton);
            this.Controls.Add(this.playerButton);
            this.Controls.Add(this.goalsButton);
            this.Controls.Add(this.fieldButton);
            this.Controls.Add(this.teamButton);
            this.Controls.Add(this.tournamentTeamsButton);
            this.Controls.Add(this.tournamentbutton);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimumSize = new System.Drawing.Size(1069, 544);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Button tournamentbutton;
        private Button tournamentTeamsButton;
        private Button teamButton;
        private Button fieldButton;
        private Button goalsButton;
        private Button playerButton;
        private Button MatchButton;
    }
}