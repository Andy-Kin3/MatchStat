using System.Data.SqlClient;
using MatchStat.Database;
using MatchStat.DataModel.DataModels;
using MatchStat.Interfaces;
using MatchStat.Repositories.Repositories;
using Microsoft.IdentityModel.Tokens;

namespace MatchStat.UI
{
    public partial class TournamentStatisticsWindow : Form
    {
        private readonly ITournamentsRepository _tournamentRepository;
        public TournamentStatisticsWindow(ITournamentsRepository tournamentsRepository)
        {
            InitializeComponent();
            _tournamentRepository = tournamentsRepository;
        }
        private Tournament? tournament
        {
            get { return this.tournamentBindingSource.DataSource as Tournament; }
            set
            {
                this.tournamentBindingSource.DataSource = value;
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
                tournamentName.Clear();
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
            tournamentBindingSource.DataSource = _tournamentRepository.GetAll();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var currentlySelected = tournamentBindingSource.Current as Tournament;
            if (currentlySelected != null)
            {
                _tournamentRepository.Delete(currentlySelected);
            }
        }
    }
}