using MatchStat.DataModel.DataModels;

namespace MatchStat.Core.EventArgs
{
    public class GoalSavedEventArguments : System.EventArgs
    {
        public Goal SavedGoals { get; set; }
    }
}
