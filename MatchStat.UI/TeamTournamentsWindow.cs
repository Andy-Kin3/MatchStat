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
    public partial class TeamTournamentsWindow : Form
    {
        public TeamTournamentsWindow()
        {
            InitializeComponent();
        }
        private void LoadTeamTournments()
        {
            var teamsTournament = this.GetTeamTournaments();
            teamTournamentBindingSource.DataSource = teamsTournament;
            var teams = this.GetTeams();
            teamBindingSource.DataSource = teams;
            var tournament = this.GetTournament();
            tournamentBindingSource.DataSource = tournament;
            FillList(teamsTournament);
        }

        private List<TeamTournament> GetTeamTournaments()
        {
            using (var context = new FootballInfoContext())
            {
                var myTeamTour = context.TeamTournaments.ToList();
                return myTeamTour;
            }
        }

        private List<Tournament> GetTournament()
        {
            using (var context = new FootballInfoContext())
            {

                var myTournament = context.Tournaments.ToList();
                return myTournament;
            }
        }

        private List<Team> GetTeams()
        {
            using (var context = new FootballInfoContext())
            {
                var myTeam = context.Teams.ToList();
                return myTeam;
            }
        }

        private void TeamTournaments_Load(object sender, EventArgs e)
        {
            LoadTeamTournments();
            listView1.BackColor = Color.Turquoise;
        }

        private void assignButton_Click(object sender, EventArgs e)
        {
            var teamandTournaments = new TeamTournament
            {
                TeamId = Convert.ToInt32(comboTeam.SelectedValue),
                TournamentId = Convert.ToInt32(comboTournament.SelectedValue),
                Id = GetNextID()
            };
            using (var context = new FootballInfoContext())
            {
                add(comboTeam.Text, comboTournament.Text);
                context.TeamTournaments.Add(teamandTournaments);
                context.SaveChanges();
                LoadTeamTournments();
            }
        }
        private string GetTeamName(int id)
        {
            using (var context = new FootballInfoContext())
            {
                var team = context.Teams.FirstOrDefault(t => t.Id == id);
                if(team != null)
                {
                    return team.Name;
                }
                return null;
            }
        }
        private string GetTournamentName(int id)
        {
            using (var context = new FootballInfoContext())
            {
                var tournament = context.Tournaments.FirstOrDefault(t => t.Id == id);
                if(tournament != null)
                {
                    return tournament?.Name;
                }
                return null;

            }
        }

        private int GetNextID()
        {
            var allTeamTournaments = teamTournamentBindingSource.DataSource as List<TeamTournament>;
            var maximumId = allTeamTournaments != null && allTeamTournaments.Any() ? allTeamTournaments.Max(e => e.Id) : 0;
            var nextId = maximumId+ 1;
            return nextId;
        }

        private void add(string team, string tournament)
        {

            string[] row = { team, tournament };
            ListViewItem items = new ListViewItem(row);
            listView1.Items.Add(items);
        }
        private void FillList(List<TeamTournament> teamTournaments)
        {
            listView1.Items.Clear();

            foreach (var myTeam in teamTournaments)
            {
                string[] row = { GetTeamName(myTeam.TeamId),GetTournamentName(myTeam.TournamentId) };
                listView1.Items.Add(new ListViewItem(row));
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            var focussedItemIndex = listView1.FocusedItem?.Index;
            if(focussedItemIndex.HasValue == false )
            {
                return;
            }
            var allTeamTournaments = teamTournamentBindingSource.DataSource as List<TeamTournament>;
            if(allTeamTournaments == null || allTeamTournaments.Any() == false) { return; }
            var teamTournamentToDelete = allTeamTournaments[focussedItemIndex.Value];
            if(teamTournamentToDelete != null )
            {
                using(var context = new FootballInfoContext())
                {
                    context.TeamTournaments.Remove(teamTournamentToDelete);
                    context.SaveChanges();
                    LoadTeamTournments();
                }
            }

        }
    }
}
