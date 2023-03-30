using MatchStat.DataModel.DataModels;

namespace MatchStat.MyEventArguments.EventArgs
{
    public class GoalSavedEventArguments : System.EventArgs
    {
        public Goal SavedGoals { get; set; }
    }
}
