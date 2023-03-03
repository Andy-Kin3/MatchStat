using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchStat.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //private void tournamentbutton_Click(object sender, EventArgs e)
        //{
        //   var tournamentStatistics = new TournamentStatistics();
        //    tournamentStatistics.Show();
        //    tournamentStatistics.MdiParent = this;
        //}

        //private void playerButton_Click(object sender, EventArgs e)
        //{
        //    var players = new Players();
        //    players.Show();
        //    players.MdiParent = this;
        //}

        //private void fieldButton_Click(object sender, EventArgs e)
        //{
        //    var fields = new Field();
        //    fields.Show();
        //    fields.MdiParent = this;
        //}

        //private void MatchButton_Click(object sender, EventArgs e)
        //{
        //    var matches = new Match();
        //    matches.Show();
        //    matches.MdiParent = this;
        //}

        //private void teamButton_Click(object sender, EventArgs e)
        //{
        //    var team = new Teams();
        //    team.Show();
        //    team.MdiParent = this;

        //}

        //private void tournamentTeamsButton_Click(object sender, EventArgs e)
        //{
        //    var teamTournament = new TeamTournaments();
        //    teamTournament.Show();
        //    teamTournament.MdiParent = this;
        //}

        //private void goalsButton_Click(object sender, EventArgs e)
        //{
        //    var goals = new Goals();
        //    goals.Show();
        //    goals.MdiParent = this;
        //}

        private void goalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var goals = new Goals();
            goals.Show();
            goals.MdiParent = this;
        }

        private void competingTeamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var team = new Teams();
            team.Show();
            team.MdiParent = this;
        }

        private void setTournamentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tournamentStatistics = new TournamentStatistics();
            tournamentStatistics.Show();
            tournamentStatistics.MdiParent = this;
        }

        private void selectedFieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fields = new Field();
            fields.Show();
            fields.MdiParent = this;
        }

        private void participatingPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var players = new Players();
            players.Show();
            players.MdiParent = this;
        }

        private void matchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var matches = new Match();
            matches.Show();
            matches.MdiParent = this;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void setTournamentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var teamTournament = new TeamTournaments();
            teamTournament.Show();
            teamTournament.MdiParent = this;
        }
    }
}
