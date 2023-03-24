using MatchStat.Database;
using MatchStat.Repositories.Repositories;
using MatchStat.UI.Windows;
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

        private void goalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var context = new FootballInfoContext();
            var playerRepo = new PlayersRepository(context);
            var goalRepo = new GoalRepository(context);
            var goals = new GoalRecordWindow(playerRepo, goalRepo);
            goals.Show();
            goals.MdiParent = this;
        }

        private void competingTeamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var team = new TeamsWindow();
            team.Show();
            team.MdiParent = this;
        }

        private void setTournamentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var context = new FootballInfoContext();
            var tournamentRepo = new TournamentsRepository(context);
            var tournamentStatistics = new TournamentStatisticsWindow(tournamentRepo);
            tournamentStatistics.Show();
            tournamentStatistics.MdiParent = this;
        }

        private void selectedFieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fields = new FieldsWindow();
            fields.Show();
            fields.MdiParent = this;
        }

        private void participatingPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var context = new FootballInfoContext();
            var playerRepo = new PlayersRepository(context);
            var teamsRepo = new TeamsRepository(context);
            var players = new PlayersWindow(teamsRepo, playerRepo);
            players.Show();
            players.MdiParent = this;
        }

        private void matchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var context = new FootballInfoContext();
            var matchesRepository = new MatchDetailsRepository(context);
            var matches = new MatchRecordWindow(matchesRepository);
            matches.Show();
            matches.MdiParent = this;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void setTournamentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var teamTournament = new TeamTournamentsWindow();
            teamTournament.Show();
            teamTournament.MdiParent = this;
        }
    }
}
