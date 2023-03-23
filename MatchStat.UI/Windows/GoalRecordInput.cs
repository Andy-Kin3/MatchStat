using MatchStat.Core.EventArgs;
using MatchStat.DataModel.DataModels;
using MatchStat.Repositories.Repositories;
using Microsoft.EntityFrameworkCore.Metadata;

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

        public void SaveGoal(Goal goal)
        {
            var savedGoal = new GoalRepository();
            savedGoal.AddGoal(goal);

        }
        public void UpdateEditedGoal(Goal g)
        {
            var updatedGoal = new GoalRepository();
            updatedGoal.AddGoal(g);

        }
        private void button_saveGoal_Click(object sender, EventArgs e)
        {
            if (Goal.Id > 0)
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
