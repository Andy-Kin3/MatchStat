using MatchStat.DataModel.DataModels;
using MatchStat.Interfaces.Interfaces;

namespace MatchStat.UI
{
    public partial class TeamsWindow : Form
    {
        ITeamsRepository _teamsRepository;
        public TeamsWindow(ITeamsRepository teamsRepository)
        {
            InitializeComponent();
            _teamsRepository = teamsRepository;
        }
        private Team? team
        {
            get
            {
                return this.teamBindingSource.DataSource as Team;
            }
            set { this.teamBindingSource.DataSource = value; }

        }
        private void LoadTeams()
        {
            var teams = _teamsRepository.GetAll();
            teamBindingSource.DataSource = teams;
        }
        private void Teams_Load(object sender, EventArgs e)
        {
            LoadTeams();
        }
        private void AddTeamToDatabase(Team t)
        {
            _teamsRepository.Add(t);
            LoadTeams();
        }

        private void createbutton_Click(object sender, EventArgs e)
        {
            if (team != null)
            {
                AddTeamToDatabase(team);
            }
        }

        //private int GetNextID()
        //{
        //    var allTeams = teamBindingSource.DataSource as List<Team>;
        //    var maximumId = allTeams != null && allTeams.Any() ? allTeams.Max(x => x.Id) : 0;
        //    return maximumId + 1;
        //}

        private void deleteTeamButton_Click(object sender, EventArgs e)
        {
            var currentlySelected = teamBindingSource.Current as Team;
            if (currentlySelected != null)
            {
                _teamsRepository.Delete(currentlySelected);
            }
        }
    }
}
