using MatchStat.DataModel.DataModels;
using MatchStat.Interfaces.Interfaces;

namespace MatchStat.UI.UserControls
{
    public partial class UcSingleGoal : UserControl
    {

        private readonly IMatchesRepository _matchesRepository;
        private readonly IPlayersRepository _playersRepository;
        public UcSingleGoal(IMatchesRepository matchesRepository, IPlayersRepository playersRepo)
        {
            if (UCRuntimeFunction.UCRuntimeFunction.IsRunTime == false)
            {
                InitializeWindow();
            }
            InitializeComponent();
            _matchesRepository = matchesRepository;
            _playersRepository = playersRepo;
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
            var allMatches = _matchesRepository.GetAll();
            allMatches.Insert(0, new MatchDetail());
            matchDetailBindingSource.DataSource = allMatches;

            var allPlayers = _playersRepository.GetAll();
            allPlayers.Insert(0, new Player());
            playerBindingSource.DataSource = allPlayers;
        }
    }
}
