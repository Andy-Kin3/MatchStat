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
            apply_cboValues();
            var myTournament = this.GetTournament();
            tournamentBindingSource.DataSource = myTournament;
        }

        
        private void apply_cboValues()
        {
            var myTeam = this.GetTeams();
            teamBindingSource.DataSource = myTeam;
            var Dteam = this.GetTeams();
            teamBindingSource1.DataSource = Dteam;
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
        private List<Team> GetTeams()
        {
            using(var context = new FootballInfoContext())
            {
                var teams = context.Teams.ToList();
                return teams;
            }
        }
        private List<Tournament> GetTournament()
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
                Team1Id = (int)team1Cbo.SelectedItem,
                Team2Id = (int)team2Cbo.SelectedItem,
                TournamentId = tourCbo.TabIndex
            };
            using(var context =  new FootballInfoContext())
            {
                context.Matches.Add(matches);
                context.SaveChanges();
                LoadMatch();
            }
        }
    }
}
