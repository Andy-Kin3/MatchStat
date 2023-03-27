using MatchStat.Core.EventArgs;
using MatchStat.Database;
using MatchStat.DataModel.DataModels;
using MatchStat.Interfaces.Interfaces;
using MatchStat.Repositories.Repositories;

namespace MatchStat.UI.Windows
{
    public partial class GoalRecordWindow : Form
    {
        IGoalRepository _goalRepository;
        IPlayersRepository _playersRepository;
        IMatchesRepository _matchesRepository;

        //private Goal? goal
        //{
        //    get { return goalBindingSource.DataSource as Goal; }
        //    set { this.goalBindingSource.DataSource = value; }
        //}
        public GoalRecordWindow(IPlayersRepository playersRepository, IGoalRepository goalRepository)
        {
            InitializeComponent();
            _playersRepository = playersRepository;
            _goalRepository = goalRepository;
        }
        private void LoadGoals()
        {
            goalBindingSource.DataSource = _goalRepository.GetAll();
        }


        private void DataGridView1_cellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Index == 0)
            {
                int playerId;
                if (int.TryParse(e.Value?.ToString(), out playerId))
                {
                    e.Value = _goalRepository.GetPlayerFullName(playerId);
                }

            }
            if (dataGridView1.Columns[e.ColumnIndex].Index == 1)
            {
                int matchId;
                if (int.TryParse(e.Value?.ToString(), out matchId))
                {
                    e.Value = _goalRepository.GetMatchName(matchId);
                }

            }
        }
        private Goal? CurrentGoal()
        {
            return this.goalBindingSource.Current as Goal;
        }

        private void button_CreateGoal_Click(object sender, EventArgs e)
        {
            InvokeGoalRecordInput();
        }
        private void InvokeGoalRecordInput(Goal? g = null)
        {

            var goalFrm = new GoalRecordInput(_goalRepository, _matchesRepository, _playersRepository);
            if (g != null)
            {
                goalFrm.Goal = g;
            }
            goalFrm.GoalSaved += GoalSaved;
            goalFrm.ShowDialog();
        }
        private void GoalSaved(object sender, EventArgs e)
        {
            var goalRecordInput = sender as GoalRecordInput;

            var eventArgs = e as GoalSavedEventArguments;
            var savedMatch = eventArgs?.SavedGoals;

            goalRecordInput?.Close();
            LoadGoals();
        }


        private void GoalRecordWindow_Load(object sender, EventArgs e)
        {
            LoadGoals();
        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenuStrip_goal.Show(MousePosition);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var currentlySelected = CurrentGoal();
            if (currentlySelected != null)
            {
                DeleteGoal(currentlySelected);
            }
        }
        public void DeleteGoal(Goal goalId)
        {
            _goalRepository.Delete(goalId);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCurrentGoal();
        }

        private void EditCurrentGoal()
        {
            var currentSelected = CurrentGoal();
            InvokeGoalRecordInput(currentSelected);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditCurrentGoal();
        }
    }
}
