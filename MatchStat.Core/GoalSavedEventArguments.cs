using MatchStat.DataModel.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchStat.Core
{
    public class GoalSavedEventArguments: EventArgs
    {
        public Goal SavedGoals { get; set; }
    }
}
