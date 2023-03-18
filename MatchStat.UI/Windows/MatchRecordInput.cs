using ExpressMapper.Extensions;
using MatchStat.Core;
using MatchStat.DataModel.DataModels;
using System.Data;

namespace MatchStat.UI.Windows
{
    public partial class MatchRecordInput : Form
    {
        public EventHandler MatchSaved { get; set; }

        public MatchRecordInput()
        {
            InitializeComponent();
        }
        private MatchDetail? matchDetail
        {
            get { return this.matchDetailBindingSource.DataSource as MatchDetail; }
            set { this.matchDetailBindingSource.DataSource = value; }
        }
        private Team[] GetTeams()
        {
            using (var context = new FootballInfoContext())
            {
                var teams = context.Teams.OrderBy(t => t.Name).ToArray();
                return teams;
            }
        }
        private Fields[] GetFields()
        {
            using (var context = new FootballInfoContext())
            {
                var fields = context.Fields.OrderBy(f => f.Name).ToArray();
                return fields;
            }
        }
        private Tournament[] GetTournaments()
        {
            using (var context = new FootballInfoContext())
            {
                var tournaments = context.Tournaments.OrderBy(t => t.Name).ToArray();
                return tournaments;
            }
        }
        private MatchDetail[] GetMatches()
        {
            using (var context = new FootballInfoContext())
            {
                var matches = context.MatchDetails.OrderBy(m => m.Id).ToArray();
                return matches;
            }
        }
        private void MatchRecordInput_Load(object sender, EventArgs e)
        {
            var teams = GetTeams();
            this.teamBindingSource.DataSource = teams;
            this.teamBindingSource1.DataSource = teams;
            this.tournamentBindingSource.DataSource = GetTournaments();
            this.fieldsBindingSource.DataSource = GetFields();
            LoadMatches();
            matchDetail = new MatchDetail();
        }

        private void LoadMatches()
        {
            var match = GetMatches();
            this.matchDetailBindingSource.DataSource = match;
        }
        private void SaveMatchToDB(MatchDetail match)
        {
            using (var context = new FootballInfoContext())
            {
                var m = match.Map<MatchDetail, Match>();
                if (m.Id == 0)
                {
                    m.Id = GetMatchNextId();
                }
                context.MatchDetail.Add(m);
                context.SaveChanges();
            }
        }
        private int GetMatchNextId()
        {
            using (var context = new FootballInfoContext())
            {
                try
                {
                    var maximumId = context.MatchDetails.Max(r => r.Id);
                    return maximumId + 1;
                }
                catch (Exception ex)
                {
                    return 1;
                }
            }
        }
        private void saveMatchButton_Click(object sender, EventArgs e)
        {
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
