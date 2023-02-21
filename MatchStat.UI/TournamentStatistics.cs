using System.Data.SqlClient;
using MatchStat.DataModel.DataModels;
using Microsoft.IdentityModel.Tokens;

namespace MatchStat.UI
{
    public partial class TournamentStatistics : Form
    {
        public TournamentStatistics()
        {
            InitializeComponent();
        }


        private List<Tournament> GetTournament()
        {
            using(var context = new FootballInfoContext())
            {
                var tournament = context.Tournaments.ToList();
                return tournament;
            }
        }
        

        private void createButton_Click(object sender, EventArgs e)
        {
            var tournament = new Tournament
            {
                StartDate = DateTime.Parse(startDate.Text),
                EndDate = DateTime.Parse(endDate.Text),
                Name = tournamentName.Text.ToString(),
                Id = GetNextId()
            };

            using (var context = new FootballInfoContext())
            {
                context.Tournaments.Add(tournament);
                context.SaveChanges();
                LoadTournaments(); 
            }
        }

        private int GetNextId()
        {
            var allTournaments = tournamentBindingSource.DataSource as List<Tournament>;
            var maximumId = allTournaments != null && allTournaments.Any() ? allTournaments.Max(x => x.Id) : 0;
            return maximumId + 1;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadTournaments();
        }

        private void LoadTournaments()
        {
            var tournaments = this.GetTournament();
            tournamentBindingSource.DataSource = tournaments;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var currentlySelected = tournamentBindingSource.Current as Tournament;
            if(currentlySelected != null)
            {
                using (var context = new FootballInfoContext())
                {
                    context.Tournaments.Remove(currentlySelected);
                    context.SaveChanges();
                    LoadTournaments();
                }
            }
        }
    }
}