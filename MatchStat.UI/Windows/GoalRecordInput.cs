using MatchStat.Core;
using MatchStat.DataModel.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchStat.UI.Windows
{
    public partial class GoalRecordInput : Form
    {
        public EventHandler SaveGoal { get; set; }
        public GoalRecordInput()
        {
            InitializeComponent();
        }
        private Goal? goals
        {
            get { return goalBindingSource.DataSource as Goal; }
            set { this.goalBindingSource.DataSource = value; }
        }
        private void saveGoal(Goal goal)
        {
            using (var context = new FootballInfoContext())
            {
                var g = goal;
                if (g.Id == 0)
                {
                    g.Id = GetNextGoalId();
                }
                context.Goals.Add(goals);
                context.SaveChanges();
            }
        }
        private int GetNextGoalId()
        {
            using (var context = new FootballInfoContext())
            {
                try
                {
                    var maximumId = context.Goals.Max(g => g.Id);
                    var nextId = maximumId + 1;
                    if(nextId == maximumId + 1)
                    {
                        return nextId + 1;
                    }
                    return nextId;
                }
                catch (Exception ex)
                {
                    return 1;
                }
            }
        }
        private void button_saveGoal_Click(object sender, EventArgs e)
        {
            saveGoal(goals);
            var eventArguments = new GoalSavedEventArguments
            {
                SavedGoals = goals
            };
            SaveGoal?.Invoke(this, e);
        }

        private void GoalRecordInput_Load(object sender, EventArgs e)
        {
            LoadGoals();
            goals = new Goal();
        }
        private void LoadGoals()
        {
            var allMatches = GetMatches();
            matchDetailBindingSource.DataSource = allMatches;
            var allPlayers = GetPlayers();
            playerBindingSource.DataSource = allPlayers;
            var allgoals = GetGoals();
            foreach (var goal in allgoals)
            {
                var player = allPlayers.FirstOrDefault(p => p.Id == goal.Id);
                goal.PlayerName = player?.FullName;

                var matches = allMatches.FirstOrDefault(m => m.Id == goal.Id);
                goal.MatchName = matches?.MatchName;
            }
            goalBindingSource.DataSource = GetGoals();
        }

        private Goal[] GetGoals()
        {
            using (var context = new FootballInfoContext())
            {
                var goal = context.Goals.OrderBy(g => g.Id).ToArray();
                return goal;
            }
        }

        private Player[] GetPlayers()
        {
            using (var context = new FootballInfoContext())
            {
                var players = context.Players.OrderBy(p => p.FirstName).ToArray();
                return players;
            }
        }

        private MatchDetail[] GetMatches()
        {
            using (var context = new FootballInfoContext())
            {
                var matches = context.MatchDetails.OrderBy(m => m.Id).ToArray();
                return matches;
            }
        }
    }
}
