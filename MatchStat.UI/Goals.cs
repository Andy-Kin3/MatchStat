using MatchStat.DataModel.DataModels;
using MatchStat.DataModel.Migrations;
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
    public partial class Goals : Form
    {
        public Goals()
        {
            InitializeComponent();
        }

        private void Goals_Load(object sender, EventArgs e)
        {
            LoadGoal();
            
        }
        private void LoadGoal()
        {
            var goal = this.GetGoals();
            goalBindingSource.DataSource = goal;
            var player = this.GetPlayer();
            playerBindingSource.DataSource = player;
            var match = this.GetMatch();
            matchesBindingSource.DataSource = player;
        }

        private object GetMatch()
        {
            using(var context = new FootballInfoContext())
            {
                var matches = context.Matches.ToList();
                return matches;
            }
        }

        private object GetPlayer()
        {
            using(var context = new FootballInfoContext())
            {
                var players = context.Players.ToList();
                return players;
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
                LoadGoal();
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
                    LoadGoal();
                }
            }
        }
    }
}
