using MatchStat.Core;
using MatchStat.DataModel.DataModels;
using MatchStat.UI;
using MatchStat.UI.Windows;

namespace MatchStat.Presentation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void goalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var playerRepo = GlobalFunctions.GetInstance<IPlayersRepository>();
            //var goalRepo = GetInstance<IGoalRepository>();
            var goalsWindow = GlobalFunctions.GetInstance<GoalRecordWindow>();
            //var goals = new GoalRecordWindow(playerRepo, goalRepo);
            goalsWindow.Show();
            goalsWindow.MdiParent = this;
        }

        private void competingTeamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var teamWindow = GlobalFunctions.GetInstance<TeamsWindow>();
            teamWindow.Show();
            teamWindow.MdiParent = this;
        }

        private void setTournamentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var toutnamentWindow = GlobalFunctions.GetInstance<TournamentStatisticsWindow>();
            toutnamentWindow.Show();
            toutnamentWindow.MdiParent = this;
        }

        private void selectedFieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fieldsWindow = GlobalFunctions.GetInstance<FieldsWindow>();
            fieldsWindow.Show();
            fieldsWindow.MdiParent = this;
        }

        private void participatingPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var playerWindow = GlobalFunctions.GetInstance<PlayersWindow>();
            playerWindow.Show();
            playerWindow.MdiParent = this;
        }

        private void matchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var matchRecordWindow = GlobalFunctions.GetInstance<MatchesWindow2>();
            matchRecordWindow.Show();
            matchRecordWindow.MdiParent = this;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void setTournamentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var teamTournamentWindow = GlobalFunctions.GetInstance<TeamTournamentsWindow>();
            teamTournamentWindow.Show();
            teamTournamentWindow.MdiParent = this;
        }

        private void matchStoreProToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mymatchwindow = GlobalFunctions.GetInstance<MatchesStoredProcedureWindow>();
            mymatchwindow.Show();
            mymatchwindow.MdiParent = this;
        }
    }
}
