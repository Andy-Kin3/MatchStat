using MatchStat.Core.EventArgs;
using MatchStat.DataModel.DataModels;
using MatchStat.Repositories.Repositories;

namespace MatchStat.UI.Windows
{
    public partial class MatchRecordWindow : Form
    {
        public MatchRecordWindow()
        {
            InitializeComponent();
        }

        private MatchDetail? matchDetail
        {
            get { return this.matchDetailBindingSource.DataSource as MatchDetail; }
            set { this.matchDetailBindingSource.DataSource = value; }
        }
        private void LoadMatchRecords()
        {
            var allMatches = new MatchesRepository();
            this.matchDetailBindingSource.DataSource = allMatches.GetAllMatches();
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
            var matchRecordInput = new MatchRecordInput();
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
