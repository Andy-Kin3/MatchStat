using MatchStat.Database;
using MatchStat.DataModel.DataModels;
using MatchStat.Interfaces.Interfaces;

namespace MatchStat.UI
{
    public partial class GoalsWindow : Form
    {
        IGoalRepository _goalrepository;
        IPlayersRepository _playersRepository;
        IMatchesRepository _matchesRepository;
        public GoalsWindow(IPlayersRepository playersRepository, IGoalRepository goalRepository, IMatchesRepository matchesRepository)
        {
            InitializeComponent();
            _playersRepository = playersRepository;
            _goalrepository = goalRepository;
            _matchesRepository = matchesRepository;
        }
        private Goal? goal
        {
            get
            {
                return this.goalBindingSource.DataSource as Goal;
            }
            set
            {
                this.goalBindingSource.DataSource = value;
            }
        }
        private void LoadGoals()
        {
            var allPlayers = _playersRepository.GetAll();
            playerBindingSource1.DataSource = allPlayers;//.Select(p => p.FullName);
            var allMatches = _matchesRepository.GetAll();
            matchDetailsBindingSource.DataSource = allMatches;


            var goals = _goalrepository.GetAll();
            foreach (var goal in goals)
            {
                var player = allPlayers.FirstOrDefault(p => p.Id == goal.PlayerId);
                goal.PlayerName = player?.FullName;

                var match = allMatches.FirstOrDefault(m => m.Id == goal.MatchId);
                goal.MatchName = match?.MatchName;
            }

            goalBindingSource.DataSource = goals;
        }

        private void DataGridView1_cellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "PlayerNameColumn")
            {
                int playerId;
                if (int.TryParse(e.Value?.ToString(), out playerId))
                {
                    e.Value = _goalrepository.GetPlayerFullName(playerId);
                }
            }
        }
        private void CreateGoal()
        {
            //var goal = new Goal()
            //{
            //    NumberOfGoal = Convert.ToInt32(numberOfGoals.Text),
            //    PlayerId = Convert.ToInt32(playerCbox.Text),
            //    MatchId = Convert.ToInt32(matchCbox.Text),
            //    Id = GetNextID()
            //};
            _goalrepository.Add(goal);
        }

        private void createButton_Click_1(object sender, EventArgs e)
        {
            CreateGoal();
            LoadGoals();
        }
        private Goal? GetSelectedGoal()
        {
            return this.goalBindingSource.Current as Goal;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedGoal();
            if (selected != null)
            {
                DeleteGoal(selected);
                LoadGoals();
            }

        }
        private void DeleteGoal(Goal currentgoal)
        {
            _goalrepository.Delete(currentgoal);
        }

        private void Goals_Load_1(object sender, EventArgs e)
        {
            LoadGoals();
            goal = new Goal();
        }
    }
}
