using MatchStat.Database;
using MatchStat.DataModel.DataModels;

namespace MatchStat.UI
{
    public partial class GoalsWindow : Form
    {
        public GoalsWindow()
        {
            InitializeComponent();
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
            var allPlayers = this.GetAllPlayers();
            playerBindingSource1.DataSource = allPlayers;//.Select(p => p.FullName);
            var allMatches = this.GetAllMatches();
            matchDetailsBindingSource.DataSource = allMatches;


            var goals = this.GetGoals();
            foreach (var goal in goals)
            {
                var player = allPlayers.FirstOrDefault(p => p.Id == goal.PlayerId);
                goal.PlayerName = player?.FullName;

                var match = allMatches.FirstOrDefault(m => m.Id == goal.MatchId);
                goal.MatchName = match?.MatchName;
            }

            goalBindingSource.DataSource = goals;
        }

        private MatchDetail[] GetAllMatches()
        {
            using (var context = new FootballInfoContext())
            {
                var matches = context.MatchDetails.ToArray();
                return matches;
            }
        }
        public Player[] GetAllPlayers()
        {
            using (var context = new FootballInfoContext())
            {
                var players = context.Players.ToArray();
                return players;
            }
        }
        private string GetPlayerFullName(int playerId)
        {
            using (var context = new FootballInfoContext())
            {
                var playerName = context.Players.FirstOrDefault(p => p.Id == playerId);
                if (playerName != null)
                {
                    return playerName.FullName;
                }
                return "";
            }
        }



        private void DataGridView1_cellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "PlayerNameColumn")
            {
                int playerId;
                if (int.TryParse(e.Value?.ToString(), out playerId))
                {
                    e.Value = GetPlayerFullName(playerId);
                }
            }
        }

        //private List<Player> GetPlayers()
        //{
        //    using(var context = new FootballInfoContext())
        //    {
        //        var player = context.Players.ToList();
        //        return player;
        //    }
        //}

        private Goal[] GetGoals()
        {
            using (var context = new FootballInfoContext())
            {
                var goals = context.Goals.ToArray();
                return goals;
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
            using (var context = new FootballInfoContext())
            {
                var goals = goal;
                context.Goals.Add(goals);
                context.SaveChanges();
                LoadGoals();
            }
        }

        private void createButton_Click_1(object sender, EventArgs e)
        {
            CreateGoal();
            LoadGoals();
        }

        private int GetNextID()
        {
            var allGoals = goalBindingSource.DataSource as List<Goal>;
            var maximumId = allGoals != null && allGoals.Any() ? allGoals.Max(x => x.Id) : 0;
            var nextId = maximumId + 1;
            return nextId;
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
            using (var context = new FootballInfoContext())
            {
                var selected = context.Goals.FirstOrDefault(g => g.Id == currentgoal.Id);
                if (selected != null)
                {
                    context.Goals.Remove(selected);
                    context.SaveChanges();
                }
            }
        }

        private void Goals_Load_1(object sender, EventArgs e)
        {
            LoadGoals();
            goal = new Goal();
        }
    }
}
