using MatchStat.DataModel.DataModels;

namespace MatchStat.UI.UserControls
{
    public partial class UcSingleGoal : UserControl
    {
        public UcSingleGoal()
        {
            InitializeComponent();
            InitializeWindow();
        }

        public Goal Goal
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
        }

        private void InitializeWindow()
        {
            var allMatches = GetMatches();
            allMatches.Insert(0, new MatchDetail());
            matchDetailBindingSource.DataSource = allMatches;

            var allPlayers = GetPlayers();
            allPlayers.Insert(0, new Player());
            playerBindingSource.DataSource = allPlayers;
        }

        private List<Player> GetPlayers()
        {
            using (var context = new FootballInfoContext())
            {
                var players = context.Players.OrderBy(p => p.FirstName).ToList();
                return players;
            }
        }

        private List<MatchDetail> GetMatches()
        {
            using (var context = new FootballInfoContext())
            {
                var matches = context.MatchDetails.OrderBy(m => m.Id).ToList();
                return matches;
            }
        }
    }
}
