using MatchStat.Database;
using MatchStat.DataModel.DataModels;
using MatchStat.Interfaces.Interfaces;

namespace MatchStat.UI
{
    public partial class TeamTournamentsWindow : Form
    {
        ITeamTournamentsRepository _teamTournamentRepository;
        ITournamentsRepository _tournamentRepository;
        ITeamsRepository _teamsRepository;
        public TeamTournamentsWindow(ITeamTournamentsRepository teamTournamentsRepository, ITournamentsRepository tournamentRepository, ITeamsRepository teamsRepository)
        {
            InitializeComponent();
            _tournamentRepository = tournamentRepository;
            _teamsRepository = teamsRepository;
            _teamTournamentRepository = teamTournamentsRepository;
        }
        private TeamTournament? teamTournaments
        {
            get
            {
                return this.teamTournamentBindingSource.DataSource as TeamTournament;
            }
            set
            {
                this.teamTournamentBindingSource.DataSource = value;
            }
        }
        private void LoadTeamTournments()
        {
            var teamsTournament = _teamTournamentRepository.GetAll();
            teamTournamentBindingSource.DataSource = teamsTournament;
            this.teamBindingSource.DataSource = _teamsRepository.GetAll();
            this.tournamentBindingSource.DataSource = _tournamentRepository.GetAll();
            //FillList(teamsTournament);
        }

        private void TeamTournaments_Load(object sender, EventArgs e)
        {
            LoadTeamTournments();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (var context = new FootballInfoContext())
            {
                //add(comboTeam.Text, comboTournament.Text);
                var tt = teamTournaments;
                context.TeamTournaments.Add(tt);
                context.SaveChanges();
                LoadTeamTournments();
            }
        }

        private void DataGridView_CellFormatting(Object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Index == 0)
            {
                int teamId;
                if (int.TryParse(e.Value?.ToString(), out teamId))
                    e.Value = _teamsRepository.GetTeamName(teamId);
            }
            if (dataGridView1.Columns[e.ColumnIndex].Index == 1)
            {
                int tournamentId;
                if (int.TryParse(e.Value?.ToString(), out tournamentId))
                    e.Value = _tournamentRepository.GetTournamentName(tournamentId);
            }
        }

        //private void add(string team, string tournament)
        //{

        //    string[] row = { team, tournament };
        //    ListViewItem items = new ListViewItem(row);
        //    listView1.Items.Add(items);
        //}
        //private void FillList(List<TeamTournament> teamTournaments)
        //{
        //    listView1.Items.Clear();

        //    foreach (var myTeam in teamTournaments)
        //    {
        //        string[] row = { GetTeamName(myTeam.TeamId), GetTournamentName(myTeam.TournamentId) };
        //        listView1.Items.Add(new ListViewItem(row));
        //    }
        //}
        private TeamTournament? GetCurrentRow()
        {
            return this.teamTournamentBindingSource.Current as TeamTournament;
        }
        private void removeButton_Click(object sender, EventArgs e)
        {
            //var focussedItemIndex = listView1.FocusedItem?.Index;
            //if (focussedItemIndex.HasValue == false)
            //{
            //    return;
            //}
            //var allTeamTournaments = teamTournamentBindingSource.DataSource as List<TeamTournament>;
            //if (allTeamTournaments == null || allTeamTournaments.Any() == false) { return; }
            //var teamTournamentToDelete = allTeamTournaments[focussedItemIndex.Value];
            //if (teamTournamentToDelete != null)
            var currentRow = GetCurrentRow();
            if (currentRow != null)
            {
                DeleteRow(currentRow);
            }
        }
        private void DeleteRow(TeamTournament currentRow)
        {
            _teamTournamentRepository.Delete(currentRow);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var currentSelectedItem = GetCurrentRow();
            if (currentSelectedItem != null)
            {
                this.teamTournaments = currentSelectedItem;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            _teamTournamentRepository.Update(teamTournaments);
        }
    }
}
