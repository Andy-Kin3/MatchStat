using MatchStat.Core;
using MatchStat.DataModel.DataModels;
using MatchStat.Repositories.Repositories;

namespace MatchStat.UI.UserControls
{
    public partial class UcSingleGoal : UserControl
    {
        public UcSingleGoal()
        {
            InitializeComponent();
            if (GlobalFunctions.IsRunTime)
            {
                InitializeWindow();
            }
        }

        public Goal? Goal
        {
            get
            {
                return this.goalBindingSource.DataSource as Goal;
            }
            set
            {
                var goal = value ?? new Goal();
                this.goalBindingSource.DataSource = goal;
                //comboBox_match.SelectedValue = goal?.MatchId;
            }
        }

        private void UcSingleGoal_Load(object sender, EventArgs e)
        {
            if (Goal == null)
            {
                Goal = new Goal();
            }
        }

        private void InitializeWindow()
        {
            var allMatches = new MatchesRepository().GetAllMatches();
            allMatches.Insert(0, new MatchDetail());
            matchDetailBindingSource.DataSource = allMatches;

            var allPlayers = new PlayerRepository().GetPlayers();
            allPlayers.Insert(0, new Player());
            playerBindingSource.DataSource = allPlayers;
        }
    }
}
