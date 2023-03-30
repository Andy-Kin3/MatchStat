
namespace MatchStat.Presentation
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.competingTeamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setTournamentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setTournamentsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedFieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.participatingPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1053, 30);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goalsToolStripMenuItem,
            this.competingTeamsToolStripMenuItem,
            this.setTournamentsToolStripMenuItem,
            this.setTournamentsToolStripMenuItem1,
            this.selectedFieldsToolStripMenuItem,
            this.participatingPlayerToolStripMenuItem,
            this.matchesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(66, 26);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // goalsToolStripMenuItem
            // 
            this.goalsToolStripMenuItem.Name = "goalsToolStripMenuItem";
            this.goalsToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.goalsToolStripMenuItem.Text = "Goals";
            this.goalsToolStripMenuItem.Click += new System.EventHandler(this.goalsToolStripMenuItem_Click);
            // 
            // competingTeamsToolStripMenuItem
            // 
            this.competingTeamsToolStripMenuItem.Name = "competingTeamsToolStripMenuItem";
            this.competingTeamsToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.competingTeamsToolStripMenuItem.Text = "Competing Teams";
            this.competingTeamsToolStripMenuItem.Click += new System.EventHandler(this.competingTeamsToolStripMenuItem_Click);
            // 
            // setTournamentsToolStripMenuItem
            // 
            this.setTournamentsToolStripMenuItem.Name = "setTournamentsToolStripMenuItem";
            this.setTournamentsToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.setTournamentsToolStripMenuItem.Text = "Set Tournaments";
            this.setTournamentsToolStripMenuItem.Click += new System.EventHandler(this.setTournamentsToolStripMenuItem_Click);
            // 
            // setTournamentsToolStripMenuItem1
            // 
            this.setTournamentsToolStripMenuItem1.Name = "setTournamentsToolStripMenuItem1";
            this.setTournamentsToolStripMenuItem1.Size = new System.Drawing.Size(316, 26);
            this.setTournamentsToolStripMenuItem1.Text = "Register Teams(Tournaments)";
            this.setTournamentsToolStripMenuItem1.Click += new System.EventHandler(this.setTournamentsToolStripMenuItem1_Click);
            // 
            // selectedFieldsToolStripMenuItem
            // 
            this.selectedFieldsToolStripMenuItem.Name = "selectedFieldsToolStripMenuItem";
            this.selectedFieldsToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.selectedFieldsToolStripMenuItem.Text = "Selected Fields";
            this.selectedFieldsToolStripMenuItem.Click += new System.EventHandler(this.selectedFieldsToolStripMenuItem_Click);
            // 
            // participatingPlayerToolStripMenuItem
            // 
            this.participatingPlayerToolStripMenuItem.Name = "participatingPlayerToolStripMenuItem";
            this.participatingPlayerToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.participatingPlayerToolStripMenuItem.Text = "Participating Player";
            this.participatingPlayerToolStripMenuItem.Click += new System.EventHandler(this.participatingPlayerToolStripMenuItem_Click);
            // 
            // matchesToolStripMenuItem
            // 
            this.matchesToolStripMenuItem.Name = "matchesToolStripMenuItem";
            this.matchesToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.matchesToolStripMenuItem.Text = "Matches";
            this.matchesToolStripMenuItem.Click += new System.EventHandler(this.matchesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1053, 505);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1069, 544);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem goalsToolStripMenuItem;
        private ToolStripMenuItem competingTeamsToolStripMenuItem;
        private ToolStripMenuItem setTournamentsToolStripMenuItem;
        private ToolStripMenuItem setTournamentsToolStripMenuItem1;
        private ToolStripMenuItem selectedFieldsToolStripMenuItem;
        private ToolStripMenuItem participatingPlayerToolStripMenuItem;
        private ToolStripMenuItem matchesToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}