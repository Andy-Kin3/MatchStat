using MatchStat.Core;
using MatchStat.DataModel.DataModels;
using MatchStat.Repositories.Repositories;

namespace MatchStat.UI.UserControls
{
    public partial class UcSingleMatch : UserControl
    {
        public UcSingleMatch()
        {
            InitializeComponent();
            if (GlobalFunctions.IsRunTime)
            {
                InitializeWindow();
            }
        }

        private void InitializeWindow()
        {
            var teams = new TeamsRepository();
            this.teamBindingSource.DataSource = teams.GetAllTeams();
            this.teamBindingSource1.DataSource = teams.GetAllTeams();
            var allTournaments = new TounamentsRepository();
            this.tournamentBindingSource.DataSource = allTournaments.GetTournaments();
            var fields = new FieldRepository();
            this.fieldsBindingSource.DataSource = fields.GetAllFields();
        }

        public MatchDetail? match
        {
            get
            {
                return this.matchDetailBindingSource.DataSource as MatchDetail;
            }
            set
            {
                var match = value ?? new MatchDetail();
                this.matchDetailBindingSource.DataSource = match;
            }
        }
    }
}
