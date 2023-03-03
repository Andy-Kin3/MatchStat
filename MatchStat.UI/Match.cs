using MatchStat.DataModel.DataModels;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
            LoadMatches();
        }
        private void LoadMatches()
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
            using (var context =  new FootballInfoContext())
            {
                add(Convert.ToDateTime(matchDateTimePicker.Text), team1Cbo.Text, team2Cbo.Text, tourCbo.Text, fieldcbo.Text);
                context.Matches.Add(matches);
                context.SaveChanges();
                LoadMatches();
            }

            LoadMatches();
        }
        private void add(DateTime matchDate, string team1, string team2, string tournament, string field)
        {
            
            string[] row = {Convert.ToString(matchDate.TimeOfDay), team1, team2, tournament, field };
            ListViewItem item = new ListViewItem(row);
            listView1.Items.Add(item);
        }
        private void FillList(List<Matches> myMatch)
        {
            listView1.Items.Clear();
            
            foreach(var match in myMatch)
            {
                string[] row = { Convert.ToString(match.Date.TimeOfDay), Convert.ToString(match.Team1Id), Convert.ToString(match.Team2Id), Convert.ToString(match.TournamentId), Convert.ToString(match.FieldId) };
                listView1.Items.Add(new ListViewItem(row));
            }
        }

        private int GetNextID()
        {
            var allMatches = matchBindingSource.DataSource as List<Matches>;
            var maximumId = allMatches != null && allMatches.Any() ? allMatches.Max(e => e.Id) : 0;
            var nextId = maximumId + 1;
            return nextId;
            //var maximumIdQuery = $"SELECT MAX(Id) FROM Match";
            //using (var context = new FootballInfoContext())
            //{
            //    var maximumId = context.Database.SqlQuery<int?>(FormattableStringFactory.Create(maximumIdQuery)).FirstOrDefault();
            //    var nextId = maximumId.HasValue ? maximumId.GetValueOrDefault() + 1 : 1;
            //    return nextId;
            //}
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
                    LoadMatches();


                    foreach (ListViewItem selectedItem in listView1.SelectedItems)
                    {
                        if(listView1.SelectedItems.Count > 0)
                        {
                            listView1.Items.Remove(selectedItem);
                        }
                    }
                }
            }
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            using(var context = new FootballInfoContext())
            {
                FillList(context.Matches.ToList());
            }
        }
    }
}
