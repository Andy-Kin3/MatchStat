using MatchStat.DataModel.DataModels;

namespace MatchStat.Core.EventArgs
{
    public class MatchSavedEventArguments : System.EventArgs
    {
        public MatchDetail SavedMatch { get; set; }
    }
}
