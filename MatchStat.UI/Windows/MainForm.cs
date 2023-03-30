using Autofac;
using MatchStat.Core;
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
            //var playerRepo = GlobalFunctions.Container.Resolve<IPlayersRepository>();
            //var goalRepo = Container.Resolve<IGoalRepository>();
            var goalsWindow = GlobalFunctions.Container.ResolveOptional<GoalRecordWindow>();
            //var goals = new GoalRecordWindow(playerRepo, goalRepo);
            goalsWindow.Show();
            goalsWindow.MdiParent = this;
        }

        private void competingTeamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var teamWindow = GlobalFunctions.Container.Resolve<TeamsWindow>();
            teamWindow.Show();
            teamWindow.MdiParent = this;
        }

        private void setTournamentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var toutnamentWindow = GlobalFunctions.Container.Resolve<TournamentStatisticsWindow>();
            toutnamentWindow.Show();
            toutnamentWindow.MdiParent = this;
        }

        private void selectedFieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fieldsWindow = GlobalFunctions.Container.Resolve<FieldsWindow>();
            fieldsWindow.Show();
            fieldsWindow.MdiParent = this;
        }

        private void participatingPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var playerWindow = GlobalFunctions.Container.Resolve<PlayersWindow>();
            playerWindow.Show();
            playerWindow.MdiParent = this;
        }

        private void matchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var matchRecordWindow = GlobalFunctions.Container.Resolve<MatchRecordWindow>();
            matchRecordWindow.Show();
            matchRecordWindow.MdiParent = this;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void setTournamentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var teamTournamentWindow = GlobalFunctions.Container.Resolve<TeamTournamentsWindow>();
            teamTournamentWindow.Show();
            teamTournamentWindow.MdiParent = this;
        }
    }
}
