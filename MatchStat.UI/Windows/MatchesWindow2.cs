using ExpressMapper.Extensions;
using MatchStat.Database;
using MatchStat.DataModel.DataModels;
using MatchStat.Interfaces.Interfaces;
using MatchStat.Repositories.Repositories;
using System.Data;

namespace MatchStat.UI.Windows
{
    public partial class MatchesWindow2 : Form
    {
        IMatchesRepository _matchesRepository;
        ITournamentsRepository _tournamentsRepository;
        IFieldsRepository _fieldsRepository;
        ITeamsRepository _teamsRepository;

        public MatchesWindow2(IMatchesRepository repository, ITeamsRepository teamsRepository, ITournamentsRepository tournamentsRepository, IFieldsRepository fieldRepository)
        {
            InitializeComponent();
            _matchesRepository = repository;
        }

        private MatchDetail? match
        {
            get { return this.bindingSource_matchDetail.DataSource as MatchDetail; }
            set
            {
                this.bindingSource_matchDetail.DataSource = value;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveMatchToDatabase(match);
            LoadAllMatches();
        }

        private void SaveMatchToDatabase(MatchDetail match)
        {
            _matchesRepository.Add(match);
        }

        private void MatchesWindow2_Load(object sender, EventArgs e)
        {
            var teams = _teamsRepository.GetAll();
            this.team1BindingSource.DataSource = teams;
            this.team2BindingSource.DataSource = teams;
            this.tournamentBindingSource.DataSource = _tournamentsRepository.GetAll();
            this.fieldsBindingSource.DataSource = _fieldsRepository.GetAll();

            LoadAllMatches();
            addButton_Click(null, null);
        }

        private void LoadAllMatches()
        {
            this.matchDetailBindingSource.DataSource = _matchesRepository.GetAll();
        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.matchesMenu.Show(MousePosition);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.match = new MatchDetail { Date = DateTime.Now };
        }


        private void editButton_Click(object sender, EventArgs e)
        {
            var currentMatch = GetSelectedMatch();
            if (currentMatch != null)
            {
                this.match = currentMatch;
            }
        }

        private MatchDetail? GetSelectedMatch()
        {
            return this.matchDetailBindingSource.Current as MatchDetail;
        }

        private void deleteButton2_Click(object sender, EventArgs e)
        {
            var currentMatch = GetSelectedMatch();
            if (currentMatch != null)
            {
                DeleteMatch(currentMatch);
                LoadAllMatches();
            }
        }

        private void DeleteMatch(MatchDetail currentMatch)
        {
            _matchesRepository.Delete(currentMatch);
        }
    }
}
