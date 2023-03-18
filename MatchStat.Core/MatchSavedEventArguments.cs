using MatchStat.DataModel.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchStat.Core
{
    public class MatchSavedEventArguments : EventArgs
    {
        public MatchDetail SavedMatch { get; set; }
    }
}
