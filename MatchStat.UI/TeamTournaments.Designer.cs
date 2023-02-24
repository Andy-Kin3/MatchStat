namespace MatchStat.UI
{
    partial class TeamTournaments
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.assignButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.comboTeam = new System.Windows.Forms.ComboBox();
            this.comboTournament = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.Location = new System.Drawing.Point(0, 81);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(738, 378);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Team :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(340, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tournament :";
            // 
            // assignButton
            // 
            this.assignButton.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.assignButton.Location = new System.Drawing.Point(12, 40);
            this.assignButton.Name = "assignButton";
            this.assignButton.Size = new System.Drawing.Size(185, 34);
            this.assignButton.TabIndex = 4;
            this.assignButton.Text = "Assign";
            this.assignButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(216, 41);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(178, 34);
            this.removeButton.TabIndex = 5;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // comboTeam
            // 
            this.comboTeam.FormattingEnabled = true;
            this.comboTeam.Location = new System.Drawing.Point(82, 7);
            this.comboTeam.Name = "comboTeam";
            this.comboTeam.Size = new System.Drawing.Size(252, 23);
            this.comboTeam.TabIndex = 6;
            // 
            // comboTournament
            // 
            this.comboTournament.FormattingEnabled = true;
            this.comboTournament.Location = new System.Drawing.Point(459, 7);
            this.comboTournament.Name = "comboTournament";
            this.comboTournament.Size = new System.Drawing.Size(255, 23);
            this.comboTournament.TabIndex = 7;
            // 
            // TeamTournaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(738, 459);
            this.Controls.Add(this.comboTournament);
            this.Controls.Add(this.comboTeam);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.assignButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "TeamTournaments";
            this.Text = "TeamTournaments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listView1;
        private Label label1;
        private Label label2;
        private Button assignButton;
        private Button removeButton;
        private ComboBox comboTeam;
        private ComboBox comboTournament;
    }
}