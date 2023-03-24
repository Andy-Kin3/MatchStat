using MatchStat.Core;
using MatchStat.DataModel.DataModels;
using MatchStat.Interfaces;
using MatchStat.Repositories.Repositories;

namespace MatchStat.UI.UserControls
{
    public partial class UcSingleGoal : UserControl
    {

        public IMatchesRepository _matchesRepo;
        public IPlayersRepository _playersRepo;
        public UcSingleGoal(IMatchesRepository matchesRepository, IPlayersRepository playersRepo)
        {
            InitializeComponent();
            _matchesRepo = matchesRepository;
            _playersRepo = playersRepo;

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
            var allMatches = _matchesRepo.GetAll();
            allMatches.Insert(0, new MatchDetail());
            matchDetailBindingSource.DataSource = allMatches;

            var allPlayers = _playersRepo.GetAll();
            allPlayers.Insert(0, new Player());
            playerBindingSource.DataSource = allPlayers;
        }
    }
}
