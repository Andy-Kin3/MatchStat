using MatchStat.Core.EventArgs;
using MatchStat.DataModel.DataModels;
using MatchStat.Interfaces.Interfaces;

namespace MatchStat.UI.Windows
{
    public partial class GoalRecordInput : Form
    {
        IGoalRepository _goalRepo; 
        IMatchesRepository _matchesRepo;
        IPlayersRepository _playersRepo;

        public EventHandler GoalSaved { get; set; }

        public GoalRecordInput(IGoalRepository goalRepo, IMatchesRepository matchesRepository, IPlayersRepository playersRepo,  Goal g = null)
        {
            InitializeComponent();
            this._goalRepo = goalRepo;
            this._matchesRepo = matchesRepository;
            this._playersRepo = playersRepo;
        }

        public Goal? Goal
        {
            get { return this.ucSingleGoal1.Goal; }
            set { this.ucSingleGoal1.Goal = value; }
        }

        public void SaveGoal(Goal goal)
        {
            _goalRepo.Add(goal);

        }
        public void UpdateEditedGoal(Goal g)
        {
            _goalRepo.Update(g);

        }
        private void button_saveGoal_Click(object sender, EventArgs e)
        {
            if (Goal?.Id > 0)
            {
                UpdateEditedGoal(Goal);
            }
            else //if(Goal?.Id == null)
            {
                SaveGoal(Goal);
            }
            var eventArguments = new GoalSavedEventArguments
            {
                SavedGoals = Goal
            };
            GoalSaved?.Invoke(this, e);
        }

        private void GoalRecordInput_Load(object sender, EventArgs e)
        {
            if (Goal == null)
            {
                Goal = new Goal();
            }
        }

    }
}
