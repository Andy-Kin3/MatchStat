using MatchStat.Core.EventArgs;
using MatchStat.DataModel.DataModels;
using MatchStat.Interfaces;
using MatchStat.Repositories.Repositories;

namespace MatchStat.UI.Windows
{
    public partial class MatchRecordWindow : Form
    {
        private readonly IMatchesRepository _matchesRepository;
        private readonly ITeamsRepository _teamsRepository;
        private readonly ITournamentsRepository _turnamentsRepository;
        private readonly IFieldsRepository _fieldsRepository;
        public MatchRecordWindow(IMatchesRepository repo)
        {
            InitializeComponent();
            _matchesRepository = repo;
        }

        private MatchDetail? matchDetail
        {
            get { return this.matchDetailBindingSource.DataSource as MatchDetail; }
            set { this.matchDetailBindingSource.DataSource = value; }
        }
        private void LoadMatchRecords()
        {
            this.matchDetailBindingSource.DataSource = _matchesRepository.GetAll();
        }

        private void MatchRecordWindow_Load(object sender, EventArgs e)
        {
            LoadMatchRecords();
        }

        private void createMatchButton_Click(object sender, EventArgs e)
        {
            InvokeMatchesRecordInput();
        }
        private void InvokeMatchesRecordInput(MatchDetail m = null)
        {
            var matchRecordInput = new MatchRecordInput(_matchesRepository, _teamsRepository, _turnamentsRepository, _fieldsRepository);
            if (m != null)
            {
                matchRecordInput.matchDetail = m;
            }
            matchRecordInput.MatchSaved += NewMatchSaved;
            matchRecordInput.ShowDialog();
        }
        private MatchDetail? GetCurrentMAtch()
        {
            return this.matchDetailBindingSource.Current as MatchDetail;
        }
        private void NewMatchSaved(object sender, EventArgs e)
        {
            var matchRecordInput = sender as MatchRecordInput;

            //if(matchRecordInput != null)
            //{
            //    matchRecordInput.Close();
            //}

            var eventArgs = e as MatchSavedEventArguments;
            var savedMatch = eventArgs.SavedMatch;

            matchRecordInput?.Close();
            LoadMatchRecords();
        }
        private void EditMatchInFo()
        {
            var currentSelectedMatch = GetCurrentMAtch();
            InvokeMatchesRecordInput(currentSelectedMatch);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditMatchInFo();
        }

        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenuStrip1.Show(MousePosition);
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EditMatchInFo();
        }
    }
}
