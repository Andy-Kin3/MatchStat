using MatchStat.DataModel.DataModels;
using MatchStat.Interfaces.RepositoryInterfaces;

namespace MatchStat.UI.Windows
{
    public partial class MatchesStoredProcedureWindow : Form
    {
        IMatchStoreProcedure _matchStoreProcedure;
        public MatchesStoredProcedureWindow(IMatchStoreProcedure matchStoreProcedurerepo)
        {
            InitializeComponent();
            _matchStoreProcedure = matchStoreProcedurerepo;
        }
        private MyMatchStoredProcedure? matchStoredProcedure
        {
            get { return this.myMatchStoredProcedureBindingSource.DataSource as MyMatchStoredProcedure; }
            set { this.myMatchStoredProcedureBindingSource.DataSource = value; }
        }

        private void MatchesProceduresWindow_Load(object sender, EventArgs e)
        {
            myMatchStoredProcedureBindingSource.DataSource = _matchStoreProcedure.GetMatches();
        }
    }
}
