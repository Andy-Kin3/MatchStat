using Autofac;
using DependencyInjector;
using MatchStat.Database;
using MatchStat.Repositories.Repositories;
using MatchStat.UI.Windows;

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
            var container = ContainerConfig.Configure();
            using(var scope =  container.BeginLifetimeScope()) 
            {
                var goals = scope.Resolve<GoalRecordWindow>();
                goals.Show();
            }
            //var context = new FootballInfoContext();
            //var playerRepo = new PlayersRepository(context);
            //var goalRepo = new GoalRepository(context);
            //var goals = new GoalRecordWindow(playerRepo, goalRepo);
            //goals.Show();
            //goals.MdiParent = this;
        }

        private void competingTeamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var context = new FootballInfoContext();
            var teamRepo = new TeamsRepository(context);
            var team = new TeamsWindow(teamRepo);
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
            var context = new FootballInfoContext();
            var fieldRepo = new FieldRepository(context);
            var fields = new FieldsWindow(fieldRepo);
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
            var context = new FootballInfoContext();
            var teamRepo = new TeamsRepository(context);
            var tournamentRepo = new TournamentsRepository(context);
            var teamTournamentsrepo = new TeamTournamentRepository(context);
            var teamTournament = new TeamTournamentsWindow(teamTournamentsrepo, tournamentRepo, teamRepo);
            teamTournament.Show();
            teamTournament.MdiParent = this;
        }
    }
}
