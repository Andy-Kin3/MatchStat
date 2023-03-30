using MatchStat.DataModel.DataModels;

namespace MatchStat.MyEventArguments.EventArgs
{
    public class MatchSavedEventArguments : System.EventArgs
    {
        public MatchDetail SavedMatch { get; set; }
    }
}
