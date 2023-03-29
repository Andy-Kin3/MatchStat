using MatchStat.Core.EventArgs;
using MatchStat.DataModel.DataModels;
using MatchStat.Interfaces.Interfaces;

namespace MatchStat.UI.Windows
{
    public partial class MatchRecordInput : Form
    {
        public EventHandler MatchSaved { get; set; }
        IMatchesRepository _matchesRepository;
        ITeamsRepository _teamsRepository;
        ITournamentsRepository _turnamentsRepository;
        IFieldsRepository _fieldsRepository;

        public MatchRecordInput(IMatchesRepository mathcRepository, ITeamsRepository teamsRepository, ITournamentsRepository turnamentsRepository, IFieldsRepository fieldsRepository)
        {
            InitializeComponent();
            _matchesRepository = mathcRepository;
            InitializeWindow();

        }
        private void InitializeWindow()
        {

            matchDetailBindingSource.DataSource = _matchesRepository.GetAll();
        }
        public MatchDetail? matchDetail
        {
            get { return this.ucSingleMatch.match as MatchDetail; }
            set { this.ucSingleMatch.match = value; }
        }
        private void MatchRecordInput_Load(object sender, EventArgs e)
        {
            LoadMatches();
            matchDetail = new MatchDetail();
        }

        private void LoadMatches()
        {
            this.matchDetailBindingSource.DataSource = _matchesRepository.GetAll();
        }
        private void SaveMatchToDB(MatchDetail match)
        {
            _matchesRepository.Add(match);
        }
        private void UpdateMatch(MatchDetail match)
        {
            ;
            _matchesRepository.Update(match);
        }
        private void saveMatchButton_Click(object sender, EventArgs e)
        {
            if (matchDetail.Id > 0)
            {
                UpdateMatch(matchDetail);
            }
            SaveMatchToDB(matchDetail);

            //if (MatchSaved != null)
            //{
            //    MatchSaved.Invoke(sender, e);
            //}

            var eventArguments = new MatchSavedEventArguments
            {
                SavedMatch = matchDetail
            };
            MatchSaved?.Invoke(this, eventArguments);
        }
    }
}
