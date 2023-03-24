using MatchStat.Database;
using MatchStat.DataModel.DataModels;
using MatchStat.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchStat.Repositories.Repositories
{
    public class TeamsRepository : ParentRepository<Team>, ITeamsRepository
    {
        public TeamsRepository(FootballInfoContext context) : base(context)
        {
        }

    }
}
