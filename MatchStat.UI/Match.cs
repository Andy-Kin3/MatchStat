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

namespace MatchStat.UI
{
    public partial class Match : Form
    {
        public Match()
        {
            InitializeComponent();
        }

        private void Match_Load(object sender, EventArgs e)
        {
            LoadMatch();
            team1Cbo.Items.Add("Pineaple");
            team1Cbo.Items.Add("Pear");
            team1Cbo.Items.Add("Orange");
            team1Cbo.Items.Add("Apple");

        }
        private void LoadMatch()
        {
            var matches = GetMatches();
            matchBindingSource.DataSource = matches;
        }

        private object GetMatches()
        {
            using (var context = new FootballInfoContext())
            {
                var matches = context.Matches.ToList();
                return matches;
            }
        }
        private object GetTeams()
        {
            using(var context = new FootballInfoContext())
            {
                var teams = context.Teams.ToList();
                return teams;
            }
        }
        private object GetTournament()
        {
            using(var context = new FootballInfoContext())
            {
                var tournament = context.Tournaments.ToList();
                return tournament;
            }
        }

        private void createMatchButton_Click(object sender, EventArgs e)
        {
            var matches = new Matches
            {
                Date = DateTime.Parse(matchDateTimePicker.Text),
            };
        }

        private void team1Cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
