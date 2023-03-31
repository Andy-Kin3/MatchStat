
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
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            goalsToolStripMenuItem = new ToolStripMenuItem();
            competingTeamsToolStripMenuItem = new ToolStripMenuItem();
            setTournamentsToolStripMenuItem = new ToolStripMenuItem();
            setTournamentsToolStripMenuItem1 = new ToolStripMenuItem();
            selectedFieldsToolStripMenuItem = new ToolStripMenuItem();
            participatingPlayerToolStripMenuItem = new ToolStripMenuItem();
            matchesToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            matchStoreProToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlDarkDark;
            menuStrip1.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1053, 30);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { goalsToolStripMenuItem, competingTeamsToolStripMenuItem, setTournamentsToolStripMenuItem, setTournamentsToolStripMenuItem1, selectedFieldsToolStripMenuItem, participatingPlayerToolStripMenuItem, matchesToolStripMenuItem, exitToolStripMenuItem, matchStoreProToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(66, 26);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // goalsToolStripMenuItem
            // 
            goalsToolStripMenuItem.Name = "goalsToolStripMenuItem";
            goalsToolStripMenuItem.Size = new Size(316, 26);
            goalsToolStripMenuItem.Text = "Goals";
            goalsToolStripMenuItem.Click += goalsToolStripMenuItem_Click;
            // 
            // competingTeamsToolStripMenuItem
            // 
            competingTeamsToolStripMenuItem.Name = "competingTeamsToolStripMenuItem";
            competingTeamsToolStripMenuItem.Size = new Size(316, 26);
            competingTeamsToolStripMenuItem.Text = "Competing Teams";
            competingTeamsToolStripMenuItem.Click += competingTeamsToolStripMenuItem_Click;
            // 
            // setTournamentsToolStripMenuItem
            // 
            setTournamentsToolStripMenuItem.Name = "setTournamentsToolStripMenuItem";
            setTournamentsToolStripMenuItem.Size = new Size(316, 26);
            setTournamentsToolStripMenuItem.Text = "Set Tournaments";
            setTournamentsToolStripMenuItem.Click += setTournamentsToolStripMenuItem_Click;
            // 
            // setTournamentsToolStripMenuItem1
            // 
            setTournamentsToolStripMenuItem1.Name = "setTournamentsToolStripMenuItem1";
            setTournamentsToolStripMenuItem1.Size = new Size(316, 26);
            setTournamentsToolStripMenuItem1.Text = "Register Teams(Tournaments)";
            setTournamentsToolStripMenuItem1.Click += setTournamentsToolStripMenuItem1_Click;
            // 
            // selectedFieldsToolStripMenuItem
            // 
            selectedFieldsToolStripMenuItem.Name = "selectedFieldsToolStripMenuItem";
            selectedFieldsToolStripMenuItem.Size = new Size(316, 26);
            selectedFieldsToolStripMenuItem.Text = "Selected Fields";
            selectedFieldsToolStripMenuItem.Click += selectedFieldsToolStripMenuItem_Click;
            // 
            // participatingPlayerToolStripMenuItem
            // 
            participatingPlayerToolStripMenuItem.Name = "participatingPlayerToolStripMenuItem";
            participatingPlayerToolStripMenuItem.Size = new Size(316, 26);
            participatingPlayerToolStripMenuItem.Text = "Participating Player";
            participatingPlayerToolStripMenuItem.Click += participatingPlayerToolStripMenuItem_Click;
            // 
            // matchesToolStripMenuItem
            // 
            matchesToolStripMenuItem.Name = "matchesToolStripMenuItem";
            matchesToolStripMenuItem.Size = new Size(316, 26);
            matchesToolStripMenuItem.Text = "Matches";
            matchesToolStripMenuItem.Click += matchesToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(316, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // matchStoreProToolStripMenuItem
            // 
            matchStoreProToolStripMenuItem.Name = "matchStoreProToolStripMenuItem";
            matchStoreProToolStripMenuItem.Size = new Size(316, 26);
            matchStoreProToolStripMenuItem.Text = "MatchStore Pro";
            matchStoreProToolStripMenuItem.Click += matchStoreProToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1053, 505);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(1069, 544);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private ToolStripMenuItem matchStoreProToolStripMenuItem;
    }
}