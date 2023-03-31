using MatchStat.DataModel.DataModels;
using MatchStat.Interfaces.Interfaces;

namespace MatchStat.UI.UserControls
{
    public partial class UcSingleMatch : UserControl
    {
        private readonly ITeamsRepository _teamsRepository;
        private readonly ITournamentsRepository _turnamentsRepository;
        private readonly IFieldsRepository _fieldsRepository;

        public UcSingleMatch(ITeamsRepository teamsRepository, ITournamentsRepository turnamentsRepository, IFieldsRepository fieldsRepository)
        {
            if (RuntimeChecker.IsRunTime)
            {
                InitializeWindow();
            }
            InitializeComponent();

            this._teamsRepository = teamsRepository;
            this._turnamentsRepository = turnamentsRepository;
            this._fieldsRepository = fieldsRepository;
        }

        private void InitializeWindow()
        {
            this.teamBindingSource.DataSource = _teamsRepository.GetAll();
            this.team_BindingSource.DataSource = _teamsRepository.GetAll();
            this.tournamentBindingSource.DataSource = _teamsRepository.GetAll();
            this.fieldsBindingSource.DataSource = _teamsRepository.GetAll();
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