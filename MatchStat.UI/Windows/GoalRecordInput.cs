using MatchStat.Core;
using MatchStat.DataModel.DataModels;

namespace MatchStat.UI.Windows
{
    public partial class GoalRecordInput : Form
    {
        public EventHandler GoalSaved { get; set; }

        public GoalRecordInput(Goal g = null)
        {
            InitializeComponent();

        }

        public Goal? Goal
        {
            get { return this.ucSingleGoal1.Goal; }
            set { this.ucSingleGoal1.Goal = value; }
        }

        private void saveGoal(Goal goal)
        {
            using (var context = new FootballInfoContext())
            {
                var g = goal;
                if (g.Id == 0)
                {
                    g.Id = GetNextGoalId();
                }
                context.Goals.Add(Goal);
                context.SaveChanges();
            }
        }
        private void UpdateMatches(Goal g)
        {
            using(var context = new FootballInfoContext())
            {
                var goal = g;
                context.Goals.Update(goal);
                context.SaveChanges();
            }

        }
        private int GetNextGoalId()
        {
            using (var context = new FootballInfoContext())
            {
                try
                {
                    var maximumId = context.Goals.Max(g => g.Id);
                    var nextId = maximumId + 1;
                    if (nextId == maximumId + 1)
                    {
                        return nextId + 1;
                    }
                    return nextId;
                }
                catch (Exception ex)
                {
                    return 1;
                }
            }
        }
        private void button_saveGoal_Click(object sender, EventArgs e)
        {
            saveGoal(Goal);
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
