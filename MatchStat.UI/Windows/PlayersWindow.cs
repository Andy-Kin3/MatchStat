using MatchStat.DataModel.DataModels;
using MatchStat.Interfaces;

namespace MatchStat.UI
{
    public partial class PlayersWindow : Form
    {
        private readonly IPlayersRepository _playerRepository;
        private readonly ITeamsRepository _teamsRepository;
        public PlayersWindow(ITeamsRepository teamsRepository, IPlayersRepository playersRepository)
        {
            InitializeComponent();
            _teamsRepository = teamsRepository;
            _playerRepository = playersRepository;
        }
        private Player? Player
        {
            get { return this.playerBindingSource.DataSource as Player; }

            set { this.playerBindingSource.DataSource = value; }
        }

        private void LoadPlayers()
        {
            playerBindingSource.DataSource = _playerRepository.GetAll();
            teamBindingSource.DataSource = _teamsRepository.GetAll();
            //_teamsRepository.GetTeamName(teamCbo.SelectedValue);
        }


        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "TeamName")
            {
                int teamId;
                if (int.TryParse(e.Value?.ToString(), out teamId))
                    e.Value = _teamsRepository.GetTeamName(teamId);
            }
        }
        //private int GetNextId()
        //{
        //    var allPlayers = playerBindingSource.DataSource as List<Player>;
        //    var maximumId = allPlayers != null && allPlayers.Any() ? allPlayers.Max(x => x.Id) : 0;
        //    var returnValue = maximumId + 1;
        //    return returnValue;
        //}

        private void createPlayerButton_Click(object sender, EventArgs e)
        {
            Saveplayers(Player);
            LoadPlayers();
            playerFirstName.Clear();
            playerLastName.Clear();
        }

        private void Players_Load(object sender, EventArgs e)
        {
            LoadPlayers();
        }
        private void Saveplayers(Player player)
        {
            _playerRepository.Add(player);
        }

        private void deletePlayerButton_Click(object sender, EventArgs e)
        {
            var currentlySelected = playerBindingSource.Current as Player;
            if (currentlySelected != null)
            {
                _playerRepository.Delete(currentlySelected);
                LoadPlayers();
            }
        }
    }
}
