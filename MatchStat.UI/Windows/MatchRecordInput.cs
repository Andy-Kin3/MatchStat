using ExpressMapper.Extensions;
using MatchStat.Core;
using MatchStat.Core.EventArgs;
using MatchStat.DataModel.DataModels;
using MatchStat.Repositories.Repositories;
using System.Data;

namespace MatchStat.UI.Windows
{
    public partial class MatchRecordInput : Form
    {
        public EventHandler MatchSaved { get; set; }

        public MatchRecordInput()
        {
            InitializeComponent();
            InitializeWindow();
        }
        private void InitializeWindow()
        {
            var matchDetail = new MatchesRepository();
            matchDetailBindingSource.DataSource = matchDetail.GetAllMatches();
        }
        public MatchDetail? matchDetail
        {
            get { return this.ucSingleMatch1.match as MatchDetail; }
            set { this.matchDetailBindingSource.DataSource = value; }
        }
        private void MatchRecordInput_Load(object sender, EventArgs e)
        {
            LoadMatches();
            matchDetail = new MatchDetail();
        }

        private void LoadMatches()
        {
            var match = new MatchesRepository();
            this.matchDetailBindingSource.DataSource = match.GetAllMatches();
        }
        private void SaveMatchToDB(MatchDetail match)
        {
            var saveMatch = new MatchesRepository();
            saveMatch.AddMatches(match);
        }
        private void UpdateMatch(MatchDetail match)
        {
            var updateMatch = new MatchesRepository();
            updateMatch.UpdateMatch(match);
        }
        private void saveMatchButton_Click(object sender, EventArgs e)
        {
            if(matchDetail.Id > 0)
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
