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
        }
        private void LoadMatch()
        {
            var matches = this.GetMatches();
            matchBindingSource.DataSource = matches;
            var myTeam = this.GetTeams();
            teamBindingSource.DataSource = myTeam;
            var Dteam = this.GetTeams();
            teamBindingSource1.DataSource = Dteam;
            var field = this.GetFields();
            fieldsBindingSource.DataSource = field;
            var myTournament = this.GetTournament();
            tournamentBindingSource.DataSource = myTournament;
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
        private List<Fields> GetFields()
        {
            using(var context = new FootballInfoContext())
            {
                var fields = context.Fields.ToList();
                return fields;
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
                Team1Id = Convert.ToInt32(team1Cbo.SelectedValue),
                Team2Id = Convert.ToInt32(team2Cbo.SelectedValue),
                TournamentId = Convert.ToInt32(tourCbo.SelectedValue),
                FieldId = Convert.ToInt32(fieldcbo.SelectedValue),
                Id = GetNextID()
            };
            //listView1.Items.AddRange(matches);
            using (var context =  new FootballInfoContext())
            {
                context.Matches.Add(matches);
                context.SaveChanges();
                LoadMatch();
            }
        }

        private int GetNextID()
        {
            var allMatches = matchBindingSource.DataSource as List<Matches>;
            var maximumId = allMatches != null && allMatches.Any() ? allMatches.Max(e => e.Id) : 0;
            return maximumId + 1;
        }

        private void deleteMatchButton_Click(object sender, EventArgs e)
        {
            var mySelected = matchBindingSource.Current as Matches;
            if( mySelected != null)
            {
                using(var context = new FootballInfoContext())
                {
                    context.Matches.Remove(mySelected);
                    context.SaveChanges();
                    LoadMatch();
                }
            }
        }
    }
}
