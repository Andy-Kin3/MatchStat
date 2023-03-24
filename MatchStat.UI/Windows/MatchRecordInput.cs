using MatchStat.Core;
using MatchStat.Core.EventArgs;
using MatchStat.DataModel.DataModels;
using MatchStat.Repositories.Repositories;

namespace MatchStat.UI.Windows
{
    public partial class MatchRecordInput : Form
    {
        public EventHandler MatchSaved { get; set; }
        MatchesRepository _matchesRepository;

        public MatchRecordInput()
        {
            InitializeComponent();
            _matchesRepository = new MatchesRepository();
            InitializeWindow();

        }
        private void InitializeWindow()
        {

            matchDetailBindingSource.DataSource = _matchesRepository.GetAllMatches();
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
            this.matchDetailBindingSource.DataSource = _matchesRepository.GetAllMatches();
        }
        private void SaveMatchToDB(MatchDetail match)
        {
            _matchesRepository.AddMatches(match);
        }
        private void UpdateMatch(MatchDetail match)
        {;
            _matchesRepository.UpdateMatch(match);
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
