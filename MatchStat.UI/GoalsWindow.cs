using MatchStat.DataModel.DataModels;
using MatchStat.DataModel.Migrations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchStat.UI
{
    public partial class GoalsWindow : Form
    {
        public GoalsWindow()
        {
            InitializeComponent();
        }
        private void LoadGoals()
        {
            var allPlayers = this.GetAllPlayers();
            playerBindingSource.DataSource = allPlayers.Select(p => p.FullName);
            var allMatches = this.GetAllMatches();
            matchDetailsBindingSource.DataSource = allMatches;


            var goals = this.GetGoals();
            foreach(var goal in goals)
            {
                var player = allPlayers.FirstOrDefault(p => p.Id == goal.PlayerId);
                goal.PlayerName = player?.FullName;

                var match = allMatches.FirstOrDefault(p => p.Id == goal.MatchId);
                goal.MatchName = match?.MatchName;
            }

            goalBindingSource.DataSource = goals;
        }

        private List<MatchDetail> GetAllMatches()
        {
            using(var context = new FootballInfoContext())
            {
                var matches = context.MatchDetails.ToList();
                return matches;
            }
        }
        public List<Player> GetAllPlayers()
        {
            using (var context = new FootballInfoContext())
            {
                var players = context.Players.ToList();
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
                    return playerName.FirstName + " " + playerName.LastName;
                }
                return "";
            }
        }



        private void DataGridView1_cellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "PlayerName")
            {
                int playerId;
                if (int.TryParse(e.Value?.ToString(), out playerId))
                {
                    e.Value = GetPlayerFullName(playerId);
                }
            }
        }

        private List<Player> GetPlayers()
        {
            using(var context = new FootballInfoContext())
            {
                var player = context.Players.ToList();
                return player;
            }
        }

        private List<Goal> GetGoals()
        {
            using(var context = new FootballInfoContext())
            {
                var goals = context.Goals.ToList();
                return goals;
            }
        }

        private void createButton_Click_1(object sender, EventArgs e)
        {
            var goals = new Goal
            {
                NumberOfGoal = Convert.ToInt32(numberOfGoals.Value),
                PlayerId = Convert.ToInt32(playerCbox.SelectedValue),
                MatchId = Convert.ToInt32(matchCbox.SelectedValue),
                Id = GetNextID()
            };
            using(var context = new FootballInfoContext())
            {
                context.Goals.Add(goals);
                context.SaveChanges();
                LoadGoals();
            }
        }

        private int GetNextID()
        {
            var allGoals = goalBindingSource.DataSource as List<Goal>;
            var maximumId = allGoals != null && allGoals.Any() ? allGoals.Max(x => x.Id) : 0;
            return maximumId + 1;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            var selected = goalBindingSource.DataSource as Goal;
            if(selected != null)
            {
                using(var context = new FootballInfoContext())
                {
                    context.Goals.Remove(selected);
                    context.SaveChanges();
                    LoadGoals();
                }
            }
        }

        private void Goals_Load_1(object sender, EventArgs e)
        {
            LoadGoals();
        }
    }
}
